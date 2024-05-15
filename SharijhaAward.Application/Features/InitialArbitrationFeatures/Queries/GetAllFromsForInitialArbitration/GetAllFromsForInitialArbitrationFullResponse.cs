namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetAllFromsForInitialArbitration
{
    public class GetAllFromsForInitialArbitrationFullResponse
    {
        public List<GetAllFromsForInitialArbitrationListVM> GetAllFromsForInitialArbitrationListVM { get; set; } = new List<GetAllFromsForInitialArbitrationListVM>();
        public int NumberOfNotBeenArbitratedForms { get; set; }
        public int NumberOfBeingReviewedForms { get; set; }
        public int NumberOfDoneArbitratodForms { get; set; }
    }
}
