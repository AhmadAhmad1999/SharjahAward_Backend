using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId
{
    public class GetArbitratrionDataByArbitratorIdQuery : IRequest<BaseResponse<GetArbitratrionDataByArbitratorIdDto>>
    {
        public int Id { get; set; }
        public bool GetRemainigForms { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
        public string token { get; set; } = string.Empty;
        public string? lang { get; set; }
        public int? ProvidedFormId { get; set; }
        public int? CategoryId { get; set; }
        public string? SubscriberName { get; set; }
        public bool? isAccepted { get; set; }
        public string? ProvidedFormLanguage { get; set; }
    }
}
