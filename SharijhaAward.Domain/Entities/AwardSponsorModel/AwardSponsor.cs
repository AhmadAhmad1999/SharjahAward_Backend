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
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string EnglishUpbringingAndAiography { get; set; } = string.Empty;
        public string ArabicUpbringingAndAiography { get; set; } = string.Empty;
        public string Image2 { get; set; } = string.Empty;
        public string EnglishHonoraryPositions { get; set; } = string.Empty;
        public string ArabicHonoraryPositions { get; set; } = string.Empty;
        public string Image3 { get; set; } = string.Empty;
        public string EnglishEducationalStages { get; set; } = string.Empty;
        public string ArabicEducationalStages { get; set; } = string.Empty;
        public string EnglishWritings { get; set; } = string.Empty;
        public string ArabicWritings { get; set; } = string.Empty;

    }
}
