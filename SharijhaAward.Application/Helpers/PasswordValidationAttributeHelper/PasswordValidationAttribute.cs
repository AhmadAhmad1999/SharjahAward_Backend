using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper
{
    public class PasswordValidationAttribute : ValidationAttribute
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public PasswordValidationAttribute()
        {
            _HttpContextAccessor = new HttpContextAccessor();
        }

        protected override ValidationResult IsValid(object InsertedValue, ValidationContext validationContext)
        {
            HttpContext Context = _HttpContextAccessor.HttpContext;

            if (InsertedValue != null)
            {
                string? Password = InsertedValue.ToString();

                if (!Regex.IsMatch(Password!, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9])"))
                {
                    throw new ValidationException("Password must contains at least 1 uppercase, 1 lower case, 1 number and 1 special character. / يجب أن تحتوي كلمة المرور على حرف كبير واحد على الأقل، وحرف صغير واحد، ورقم واحد، وحرف خاص واحد.");
                }
            }

            return ValidationResult.Success!;
        }
    }

}
