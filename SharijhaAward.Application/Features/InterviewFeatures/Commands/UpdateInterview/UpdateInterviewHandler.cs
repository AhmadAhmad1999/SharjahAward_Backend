using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.UpdateInterview
{
    public class UpdateInterviewHandler : IRequestHandler<UpdateInterviewCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository;
        private readonly IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository;
        private readonly IMapper _Mapper;

        public UpdateInterviewHandler(IAsyncRepository<Interview> _InterviewRepository,
            IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository,
            IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository,
            IMapper _Mapper)
        {
            this._InterviewRepository = _InterviewRepository;
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
            this._InterviewInviteeParticipantRepository = _InterviewInviteeParticipantRepository;
            this._InterviewInviteeNoteAndQuestionRepository = _InterviewInviteeNoteAndQuestionRepository;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntity = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (InterviewEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview is not Found"
                    : "المقابلة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (Request.Type == Domain.Constants.MeetingTypes.OnSite &&
                string.IsNullOrEmpty(Request.Address) ||
                (InterviewEntity.Type == Domain.Constants.MeetingTypes.OnSite &&
                string.IsNullOrEmpty(Request.Address) &&
                Request.Type == Domain.Constants.MeetingTypes.OnSite))
            {
                ResponseMessage = Request.lang == "en"
                    ? "If the interview type is onsite then you have to insert the address"
                    : "إذا كان نوع المقابلة في الموقع، فيجب عليك إدخال العنوان";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    _Mapper.Map(Request, InterviewEntity, typeof(UpdateInterviewCommand), typeof(Interview));
                    
                    await _InterviewRepository.UpdateAsync(InterviewEntity);

                    IEnumerable<InterviewInviteeNoteAndQuestion> InterviewInviteeNoteAndQuestionEntitiesToAdd = new List<InterviewInviteeNoteAndQuestion>();
                    
                    IEnumerable<InterviewInviteeParticipant> InterviewInviteeParticipantEntitiesToAdd = new List<InterviewInviteeParticipant>();

                    List<InterviewInvitee> InterviewInviteeEntities = await _InterviewInviteeRepository
                        .Where(x => Request.Invitees.Select(y => y.Id).Contains(x.Id))
                        .ToListAsync();

                    IEnumerable<InterviewInviteeNoteAndQuestion> InterviewInviteeNoteAndQuestionEntitiesToDelete = await _InterviewInviteeNoteAndQuestionRepository
                        .Where(x => InterviewInviteeEntities.Select(y => y.Id).Contains(x.InterviewInviteeId))
                        .ToListAsync();

                    IEnumerable<InterviewInviteeParticipant> InterviewInviteeParticipantEntitiesToDelete = await _InterviewInviteeParticipantRepository
                        .Where(x => InterviewInviteeEntities.Select(y => y.Id).Contains(x.InterviewInviteeId))
                        .ToListAsync();

                    foreach (UpdateInterviewInviteeDto Invitee in Request.Invitees)
                    {
                        int InterviewInviteeEntityId = 0;

                        if (Invitee.Id is not 0)
                            InterviewInviteeEntityId = Invitee.Id;

                        else
                        {
                            InterviewInvitee NewInterviewInviteeEntity = new InterviewInvitee()
                            {
                                OrderId = Invitee.OrderId,
                                InterviewId = InterviewEntity.Id,
                                StartDate = InterviewEntity.StartDate
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1)),
                                EndDate = InterviewEntity.StartDate
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes),
                                InviteeLink = Invitee.InviteeLink
                            };

                            await _InterviewInviteeRepository.AddAsync(NewInterviewInviteeEntity);

                            InterviewInviteeEntityId = NewInterviewInviteeEntity.Id;
                        }

                        InterviewInvitee? InterviewInviteeEntityToUpdate = InterviewInviteeEntities
                            .FirstOrDefault(x => x.Id == InterviewInviteeEntityId);

                        if (InterviewInviteeEntityToUpdate is not null)
                        {
                            _Mapper.Map(Invitee, InterviewInviteeEntityToUpdate, typeof(UpdateInterviewInviteeDto), typeof(InterviewInvitee));

                            InterviewInviteeEntityToUpdate.StartDate = Request.StartDate
                                .AddMinutes(Request.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1));

                            InterviewInviteeEntityToUpdate.EndDate = Request.StartDate
                                .AddMinutes(Request.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                .AddMinutes(Request.PeriodOfEachInviteeInMinutes);

                            await _InterviewInviteeRepository.UpdateAsync(InterviewInviteeEntityToUpdate);
                        }

                        List<string> CheckForDuplicatedEmails = Invitee.ExternalUsersEmails
                            .GroupBy(x => x.ToLower())
                            .Where(x => x.Count() > 1)
                            .Select(x => x.Key)
                            .ToList();

                        if (CheckForDuplicatedEmails.Any())
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"in invitee number: {Invitee.OrderId}, the following emails are duplicated: {string.Join(", ", CheckForDuplicatedEmails)}"
                                : $"في الدعوة ذات الرقم: {Invitee.OrderId} البُرُد الإلكترونية التالية مكررة: {string.Join(", ", CheckForDuplicatedEmails)}";

                            return new BaseResponse<object>(ResponseMessage, false, 400);
                        }

                        List<InterviewInviteeNoteAndQuestion> InterviewNoteEntitiesToDelete = await _InterviewInviteeNoteAndQuestionRepository
                            .Where(x => x.InterviewInviteeId == Request.Id)
                            .ToListAsync();

                        InterviewInviteeNoteAndQuestionEntitiesToDelete = InterviewInviteeNoteAndQuestionEntitiesToDelete
                            .Concat(InterviewNoteEntitiesToDelete);

                        if (Invitee.SubscribersIds.Any())
                            Invitee.SubscribersIds = Invitee.SubscribersIds.Distinct().ToList();

                        if (Invitee.ArbitratorsIds.Any())
                            Invitee.ArbitratorsIds = Invitee.ArbitratorsIds.Distinct().ToList();

                        IEnumerable<InterviewInviteeParticipant> InviteeArbitrators = Invitee.ArbitratorsIds
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = InterviewInviteeEntityId,
                                ArbitratorId = x,
                                CanImplementTheInterview = true
                            });

                        IEnumerable<InterviewInviteeParticipant> InviteeSubscribers = Invitee.SubscribersIds
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = InterviewInviteeEntityId,
                                SubscriberId = x,
                                CanImplementTheInterview = true
                            });

                        IEnumerable<InterviewInviteeParticipant> InviteeExternalUsers = Invitee.ExternalUsersEmails
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = InterviewInviteeEntityId,
                                ExternalUserEmail = x,
                                CanImplementTheInterview = true
                            });

                        InterviewInviteeParticipantEntitiesToAdd = InterviewInviteeParticipantEntitiesToAdd
                            .Concat(InviteeArbitrators)
                            .Concat(InviteeSubscribers)
                            .Concat(InviteeExternalUsers);

                        IEnumerable<InterviewInviteeNoteAndQuestion> InviteeNotes = Invitee.Notes
                            .Select(x => new InterviewInviteeNoteAndQuestion()
                            {
                                ArabicText = x.ArabicText,
                                EnglishText = x.EnglishText,
                                InterviewInviteeId = InterviewInviteeEntityId,
                                isQuestion = false
                            });

                        IEnumerable<InterviewInviteeNoteAndQuestion> InviteeQuestions = Invitee.Questions
                            .Select(x => new InterviewInviteeNoteAndQuestion()
                            {
                                ArabicText = x.ArabicText,
                                EnglishText = x.EnglishText,
                                InterviewInviteeId = InterviewInviteeEntityId,
                                isQuestion = true
                            });

                        InterviewInviteeNoteAndQuestionEntitiesToAdd = InterviewInviteeNoteAndQuestionEntitiesToAdd
                            .Concat(InviteeNotes)
                            .Concat(InviteeQuestions);
                    }

                    await _InterviewInviteeParticipantRepository.DeleteListAsync(InterviewInviteeParticipantEntitiesToDelete);
                    await _InterviewInviteeParticipantRepository.AddRangeAsync(InterviewInviteeParticipantEntitiesToAdd);

                    await _InterviewInviteeNoteAndQuestionRepository.DeleteListAsync(InterviewInviteeNoteAndQuestionEntitiesToDelete);
                    await _InterviewInviteeNoteAndQuestionRepository.AddRangeAsync(InterviewInviteeNoteAndQuestionEntitiesToAdd);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Updated successfully"
                        : "تم تعديل المقابلة بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
