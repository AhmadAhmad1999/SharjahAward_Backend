﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Domain.Entities.ArbitrationScaleModel
{
    public class ArbitrationScale : AuditableEntity
    {
        public int Id { get; set; }
        public string DegreeScale { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
