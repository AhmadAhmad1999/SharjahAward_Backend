using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.CreateChairmanNotesOnArbitrationAudit
{
    public class CreateChairmanNotesOnArbitrationAuditCommand : IRequest<BaseResponse<object>>
    {
        public int ArbitrationAuditId { get; set; }
        public string Note { get; set; } = null!;
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
