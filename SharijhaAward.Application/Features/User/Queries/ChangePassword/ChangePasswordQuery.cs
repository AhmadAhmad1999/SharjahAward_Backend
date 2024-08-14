using MediatR;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.ChangePassword
{
    public class ChangePasswordQuery : IRequest<BaseResponse<object>>
    {
        public string lang { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public int? Id { get; set; }
        public string? OldPassword { get; set; } = string.Empty;
        [PasswordValidation]
        public string NewPassword { get; set; } = string.Empty;
    }
}
