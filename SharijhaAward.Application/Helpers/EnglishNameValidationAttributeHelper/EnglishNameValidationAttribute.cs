using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper
{
    public class EnglishNameValidationAttribute : ValidationAttribute
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public EnglishNameValidationAttribute()
        {
            _HttpContextAccessor = new HttpContextAccessor();
        }

        protected override ValidationResult IsValid(object InsertedValue, ValidationContext validationContext)
        {
            HttpContext Context = _HttpContextAccessor.HttpContext;

            if (InsertedValue != null)
            {
                string? EnglishName = InsertedValue.ToString();

                if (!Regex.IsMatch(EnglishName!, "^[a-zA-Z]*$"))
                {
                    throw new ValidationException("English name must only contain english characters. / يجب أن يحتوي الاسم الإنجليزي على أحرف إنجليزية فقط.");
                }
            }

            return ValidationResult.Success!;
        }
    }

}
