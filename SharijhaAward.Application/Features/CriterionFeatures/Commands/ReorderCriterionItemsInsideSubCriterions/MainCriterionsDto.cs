namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.ReorderCriterionItemsInsideSubCriterions
{
    public class MainCriterionsDto
    {
        public int MainCriterionId { get; set; }
        public int OrderId { get; set; }
        public List<SubCriterionDto> SubCriterionDtos { get; set; } = new List<SubCriterionDto>();
    }
}
