using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess
{
    public class GetAllFormsForSortingProcessFilter
    {
        public string? ArbitratorName { get; set; }
        public string? SubscriberName { get; set; }
        public FormStatus? isAccepted { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
    }
}
