using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationResults.Commands.ChangeArbitrationResultsStatus
{
    public class ChangeArbitrationResultsStatusCommand : IRequest<BaseResponse<object>>
    {
        public List<int> FormsIds { get; set; } = new List<int>();
        public int? DigitalSignatureId { get; set; }
        public string? UserName { get; set; } = null!;
        public string? Password { get; set; } = null!;

        public int? CerticateTemplateId { get; set; }
        public CertificationActionTypes? isCerticate { get; set; }
        public DateTime? DateOfObtainingTheCertificate { get; set; }

        public CertificationActionTypes? isStatment1 { get; set; }
        public int? Statment1TemplateId { get; set; }
        public DateTime? DateOfObtainingTheStatement1 { get; set; }

        public CertificationActionTypes? isStatment2 { get; set; }
        public int? Statment2TemplateId { get; set; }
        public DateTime? DateOfObtainingTheStatement2 { get; set; }

        public bool JustSendEmail { get; set; }

        public string? ImagePath { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
