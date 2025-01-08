using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EventModel;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal
{
    public class ConfirmAttendancePersonalQueryHandler
        : IRequestHandler<ConfirmAttendancePersonalQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository;
        public ConfirmAttendancePersonalQueryHandler(IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository)
        {
            this._PersonalInviteeVirtualTableRepository = _PersonalInviteeVirtualTableRepository;
        }

        public async Task<BaseResponse<object>> Handle(ConfirmAttendancePersonalQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            PersonalInviteeVirtualTable? PersonalInviteeVirtualTableEntity = await _PersonalInviteeVirtualTableRepository
                .FirstOrDefaultAsync(x => x.UniqueIntegerId == Request.Id);

            if (PersonalInviteeVirtualTableEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This identifier is not valid"
                    : "هذا المعرف غير صالح";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            PersonalInviteeVirtualTableEntity.IsAttend = true;

            await _PersonalInviteeVirtualTableRepository.UpdateAsync(PersonalInviteeVirtualTableEntity);

            ResponseMessage = Request.lang == "en"
                ? "Confirmed successfully"
                : "تم تأكيد الدعوة الفردية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
