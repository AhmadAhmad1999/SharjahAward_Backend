using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.DeleteMeeting
{
    public class DeleteMeetingHandler : IRequestHandler<DeleteMeetingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IAsyncRepository<MeetingUser> _MeetingUserRepository;
        public DeleteMeetingHandler(IAsyncRepository<Meeting> MeetingRepository,
            IAsyncRepository<MeetingUser> MeetingUserRepository)
        {
            _MeetingRepository = MeetingRepository;
            _MeetingUserRepository = MeetingUserRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteMeetingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Meeting? MeetingEntityToDelete = await _MeetingRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (MeetingEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Meeting is not found"
                    : "الاجتماع غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<MeetingUser> MeetingUserEntitiesToDelete = await _MeetingUserRepository
                .Where(x => x.MeetingId == Request.Id)
                .ToListAsync();

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
                    await _MeetingRepository.DeleteAsync(MeetingEntityToDelete);
                    await _MeetingUserRepository.DeleteListAsync(MeetingUserEntitiesToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Meeting has been deleted successfully"
                        : "تم حذف الاجتماع بنجاح";

                    Transaction.Complete();

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
