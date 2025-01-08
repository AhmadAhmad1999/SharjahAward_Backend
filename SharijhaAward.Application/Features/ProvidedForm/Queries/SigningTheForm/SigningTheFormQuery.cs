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
        [PasswordValidation]
        public string password { get; set; } = string.Empty;
        public int providedFormId {  get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
