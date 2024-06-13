using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.GetNewsById
{
    public class NewsImagesDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int NewsId { get; set; }
    }
}
