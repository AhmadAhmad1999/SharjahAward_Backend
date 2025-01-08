using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.SelectDigitalSignature
{
    public class SelectDigitalSignatureQuery : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? TemplateId { get; set; }
        public List<int> SubscribersIds { get; set; } = new List<int>();
        public TemplateTypes TemplateType { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
