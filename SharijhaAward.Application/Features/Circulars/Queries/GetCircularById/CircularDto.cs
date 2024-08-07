using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetCircularById
{
    public class CircularDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CircularText { get; set; } = string.Empty;
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<CircularAttachmentDto>? CircularAttachments { get; set; }
        public List<int>? Coordinators { get; set; }
        public List<int>? Arbitrators { get; set; }
        public List<int>? Chairmans { get; set; }
    }
}
