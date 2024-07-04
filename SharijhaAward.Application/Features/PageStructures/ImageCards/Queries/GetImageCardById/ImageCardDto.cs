using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetImageCardById
{
    public class ImageCardDto
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public int pageId {  get; set; }
        public List<PageImageDto> CardImages { get; set; } = null!;
    }
}
