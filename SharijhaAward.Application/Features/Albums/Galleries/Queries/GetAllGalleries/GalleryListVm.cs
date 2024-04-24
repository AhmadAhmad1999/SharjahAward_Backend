using SharijhaAward.Domain.Entities.AlbumModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Galleries.Queries.GetAllGalleries
{
    public class GalleryListVm
    {
        public int Id { get; set; }
        public string FileUrl { get; set; } = string.Empty;
        public int AlbumId { get; set; }
    }
}
