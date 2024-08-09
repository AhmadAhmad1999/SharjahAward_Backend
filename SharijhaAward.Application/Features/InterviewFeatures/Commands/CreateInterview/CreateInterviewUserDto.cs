using SharijhaAward.Application.Helpers.EmailValidationHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateInterview
{
    public class CreateInterviewUserDto
    {
        public string Name { get; set; } = null!;
        [EmailValidation]
        public string Email { get; set; } = null!;
    }
}
