using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal
{
    public class ConfirmAttendancePersonalQuery : IRequest<BaseResponse<object>>
    {
        public int Id {  get; set; }
        public string? lang { get; set; }
    }
}
