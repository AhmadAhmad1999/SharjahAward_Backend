namespace SharijhaAward.Application.Features.Classes.Queries.GetClassById
{
    public class GetClassByIdDto
    {
        public Guid Id { get; set; }
        public string EnglishName { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
    }
}
