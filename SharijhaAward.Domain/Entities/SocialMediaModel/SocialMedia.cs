using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.SocialMediaModel
{
    public class SocialMedia : AuditableEntity
    {
        public int Id { get; set; }
        public string? LogoUrl { get; set; } 
        public string? ThumbnailUrl { get; set; }
        public string Url { get; set; } = string.Empty;
    }
}
