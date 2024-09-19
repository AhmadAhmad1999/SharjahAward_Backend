namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator
{
    public class ArbitratorCateogryClassesCommand
    {
        public int Id { get; set; }
        public List<int> ClassesId { get; set; } = new List<int>();
    }
}
