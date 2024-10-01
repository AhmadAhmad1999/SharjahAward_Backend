using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Helpers.URLValidationAttributeHelper
{
    public class URLValidationAttribute : ValidationAttribute
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public URLValidationAttribute()
        {
            _HttpContextAccessor = new HttpContextAccessor();
        }

        protected override ValidationResult IsValid(object InsertedValue, ValidationContext validationContext)
        {
            HttpContext Context = _HttpContextAccessor.HttpContext;

            if (InsertedValue != null)
            {
                string? URL = InsertedValue.ToString();

                if (!string.IsNullOrEmpty(URL) 
                    ? !URL.ToLower().StartsWith("https://")
                    : false)
                {
                    return new ValidationResult($"The {validationContext.DisplayName} URL must start only with 'https://'.");
                }
            }

            return ValidationResult.Success!;
        }
    }
}
