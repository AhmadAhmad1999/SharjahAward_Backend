using Microsoft.AspNetCore.Http;

namespace SharijhaAward.Application.Features.Circulars.Command.CreateCircular
{
    public class CircularFilesDto
    {
        public string FileName { get; set; } = null!;
        public IFormFile CircularFile { get; set; } = null!;
    }
}
