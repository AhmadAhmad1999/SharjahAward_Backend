namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.ReorderCriterionItemsInsideSubCriterions
{
    public class SubCriterionDto
    {
        public int SubCriterionId { get; set; }
        public int OrderId { get; set; }
        public List<CriterionItemDto> CriterionItemDtos { get; set; } = new List<CriterionItemDto>();
    }
}
