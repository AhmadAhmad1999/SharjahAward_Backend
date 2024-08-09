using SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoryById;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.CommitteeConstants;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetCommitteeById
{
    public class GetCommitteeByIdDto
    {
        public int Id { get; set; }
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = null!;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = null!;
        public CommitteeStatus Status { get; set; } = CommitteeStatus.InActive;
        public int ChairmanId { get; set; }
        public string ChairmanName { get; set; } = null!;
        public List<ArbitratorDto> Arbitrators { get; set; } = new List<ArbitratorDto>();
        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    }
}
