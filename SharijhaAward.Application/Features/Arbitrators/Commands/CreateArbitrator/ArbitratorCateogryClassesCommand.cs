namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator
{
    public class ArbitratorCateogryClassesCommand
    {
        public int Id { get; set; }
        public List<int> Classes { get; set; } = new List<int>();
    }
}
