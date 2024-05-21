namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllCriterionsForCoordinator
{
    public class GetAllCriterionsForCoordinatorSubCriterion
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Title { get; set; } = null!;
        public List<GetAllCriterionsForCoordinatorCriterionItem> GetAllCriterionsForCoordinatorCriterionItem { get; set; } = new List<GetAllCriterionsForCoordinatorCriterionItem>();
        public List<GetAllCriterionsForCoordinatorAttachment> GetAllCriterionsForCoordinatorAttachment { get; set; } = new List<GetAllCriterionsForCoordinatorAttachment>();
    }
}
