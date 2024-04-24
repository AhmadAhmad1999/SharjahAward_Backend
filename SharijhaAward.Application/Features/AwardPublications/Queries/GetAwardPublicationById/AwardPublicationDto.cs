using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.GetAwardPublicationById
{
    public class AwardPublicationDto
    {
        public int Id {  get; set; }
        public string ImageUrl { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string PublicationDescription { get; set; } = string.Empty;
        public string PublicationUrl { get; set; } = null!;
        public string AutherName { get; set; } = string.Empty;
        public string? AutherDescription { get; set; } = string.Empty;
        public int CycleId { get; set; }
    }
}
