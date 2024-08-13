using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess
{
    public class GetAllFormsForSortingProcessListVM
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string SubscriberName { get; set; } = null!;
        public int ArbitratorId { get; set; }
        public string ArbitratorName { get; set; } = null!;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public FormStatus isAccepted { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
        public string? Reason { get; set; }
        public List<GetAllFormsForSortingProcessListVMCategories> Categories { get; set; } = new List<GetAllFormsForSortingProcessListVMCategories>();
    }
}
