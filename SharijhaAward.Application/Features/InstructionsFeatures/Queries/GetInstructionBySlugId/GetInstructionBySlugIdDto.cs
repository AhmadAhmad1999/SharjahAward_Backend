using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetInstructionBySlugId
{
    public class GetInstructionBySlugIdDto
    {
        public int Id { get; set; }
        public string Slug { get; set; } = null!;
        public string Title { get; set; } = null!;
        [MaxLength]
        public string Content { get; set; } = null!;
    }
}
