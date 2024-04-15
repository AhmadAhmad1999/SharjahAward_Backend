namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategoriesWithCycleNumber
{
    public class GetAllCategoriesWithCycleNumberListVM
    {
        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}
