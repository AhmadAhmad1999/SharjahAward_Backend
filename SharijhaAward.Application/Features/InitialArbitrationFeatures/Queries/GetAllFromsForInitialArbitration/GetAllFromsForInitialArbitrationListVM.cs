using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetAllFromsForInitialArbitration
{
    public class GetAllFromsForInitialArbitrationListVM
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Name { get; set; } = null!;
        public string? ArbitratorName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public DateTime? DateOfArbitration { get; set; }
        public ArbitrationType ArbitrationType { get; set; }
        public int FullArbitrationScore { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
    }
}
