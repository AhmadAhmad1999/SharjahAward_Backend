using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class GetInterviewByIdDto
    {
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public string? ArabicText { get; set; }
        public string? EnglishText { get; set; }
        public DateTime? Date { get; set; }
        public MeetingTypes Type { get; set; }
        public string? Address { get; set; }
        public bool isImplemented { get; set; }
        public bool isCanceled { get; set; }
        public string? EnglishReasonOfCanceling { get; set; }
        public string? ArabicReasonOfCanceling { get; set; }
        public List<InterviewUserDto> UsersInfo { get; set; } = new List<InterviewUserDto>();
        public List<GetInterviewNoteDto> GetInterviewNoteDtos { get; set; } = new List<GetInterviewNoteDto>();
        public List<GetInterviewQuestionDto> GetInterviewQuestionDtos { get; set; } = new List<GetInterviewQuestionDto>();
        public List<int> CategoriesIds { get; set; } = new List<int>();
    }
}
