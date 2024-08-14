using AutoMapper;
using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateInterview
{
    public class CreateInterviewCommand : IRequest<BaseResponse<object>>
    {
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public string? ArabicText { get; set; }
        public string? EnglishText { get; set; }
        public DateTime Date { get; set; }
        public MeetingTypes Type { get; set; }
        public string? Address { get; set; }
        public List<CreateInterviewUserDto> UsersInfo { get; set; } = new List<CreateInterviewUserDto>();
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public List<InterviewNoteDto> InterviewNoteDtos { get; set; } = new List<InterviewNoteDto>();
        public List<InterviewQuestionDto> InterviewQuestionDtos { get; set; } = new List<InterviewQuestionDto>();
        public string? lang { get; set; }
    }
}

