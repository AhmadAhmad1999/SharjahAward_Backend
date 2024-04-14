namespace SharijhaAward.Application.Features.Classes.Queries.GetClassById
{
    public class GetClassByIdDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
    }
}
