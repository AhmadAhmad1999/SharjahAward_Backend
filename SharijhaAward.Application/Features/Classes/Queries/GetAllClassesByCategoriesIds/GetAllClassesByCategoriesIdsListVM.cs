namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClassesByCategoriesIds
{
    public class GetAllClassesByCategoriesIdsListVM
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
