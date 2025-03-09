namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsThatEligibileForInterview
{
    public class GetAllFormsThatEligibileForInterviewListVM
    {
        public int SubscriberId { get; set; }
        public string Email { get; set; } = null!;
        public string SubscriberName { get; set; } = null!;
    }
}
