using SharijhaAward.Domain.Constants.CategoryConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.ExportToExcel
{
    public class CategoryExportDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public CategoryClassification CategoryClassification { get; set; }
        public float? FinalArbitrationQualificationMark { get; set; }
        public float? WinningScore { get; set; }
        public float? MinimumAmountToParticipateInTheAward { get; set; }
        public float? MinimumAmountToObtainACertificateOfParticipation { get; set; }
        public bool RelatedToClasses { get; set; }
        public int ExpectedNumberOfWinners { get; set; }
    }
}
