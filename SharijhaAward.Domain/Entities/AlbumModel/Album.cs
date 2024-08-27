using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.AlbumModel
{
    public class Album : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;

        //public virtual List<Gallery> Galleries { get; set; } = null!;

    }
}
