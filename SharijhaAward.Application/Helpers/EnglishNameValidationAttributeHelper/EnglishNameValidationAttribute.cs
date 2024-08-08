using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper
{
    public class EnglishNameValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string englishName = value.ToString();

                if (!englishName.All(char.IsLetter))
                    return new ValidationResult("English name must only contain English characters.");
            }

            return ValidationResult.Success;
        }
    }

}
