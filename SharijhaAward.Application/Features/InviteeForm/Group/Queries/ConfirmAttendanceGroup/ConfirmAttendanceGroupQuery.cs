using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup
{
    public class ConfirmAttendanceGroupQuery : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int NumberOfActualAttendance { get; set; }
        public string? lang { get; set; }
    }
}
