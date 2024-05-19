using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllInterviewsForInterviewStep
{
    public class GetAllInterviewsForInterviewStepListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Date { get; set; }
        public MeetingTypes Type { get; set; }
        public bool isImplemented { get; set; }
        public bool isCanceled { get; set; }
    }
}
