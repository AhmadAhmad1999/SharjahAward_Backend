using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper
{
    public class ArabicNameValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string arabicName = value.ToString();
                foreach (char c in arabicName)
                {
                    if (c < 0x600 || c > 0x6FF)
                    {
                        return new ValidationResult("Arabic name must only contain Arabic characters.");
                    }
                }
            }

            return ValidationResult.Success;
        }
    }

}
