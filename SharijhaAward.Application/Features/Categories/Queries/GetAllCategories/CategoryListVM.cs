﻿using SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
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
        [ArabicNameValidation]
        public string ArabicName {  get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName {  get; set; } = string.Empty;
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
        public string? ExplanatoryGuideUrl { get; set; }
        public List<SubcategoriesListVM> subcategories { get; set; } = null!;

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
