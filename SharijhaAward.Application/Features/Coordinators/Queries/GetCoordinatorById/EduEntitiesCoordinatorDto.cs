namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class EduEntitiesCoordinatorDto
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
    }
}
