namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class InterviewInviteeNoteAndQuestionDto
    {
        public int Id { get; set; }

        public string ArabicText { get; set; } = null!;
        public string EnglishText { get; set; } = null!;

        public int InterviewInviteeId { get; set; }
    }
}
