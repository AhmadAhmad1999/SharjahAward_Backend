namespace SharijhaAward.Application.Features.Albums.Galleries.Queries.GetAllGalleries
{
    public class GalleryListVm
    {
        public int Id { get; set; }
        public string FileUrl { get; set; } = string.Empty;
        public int AlbumId { get; set; }
        public string? AlbumTitle { get; set; }
    }
}
