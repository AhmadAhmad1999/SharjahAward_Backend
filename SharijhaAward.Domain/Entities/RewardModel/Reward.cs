﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.RewardModel
{
    public class Reward : AuditableEntity
    {
        public int Id {  get; set; }
        public int RewardValue { get; set; }
        public string ArabicRank { get; set; } = string.Empty;
        public string EnglishRank { get; set; } = string.Empty;
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId {  get; set; }
    }
}
