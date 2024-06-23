using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.AwardPublicationsModel
{
    public class AwardPublication : AuditableEntity
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string PublicationDescription { get; set; } = string.Empty;
        public string PublicationUrl { get; set; } = string.Empty;
        public string AutherName { get; set; } = string.Empty;
        public string AutherDescription { get; set; } = string.Empty;

    }
}
