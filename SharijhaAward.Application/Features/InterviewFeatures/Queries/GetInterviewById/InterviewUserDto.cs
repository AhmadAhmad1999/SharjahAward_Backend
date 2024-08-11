using SharijhaAward.Application.Helpers.EmailValidationHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class InterviewUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [EmailValidation]
        public string Email { get; set; } = null!;
    }
}
