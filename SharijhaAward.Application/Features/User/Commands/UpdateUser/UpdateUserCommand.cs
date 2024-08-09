using MediatR;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<BaseResponse<object>>
    {
        public string lang { get; set; } = string.Empty;
        public int? Id { get; set; }
        public Gender Gender { get; set; }
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
    }
}
