using SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories;
using SharijhaAward.Domain.Constants.CategoryConstants;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategories
{
    public class CategoryListVM
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
        public float? FinalArbitrationQualificationMark { get; set; }

        public int? MinimumAmountToObtainAStatement { get; set; }
        public int? MaximumAmountToObtainAStatement { get; set; }
        public int? MinimumRequirementToObtainACertificate { get; set; }
        public int? MaximumRequirementToObtainACertificate { get; set; }
        public int? MinimumWinningScore { get; set; }

        public bool RelatedToClasses { get; set; }
        public int ExpectedNumberOfWinners { get; set; }
        public string? ExplanatoryGuideUrl { get; set; }
        public List<SubcategoriesListVM> subcategories { get; set; } = null!;

    }
}
