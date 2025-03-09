using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.CategoryConstants;

namespace SharijhaAward.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommand : IRequest<BaseResponse<object>>
    {
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public IFormFile Icon { get; set; } = null!;
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
        public List<CreateCategoryEducationalClassDto>? EducationalClasses { get; set; }
        public int? ParentId { get; set; }
        public int? CycleId { get; set; }
        public bool? RelatedToEducationalEntities { get; set; }
        public string lang {  get; set; } = string.Empty;

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
