namespace SharijhaAward.Application.Features.Cycles.Commands.ImportFromOldCycle
{
    public class SubCriterionImport
    {
        public int Id { get; set; }
        public List<int> SubCriterionItemsIds{ get; set; } = new List<int>();
    }
}
