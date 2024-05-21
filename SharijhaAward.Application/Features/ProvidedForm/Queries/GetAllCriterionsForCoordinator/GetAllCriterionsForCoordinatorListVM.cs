namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllCriterionsForCoordinator
{
    public class GetAllCriterionsForCoordinatorListVM
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Title { get; set; } = null!;
        public List<GetAllCriterionsForCoordinatorSubCriterion> GetAllCriterionsForCoordinatorSubCriterion { get; set; } 
            = new List<GetAllCriterionsForCoordinatorSubCriterion>();
    }
}
