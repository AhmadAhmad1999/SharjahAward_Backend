using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.CategoryConstants;

namespace SharijhaAward.Application.Features.Categories.Queries.ExportToExcel
{
    public class CategoryExportDto
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public CategoryClassification CategoryClassification { get; set; }
        public float? FinalArbitrationQualificationMark { get; set; }

        public int? MinimumAmountToObtainAStatement2 { get; set; }
        public int? MaximumAmountToObtainAStatement2 { get; set; }
        public int? MinimumRequirementToObtainACertificate { get; set; }
        public int? MaximumRequirementToObtainACertificate { get; set; }
        public int? MinimumWinningScore { get; set; }

        public bool ContainStatment1 { get; set; }

        public bool RelatedToClasses { get; set; }
        public int ExpectedNumberOfWinners { get; set; }

        public DateTime? SortingFormsStartDate { get; set; }
        public DateTime? SortingFormsEndDate { get; set; }
        public DateTime? InitialArbitrationStartDate { get; set; }
        public DateTime? InitialArbitrationEndDate { get; set; }
        public DateTime? ArbitrationAuditStartDate { get; set; }
        public DateTime? ArbitrationAuditEndDate { get; set; }
        public DateTime? FinalArbitrationStartDate { get; set; }
        public DateTime? FinalArbitrationEndDate { get; set; }
        public int MarginOfDifferenceBetweenArbitrators { get; set; }
    }
}
