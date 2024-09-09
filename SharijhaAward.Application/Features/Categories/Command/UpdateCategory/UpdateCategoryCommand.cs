using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Features.Categories.Command.CreateCategory;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.CategoryConstants;
using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Command.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool UpdateOnIcon { get; set; } = false;
        public IFormFile? Icon { get; set; } = null!;
        public CategoryClassification CategoryClassification { get; set; }
        public float? FinalArbitrationQualificationMark { get; set; }

        public int? MinimumAmountToObtainAStatement { get; set; }
        public int? MaximumAmountToObtainAStatement { get; set; }
        public int? MinimumRequirementToObtainACertificate { get; set; }
        public int? MaximumRequirementToObtainACertificate { get; set; }
        public int? MinimumWinningScore { get; set; }

        public bool? RelatedToClasses { get; set; }
        public int? ExpectedNumberOfWinners { get; set; }
        public List<CreateCategoryEducationalClassDto>? EducationalClasses { get; set; }
        public bool? RelatedToEducationalEntities { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
