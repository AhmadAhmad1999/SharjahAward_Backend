using MediatR;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.UpdateUser
{
    public class UpdateUserCommand2 : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        public List<int> RolesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
