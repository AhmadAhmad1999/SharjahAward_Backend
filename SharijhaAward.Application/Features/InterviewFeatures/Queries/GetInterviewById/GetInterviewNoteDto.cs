namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class GetInterviewNoteDto
    {
        public int Id { get; set; }
        public string ArabicNote { get; set; } = null!;
        public string EnglishNote { get; set; } = null!;
    }
}
