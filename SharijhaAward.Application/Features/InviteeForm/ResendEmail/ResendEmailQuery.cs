using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InviteeForm.ResendEmail
{
    public class ResendEmailQuery : IRequest<BaseResponse<object>>
    {
        public int InviteeId { get; set; }
        public string Type { get; set; }=string.Empty;
        public string? lang { get; set; }
        public string? ImagePath { get; set; }
    }
}
