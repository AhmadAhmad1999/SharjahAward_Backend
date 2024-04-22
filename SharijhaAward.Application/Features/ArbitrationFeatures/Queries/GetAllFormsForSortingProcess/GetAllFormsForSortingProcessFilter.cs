namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess
{
    public class GetAllFormsForSortingProcessFilter
    {
        public string? ArbitratorName { get; set; }
        public bool? isAccepted { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
    }
}
