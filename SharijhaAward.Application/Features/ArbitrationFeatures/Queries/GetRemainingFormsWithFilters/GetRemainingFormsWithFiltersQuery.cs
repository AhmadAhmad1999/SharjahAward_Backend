using MediatR;
using SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetRemainingFormsWithFilters
{
    public class GetRemainingFormsWithFiltersQuery : IRequest<BaseResponse<List<FormsListVMForArbitrationDto>>>
    {
        public int ArbitratorId { get; set; }
        public string? SubscriberName { get; set; }
        //public string? ArbitrationLanguage { get; set; }
        public List<int> ClassesIds { get; set; } = new List<int>();
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public int? FormId { get; set; }
        public string? lang { get; set; }
    }
}
