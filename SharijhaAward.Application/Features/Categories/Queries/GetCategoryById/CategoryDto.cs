using SharijhaAward.Domain.Constants.CategoryConstants;
using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoryById
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ArabicName {  get; set; } = string.Empty;
        public string EnglishName {  get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public CategoryClassification CategoryClassification { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }
        public DateTime? InitialArbitrationStartDate { get; set; }
        public DateTime? InitialArbitrationEndDate { get; set; }
        public DateTime? FinalArbitrationStartDate { get; set; }
        public DateTime? FinalArbitrationEndDate { get; set; }
        public float? FinalArbitrationQualificationMark { get; set; }
        public float? WinningScore { get; set; }
        public float? MinimumAmountToParticipateInTheAward { get; set; }
        public float? MinimumAmountToObtainACertificateOfParticipation { get; set; }
        public Status Status { get; set; } = Status.InActive;
        public bool RelatedToClasses { get; set; }
        public List<CategoryEducationalClassesDto>? EducationalClasses { get; set; }
        public int ExpectedNumberOfWinners { get; set; }
        public string MainCategoryName { get; set; } = string.Empty;
        public bool isHasFile { get; set; }
    }
}
