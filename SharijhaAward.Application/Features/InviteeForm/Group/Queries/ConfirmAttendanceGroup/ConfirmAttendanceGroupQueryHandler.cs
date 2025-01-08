using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EventModel;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup
{
    public class ConfirmAttendanceGroupQueryHandler
        : IRequestHandler<ConfirmAttendanceGroupQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository;
        public ConfirmAttendanceGroupQueryHandler(IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository)
        {
            this._GroupInviteeVirtualTableRepository = _GroupInviteeVirtualTableRepository;
        }

        public async Task<BaseResponse<object>> Handle(ConfirmAttendanceGroupQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GroupInviteeVirtualTable? GroupInviteeVirtualTableEntity = await _GroupInviteeVirtualTableRepository
                .FirstOrDefaultAsync(x => x.UniqueIntegerId == Request.Id);

            if (GroupInviteeVirtualTableEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This identifier is not valid"
                    : "هذا المعرف غير صالح";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            GroupInviteeVirtualTableEntity.NumberOfActualAttendance = Request.NumberOfActualAttendance;
            GroupInviteeVirtualTableEntity.IsAttend = true;

            await _GroupInviteeVirtualTableRepository.UpdateAsync(GroupInviteeVirtualTableEntity);

            ResponseMessage = Request.lang == "en"
                ? "Confirmed successfully"
                : "تم تأكيد الدعوة الجماعية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
