namespace SharijhaAward.Application.Features.Cycles.Commands.ImportFromOldCycle
{
    public class MainCriterionImport
    {
        public int Id { get; set; }
        public List<SubCriterionImport> SubCriterionImport { get; set; } = new List<SubCriterionImport>();
    }
}
