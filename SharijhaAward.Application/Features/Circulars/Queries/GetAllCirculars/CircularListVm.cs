using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars
{
    public class CircularListVm
    {
        public int Id { get; set; }
        public string arabicTitle { get; set; } = string.Empty;
        public string englishTitle { get; set; } = string.Empty;
        public IFormFile? arabicFile { get; set; }
        public IFormFile? englishFile { get; set; }
    }
}
