namespace SharijhaAward.Application.Features.Cycles.Commands.ImportFromOldCycle
{
    public class MainCategoryImport
    {
        public int Id { get; set; }
        public bool TakeThisLevel { get; set; }
        public int? NewMainCategoryId { get; set; }
        public List<SubCategoryImport> SubCategoryImport { get; set; } = new List<SubCategoryImport>();
    }
}
