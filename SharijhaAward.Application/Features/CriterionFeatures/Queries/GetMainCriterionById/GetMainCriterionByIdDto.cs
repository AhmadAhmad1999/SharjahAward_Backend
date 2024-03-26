using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetMainCriterionById
{
    public class GetMainCriterionByIdDto
    {
        public Guid Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<SubCriterionListDto> SubCriterions { get; set; } = new List<SubCriterionListDto>();
    }
}
