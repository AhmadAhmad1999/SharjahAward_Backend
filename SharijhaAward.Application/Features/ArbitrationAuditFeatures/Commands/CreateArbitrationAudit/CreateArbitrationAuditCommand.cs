using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.CreateArbitrationAudit
{
    public class CreateArbitrationAuditCommand : IRequest<BaseResponse<object>>
    {
        public List<ArbitrationAuditMainCommand> ArbitrationAuditMainCommand { get; set; } = new List<ArbitrationAuditMainCommand>();
        public string? lang { get; set; }
        public bool isDoneArbitration { get; set; }
        public int FormId { get; set; }
        public string? Token { get; set; }
    }
}
