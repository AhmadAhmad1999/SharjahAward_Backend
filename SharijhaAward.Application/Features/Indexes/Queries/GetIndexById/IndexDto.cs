using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Indexes.Queries.GetIndexById
{
    public class IndexDto
    {
        public int Id { get; set; }
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = string.Empty;
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = string.Empty;
        public string? Slug { get; set; } = string.Empty;
    }
}
