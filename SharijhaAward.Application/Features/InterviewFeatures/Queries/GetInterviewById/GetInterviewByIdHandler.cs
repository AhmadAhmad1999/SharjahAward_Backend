using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class GetInterviewByIdHandler : IRequestHandler<GetInterviewByIdQuery, BaseResponse<GetInterviewByIdDto>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository;
        private readonly IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository;

        public GetInterviewByIdHandler(IAsyncRepository<Interview> _InterviewRepository,
            IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository,
            IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository)
        {
            this._InterviewRepository = _InterviewRepository;
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
            this._InterviewInviteeParticipantRepository = _InterviewInviteeParticipantRepository;
            this._InterviewInviteeNoteAndQuestionRepository = _InterviewInviteeNoteAndQuestionRepository;
        }

        public async Task<BaseResponse<GetInterviewByIdDto>> Handle(GetInterviewByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntity = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (InterviewEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview is not Found"
                    : "المقابلة غير موجودة";

                return new BaseResponse<GetInterviewByIdDto>(ResponseMessage, false, 404);
            }

            List<InterviewInvitee> InterviewInviteeEntities = await _InterviewInviteeRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

            List<InterviewInviteeParticipant> InterviewInviteeParticipantEntities = await _InterviewInviteeParticipantRepository
                .Where(x => InterviewInviteeEntities.Select(y => y.Id).Contains(x.InterviewInviteeId))
                .ToListAsync();

            List<InterviewInviteeNoteAndQuestion> InterviewInviteeNoteAndQuestionEntities = await _InterviewInviteeNoteAndQuestionRepository
                .Where(x => InterviewInviteeEntities.Select(y => y.Id).Contains(x.InterviewInviteeId))
                .ToListAsync();

            GetInterviewByIdDto Response = new GetInterviewByIdDto()
            {
                Id = Request.Id,
                ArabicName = InterviewEntity.ArabicName,
                EnglishName = InterviewEntity.EnglishName,
                ArabicDescription = InterviewEntity.ArabicDescription,
                EnglishDescription = InterviewEntity.EnglishDescription,
                StartDate = InterviewEntity.StartDate,
                Type = InterviewEntity.Type,
                ArabicText = InterviewEntity.ArabicText,
                EnglishText = InterviewEntity.EnglishText,
                Address = InterviewEntity.Address,
                PeriodOfEachInviteeInMinutes = InterviewEntity.PeriodOfEachInviteeInMinutes,
                Invitees = InterviewInviteeEntities
                    .Where(y => y.InterviewId == Request.Id)
                    .Select(y => new InterviewInviteeDto()
                    {
                        Id = y.Id,
                        OrderId = y.OrderId,
                        InterviewId = y.InterviewId,
                        isCancelled = y.isCancelled,
                        ArabicReasonForCancelling = y.ArabicReasonForCancelling,
                        EnglishReasonForCancelling = y.EnglishReasonForCancelling,
                        isImplemented = y.isImplemented,
                        StartDate = y.StartDate,
                        EndDate = y.EndDate,
                        InviteeLink = y.InviteeLink,
                        ExternalUsersEmails = InterviewInviteeParticipantEntities
                            .Where(z => z.InterviewInviteeId == y.Id &&
                                !string.IsNullOrEmpty(z.ExternalUserEmail))
                            .Select(z => z.ExternalUserEmail!).ToList(),
                        ArbitratorsIds = InterviewInviteeParticipantEntities
                            .Where(z => z.InterviewInviteeId == y.Id &&
                                z.ArbitratorId != null)
                            .Select(z => z.ArbitratorId!.Value).ToList(),
                        SubscribersIds = InterviewInviteeParticipantEntities
                            .Where(z => z.InterviewInviteeId == y.Id &&
                                z.SubscriberId != null)
                            .Select(z => z.SubscriberId!.Value).ToList(),
                        Notes = InterviewInviteeNoteAndQuestionEntities
                            .Where(z => z.InterviewInviteeId == y.Id &&
                                !z.isQuestion)
                            .Select(z => new InterviewInviteeNoteAndQuestionDto()
                            {
                                Id = z.Id,
                                ArabicText = z.ArabicText,
                                EnglishText = z.EnglishText,
                                InterviewInviteeId = z.InterviewInviteeId
                            }).ToList(),
                        Questions = InterviewInviteeNoteAndQuestionEntities
                            .Where(z => z.InterviewInviteeId == y.Id &&
                                z.isQuestion)
                            .Select(z => new InterviewInviteeNoteAndQuestionDto()
                            {
                                Id = z.Id,
                                ArabicText = z.ArabicText,
                                EnglishText = z.EnglishText,
                                InterviewInviteeId = z.InterviewInviteeId
                            }).ToList()
                    }).ToList()
            };

            return new BaseResponse<GetInterviewByIdDto>(ResponseMessage, true, 200, Response);
        }
    }
}
