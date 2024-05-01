namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.ReorderCriterionItemsInsideSubCriterions
{
    public class SubCriterionItemsDto
    {
        public int SubCriterionId { get; set; }
        public List<int> CriterionItemsIds { get; set; } = new List<int>();
    }
}
