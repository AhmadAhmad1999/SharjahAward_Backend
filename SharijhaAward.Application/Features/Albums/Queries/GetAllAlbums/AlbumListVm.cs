using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums
{
    public class AlbumListVm 
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = null!;
        public int CycleId { get; set; }
    }
}
