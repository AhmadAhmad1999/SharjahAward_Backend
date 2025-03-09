using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.CategoryConstants;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Domain.Entities.CategoryModel
{
    public class Category : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public CategoryClassification? CategoryClassification { get; set; }
        public float? FinalArbitrationQualificationMark { get; set; }
        public int? ExpectedNumberOfWinners { get; set; }

        public int? MinimumAmountToObtainAStatement2 { get; set; }
        public int? MaximumAmountToObtainAStatement2 { get; set; }
        public int? MinimumRequirementToObtainACertificate { get; set; }
        public int? MaximumRequirementToObtainACertificate { get; set; }
        public int? MinimumWinningScore { get; set; }
        public int MinimumEligibilityForInterview { get; set; }

        public bool ContainStatment1 { get; set; }

        public bool? RelatedToClasses { get; set; }
        public bool RelatedToEducationalEntities { get; set; }
        public Category? Parent { get; set; }
        [ForeignKey(nameof(Parent))]
        public int? ParentId { get; set; }

        public Cycle Cycle { get; set; } = null!;
        [ForeignKey(nameof(Cycle))]
        public int CycleId { get; set; }
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