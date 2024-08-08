using MediatR;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.SigningTheForm
{
    public class SigningTheFormQuery : IRequest<BaseResponse<object>>
    {
        public string lang { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        [PasswordValidation(ErrorMessage = "Password must contain at least 1 uppercase letter, 1 lowercase letter, 1 special character, 1 number, and be at least 8 characters long.")]
        public string password { get; set; } = string.Empty;
        public int providedFormId {  get; set; }
    }
}
