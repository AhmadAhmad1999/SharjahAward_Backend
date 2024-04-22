namespace SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetAllInstructions
{
    public class GetAllInstructionsListVM
    {
        public int Id { get; set; }
        public string Slug { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Content {  get; set; } = null!;
    }
}
