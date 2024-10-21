using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.TemplateModel
{
    public class Template : AuditableEntity
    {
        public int Id { get; set; }
        public string BackgroundImageUrl { get; set; } = null!;
        public string TemplateVersion { get; set; } = null!;
        public string FontColor { get; set; } = null!;
        public TemplateTypes TemplateType { get; set; }
        public bool isActive { get; set; }
    }
}
