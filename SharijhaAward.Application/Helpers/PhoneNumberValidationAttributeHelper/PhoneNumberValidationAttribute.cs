using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper
{
    public class PhoneNumberValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is not null)
            {
                string phoneNumber = value.ToString();

                if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber.StartsWith("0097105") && phoneNumber.Length == 15)
                    return ValidationResult.Success;

                return new ValidationResult("Phone number must start with '0097105' and have 8 digits after.");
            }
            return ValidationResult.Success;
        }
    }
}