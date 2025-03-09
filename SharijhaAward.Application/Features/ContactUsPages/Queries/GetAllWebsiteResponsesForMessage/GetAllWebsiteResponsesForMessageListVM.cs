namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllWebsiteResponsesForMessage
{
    public class GetAllWebsiteResponsesForMessageListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;

        public int UserId { get; set; }
        public string? UserName { get; set; }

        public List<string> Attachments { get; set; } = new List<string>();
    }
}
