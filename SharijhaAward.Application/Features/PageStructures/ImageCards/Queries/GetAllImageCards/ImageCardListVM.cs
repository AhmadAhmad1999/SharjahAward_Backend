using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards
{
    public class ImageCardListVM 
    {
        public int Id { get; set;} 
        public int orderId { get; set;}
        public bool IsHide { get; set; }
        public List<PageImageDto> CardImages { get; set; } = null!;
    }
}
