using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal
{
    public class ConfirmAttendancePersonalQueryHandler
        : IRequestHandler<ConfirmAttendancePersonalQuery, BaseResponse<object>>
    {
        private readonly IPersonalInviteeRepository _PersonalInviteeRepository;
        private readonly IGroupInviteeRepository _GroupInviteeRepository;
        public ConfirmAttendancePersonalQueryHandler(IPersonalInviteeRepository PersonalInviteeRepository,
            IGroupInviteeRepository GroupInviteeRepository)
        {
            _PersonalInviteeRepository = PersonalInviteeRepository;
            _GroupInviteeRepository = GroupInviteeRepository;
        }

        public async Task<BaseResponse<object>> Handle(ConfirmAttendancePersonalQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            PersonalInvitee? PersonalInviteeEntity = await _PersonalInviteeRepository
                .GetByIdAsync(Request.Id);

            if (PersonalInviteeEntity == null)
            {
                GroupInvitee? CheckIfTheInputIdIsForGroupInvitee = await _GroupInviteeRepository
                    .GetByIdAsync(Request.Id);

                if (CheckIfTheInputIdIsForGroupInvitee == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "This identifier is not valid"
                        : "هذا المعرف غير صالح";

                    return new BaseResponse<object>()
                    {
                        data = null,
                        message = ResponseMessage,
                        pagination = null,
                        statusCode = 400,
                        success = false
                    };
                }
                else
                {
                    ResponseMessage = Request.lang == "en"
                        ? "This identifier is not valid for personal invites, but it's valid for group invites"
                        : "هذا المعرف غير صالح للدعوات الشخصية، ولكنه صالح للدعوات الجماعية";

                    return new BaseResponse<object>()
                    {
                        data = null,
                        message = ResponseMessage,
                        pagination = null,
                        statusCode = 400,
                        success = false
                    };
                }
            }

            await _PersonalInviteeRepository.ConfirmationofAttendance(PersonalInviteeEntity);

            ResponseMessage = Request.lang == "en"
                ? "Confirmed Sucsessfuly"
                : "تم تأكيد الدعوة الفردية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
