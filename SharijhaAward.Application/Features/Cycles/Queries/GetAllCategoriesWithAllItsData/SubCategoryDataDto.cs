namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCategoriesWithAllItsData
{
    public class SubCategoryDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<InsertedDataDto> TermAndConditionsIds { get; set; } = new List<InsertedDataDto>();
        public InsertedDataDto? TakeTheExplanatoryGuide { get; set; }
        public List<InsertedDataDto> TrainingWorkshopsIds { get; set; } = new List<InsertedDataDto>();
        public List<InsertedDataDto> FrequentlyAskedQuestionsIds { get; set; } = new List<InsertedDataDto>();
        public List<InsertedDataDto> RewardsIds { get; set; } = new List<InsertedDataDto>();
        public List<MainCriterionDataDto> MainCriterionImport { get; set; } = new List<MainCriterionDataDto>();
    }
}
