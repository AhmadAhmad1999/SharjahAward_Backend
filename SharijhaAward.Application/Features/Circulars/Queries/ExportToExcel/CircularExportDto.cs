using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Queries.ExportToExcel
{
    public class CircularExportDto
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string? EnglishFileUrl { get; set; } = string.Empty;
        public string? ArabicFileUrl { get; set; } = string.Empty;
    }
}
