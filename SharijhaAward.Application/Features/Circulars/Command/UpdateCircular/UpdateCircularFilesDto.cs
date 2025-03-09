using Microsoft.AspNetCore.Http;

namespace SharijhaAward.Application.Features.Circulars.Command.UpdateCircular
{
    public class UpdateCircularFilesDto
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public IFormFile? CircularFile { get; set; } = null!;
        public bool UpdateOnFile { get; set; }
    }
}
