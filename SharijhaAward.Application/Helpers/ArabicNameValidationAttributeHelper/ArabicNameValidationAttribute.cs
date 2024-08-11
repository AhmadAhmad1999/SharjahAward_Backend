using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper
{
    public class ArabicNameValidationAttribute : ValidationAttribute
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public ArabicNameValidationAttribute()
        {
            _HttpContextAccessor = new HttpContextAccessor();
        }

        protected override ValidationResult IsValid(object InsertedValue, ValidationContext validationContext)
        {
            HttpContext Context = _HttpContextAccessor.HttpContext;

            if (InsertedValue != null)
            {
                string? ArabicName = InsertedValue.ToString();

                if (ArabicName.All(c => c < 0x600 || c > 0x6FF))
                {
                    throw new ValidationException("Arabic name must only contain Arabic characters. / الاسم العربي يجب أن يحتوي على الأحرف العربية فقط.");
                }
            }

            return ValidationResult.Success!;
        }
    }

}
