using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper
{
    public class PhoneNumberValidationAttribute : ValidationAttribute
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public PhoneNumberValidationAttribute()
        {
            _HttpContextAccessor = new HttpContextAccessor();
        }
        protected override ValidationResult IsValid(object InsertedValue, ValidationContext validationContext)
        {
            HttpContext Context = _HttpContextAccessor.HttpContext;

            if (InsertedValue != null)
            {
                string? PhoneNumber = InsertedValue.ToString();

                if (!string.IsNullOrEmpty(PhoneNumber)
                    ? (!PhoneNumber.StartsWith("0097105") || PhoneNumber.Length != 15)
                    : false)
                {
                    throw new ValidationException("Phone number must start with '0097105' and have 8 digits after. / يجب أن يبدأ رقم الهاتف بـ \"0097105\" وأن يتكون من 8 أرقام بعده.");
                }
            }

            return ValidationResult.Success!;
        }
    }
}