using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.AwardSponsorModel
{
    public class AwardSponsor : AuditableEntity
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string UpbringingAndAiography { get; set; } = string.Empty;
        public string Image2 { get; set; } = string.Empty;
        public string HonoraryPositions { get; set; } = string.Empty;
        public string Image3 { get; set; } = string.Empty;
        public string EducationalStages { get; set; } = string.Empty;
        public string Writings { get; set; } = string.Empty;
        

    }
}
