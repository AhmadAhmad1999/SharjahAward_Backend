using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup
{
    public class ConfirmAttendanceGroupQueryHandler
        : IRequestHandler<ConfirmAttendanceGroupQuery, BaseResponse<object>>
    {
        private readonly IGroupInviteeRepository _GroupInviteeRepository;
        private readonly IPersonalInviteeRepository _PersonalInviteeRepository;
        public ConfirmAttendanceGroupQueryHandler(IGroupInviteeRepository GroupInviteeRepository,
            IPersonalInviteeRepository PersonalInviteeRepository)
        {
            _GroupInviteeRepository = GroupInviteeRepository;
            _PersonalInviteeRepository = PersonalInviteeRepository;
        }

        public async Task<BaseResponse<object>> Handle(ConfirmAttendanceGroupQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GroupInvitee? GroupInviteeEntity = await _GroupInviteeRepository
                .GetByIdAsync(Request.Id);

            if (GroupInviteeEntity == null)
            {
                PersonalInvitee? PersonalInviteeEntity = await _PersonalInviteeRepository
                    .GetByIdAsync(Request.Id);

                if (PersonalInviteeEntity == null)
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
                        ? "This identifier is not valid for group invites, but it's valid for personal invites"
                        : "هذا المعرف غير صالح للدعوات الجماعية، ولكنه صالح للدعوات الشخصية";

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

            await _GroupInviteeRepository.ConfirmationofAttendance(GroupInviteeEntity, Request.NumberOfAttendees);

            ResponseMessage = Request.lang == "en"
                ? "Confirmed Sucsessfuly"
                : "تم تأكيد الدعوة الجماعية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
