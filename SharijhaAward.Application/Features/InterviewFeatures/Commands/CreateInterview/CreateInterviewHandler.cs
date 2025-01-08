using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateInterview
{
    public class CreateInterviewHandler : IRequestHandler<CreateInterviewCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository;
        private readonly IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository;

        public CreateInterviewHandler(IMapper _Mapper,
            IAsyncRepository<Interview> _InterviewRepository,
            IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository,
            IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository)
        {
            this._Mapper = _Mapper;
            this._InterviewRepository = _InterviewRepository;
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
            this._InterviewInviteeParticipantRepository = _InterviewInviteeParticipantRepository;
            this._InterviewInviteeNoteAndQuestionRepository = _InterviewInviteeNoteAndQuestionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.Type == Domain.Constants.MeetingTypes.OnSite &&
                string.IsNullOrEmpty(Request.Address))
            {
                ResponseMessage = Request.lang == "en"
                    ? "If the interview type is onsite then you have to insert the address"
                    : "إذا كان نوع المقابلة في الموقع، فيجب عليك إدخال العنوان";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            else if (Request.Type == Domain.Constants.MeetingTypes.Virtual &&
                Request.Invitees.Any(x => string.IsNullOrEmpty(x.InviteeLink)))
            {
                ResponseMessage = Request.lang == "en"
                    ? "If the interview type is virtual then you have to insert the invitee link for all the invitees"
                    : "إذا كان نوع المقابلة افتراضيًا، فيجب عليك إدخال رابط المدعوين لجميع المدعوين";

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
                    Interview NewInterviewEntity = _Mapper.Map<Interview>(Request);

                    await _InterviewRepository.AddAsync(NewInterviewEntity);

                    IEnumerable<InterviewInviteeParticipant> NewInterviewInviteeParticipantEntities = new List<InterviewInviteeParticipant>();
                    IEnumerable<InterviewInviteeNoteAndQuestion> NewInterviewInviteeNoteAndQuestionEntities = new List<InterviewInviteeNoteAndQuestion>();

                    foreach (CreateInterviewInviteeDto Invitee in Request.Invitees)
                    {
                        IEnumerable<string> CheckForDuplicatedEmails = Invitee.ExternalUsersEmails
                            .GroupBy(x => x.ToLower())
                            .Where(x => x.Count() > 1)
                            .Select(x => x.Key);

                        if (CheckForDuplicatedEmails.Any())
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"in invitee number: {Invitee.OrderId}, the following emails are duplicated: {string.Join(", ", CheckForDuplicatedEmails)}"
                                : $"في الدعوة ذات الرقم: {Invitee.OrderId} البُرُد الإلكترونية التالية مكررة: {string.Join(", ", CheckForDuplicatedEmails)}";

                            return new BaseResponse<object>(ResponseMessage, false, 400);
                        }

                        if (Invitee.SubscribersIds.Any())
                            Invitee.SubscribersIds = Invitee.SubscribersIds.Distinct().ToList();

                        if (Invitee.ArbitratorsIds.Any())
                            Invitee.ArbitratorsIds = Invitee.ArbitratorsIds.Distinct().ToList();

                        InterviewInvitee NewInterviewInviteeEntity = new InterviewInvitee()
                        {
                            OrderId = Invitee.OrderId,
                            InterviewId = NewInterviewEntity.Id,
                            StartDate = NewInterviewEntity.StartDate
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1)),
                            EndDate = NewInterviewEntity.StartDate
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes),
                            InviteeLink = Invitee.InviteeLink
                        };

                        await _InterviewInviteeRepository.AddAsync(NewInterviewInviteeEntity);

                        IEnumerable<InterviewInviteeParticipant> InviteeArbitrators = Invitee.ArbitratorsIds
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                ArbitratorId = x,
                                CanImplementTheInterview = true
                            });

                        IEnumerable<InterviewInviteeParticipant> InviteeSubscribers = Invitee.SubscribersIds
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                SubscriberId = x,
                                CanImplementTheInterview = true
                            });

                        IEnumerable<InterviewInviteeParticipant> InviteeExternalUsers = Invitee.ExternalUsersEmails
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                ExternalUserEmail = x,
                                CanImplementTheInterview = true
                            });

                        NewInterviewInviteeParticipantEntities = NewInterviewInviteeParticipantEntities
                            .Concat(InviteeArbitrators)
                            .Concat(InviteeSubscribers)
                            .Concat(InviteeExternalUsers);

                        IEnumerable<InterviewInviteeNoteAndQuestion> InviteeNotes = Invitee.Notes
                            .Select(x => new InterviewInviteeNoteAndQuestion()
                            {
                                ArabicText = x.ArabicText,
                                EnglishText = x.EnglishText,
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                isQuestion = false
                            });

                        IEnumerable<InterviewInviteeNoteAndQuestion> InviteeQuestions = Invitee.Questions
                            .Select(x => new InterviewInviteeNoteAndQuestion()
                            {
                                ArabicText = x.ArabicText,
                                EnglishText = x.EnglishText,
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                isQuestion = true
                            });

                        NewInterviewInviteeNoteAndQuestionEntities = NewInterviewInviteeNoteAndQuestionEntities
                            .Concat(InviteeNotes)
                            .Concat(InviteeQuestions);
                    }

                    await _InterviewInviteeParticipantRepository.AddRangeAsync(NewInterviewInviteeParticipantEntities);
                    await _InterviewInviteeNoteAndQuestionRepository.AddRangeAsync(NewInterviewInviteeNoteAndQuestionEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المقابلة بنجاح";

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