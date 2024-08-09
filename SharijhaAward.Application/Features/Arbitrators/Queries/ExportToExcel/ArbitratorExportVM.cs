using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.ExportToExcel
{
    public class ArbitratorExportVM
    {
        public int Id { get; set; }
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = null!;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = null!;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;
        public bool isChairman { get; set; } = false;
    }
}
