namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId
{
    public class FormsListVMForArbitrationDto
    {
        public int Id { get; set; }
        public string? SubscriberName { get; set; } = null!;
        public string? EducationalClassName { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool? IsAccepted { get; set; }
        public int PercentCompletion { get; set; }
        public ArbitrationLevelForForm ArbitrationLevelForThisForm { get; set; } = ArbitrationLevelForForm.ArbitrationSorting;
        public List<ArbitratorsForForm> ArbitratorsForThisForm { get; set; } = new List<ArbitratorsForForm>();
    }
}
