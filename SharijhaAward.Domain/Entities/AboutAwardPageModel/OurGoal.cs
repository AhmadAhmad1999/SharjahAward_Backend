﻿using SharijhaAward.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.AboutAwardPageModel
{
    public class OurGoal : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicGoal { get; set; } = string.Empty;
        public string EnglishGoal { get; set; } = string.Empty;
        public bool IsHidden { get; set; }

        public AboutAwardPage AboutAwardPage { get; set; } = null!;
        [ForeignKey(nameof(AboutAwardPage))]
        public int AboutAwardPageId { get; set; }
    }
}
