namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllCriterionsForCoordinator
{
    public class GetAllCriterionsForCoordinatorCriterionItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; } = null!;
        public List<GetAllCriterionsForCoordinatorAttachment> GetAllCriterionsForCoordinatorAttachment { get; set; } = new List<GetAllCriterionsForCoordinatorAttachment>();
    }
}
