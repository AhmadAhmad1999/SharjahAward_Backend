using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess
{
    public class GetAllFormsForSortingProcessFilter
    {
        public bool? AsChairman { get; set; }
        public bool AsFullAccess { get; set; } = false;
        public string? ArbitratorName { get; set; }
        public string? SubscriberName { get; set; }
        public FormStatus? isAccepted { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public DateTime? ArbitrationStartDate { get; set; }
        public DateTime? ArbitrationEndDate { get; set; }
    }
}
