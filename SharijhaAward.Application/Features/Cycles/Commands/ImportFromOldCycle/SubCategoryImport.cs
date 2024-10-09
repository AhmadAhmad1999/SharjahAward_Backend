namespace SharijhaAward.Application.Features.Cycles.Commands.ImportFromOldCycle
{
    public class SubCategoryImport
    {
        public int Id { get; set; }
        public bool TakeThisLevel { get; set; }
        public int? NewSubCategoryId { get; set; }
        public List<int> TermAndConditionsIds { get; set; } = new List<int>();
        public bool TakeTheExplanatoryGuide { get; set; }
        public List<int> TrainingWorkshopsIds { get; set; } = new List<int>();
        public List<int> FrequentlyAskedQuestionsIds { get; set; } = new List<int>();
        public List<int> RewardsIds { get; set; } = new List<int>();
        public List<MainCriterionImport> MainCriterionImport { get; set; } = new List<MainCriterionImport>();
    }
}
