namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFormsForFinalArbitration
{
    public class GetAllFormsForFinalArbitrationMainListVM
    {
        public List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM { get; set; } = new List<GetAllFormsForFinalArbitrationListVM>();
        public int CountOfNotBeenArbitrated { get; set; }
        public int CountOfBeingReviewed { get; set; }
        public int CountOfDoneArbitratod { get; set; }
    }
}
