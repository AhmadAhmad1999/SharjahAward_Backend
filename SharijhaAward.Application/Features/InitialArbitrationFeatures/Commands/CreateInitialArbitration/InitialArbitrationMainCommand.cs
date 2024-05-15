namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateInitialArbitration
{
    public class InitialArbitrationMainCommand
    {
        public int InitialArbitrationId { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
    }
}
