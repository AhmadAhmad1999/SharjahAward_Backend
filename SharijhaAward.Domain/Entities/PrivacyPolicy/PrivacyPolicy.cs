using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.PrivacyPolicy
{
    public class PrivacyPolicy : AuditableEntity
    {
        public int Id { get; set; }
        [MaxLength]
        public string? ArabicText { get; set; }
        [MaxLength]
        public string? EnglishText { get; set; }
    }
}
