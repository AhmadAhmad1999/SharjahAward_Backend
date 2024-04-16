namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClassesByCategoriesIds
{
    public class GetAllClassesByCategoriesIdsRequest
    {
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
