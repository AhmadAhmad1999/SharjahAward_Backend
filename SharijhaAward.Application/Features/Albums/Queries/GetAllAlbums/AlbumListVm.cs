namespace SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums
{
    public class AlbumListVm 
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = null!;
    }
}
