namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class EduEntitiesCoordinatorDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
