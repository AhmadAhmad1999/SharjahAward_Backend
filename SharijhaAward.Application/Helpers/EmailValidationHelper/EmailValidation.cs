using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SharijhaAward.Application.Helpers.EmailValidationHelper
{
    public class EmailValidation : ValidationAttribute
    {
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public EmailValidation()
        {
            _HttpContextAccessor = new HttpContextAccessor();
        }

        protected override ValidationResult IsValid(object? InsertedValue, ValidationContext validationContext)
        {
            HttpContext? context = _HttpContextAccessor.HttpContext;

            if (InsertedValue != null)
            {
                string? Email = InsertedValue.ToString();

                if (!IsValidEmail(Email))
                {
                    return new ValidationResult("Invalid email format. / صيغة البريد الإلكتروني غير صالحة.");
                }
            }

            return ValidationResult.Success!;
        }

        private bool IsValidEmail(string? Email)
        {
            if (string.IsNullOrWhiteSpace(Email))
                return false;

            try
            {
                return Regex.IsMatch(Email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
