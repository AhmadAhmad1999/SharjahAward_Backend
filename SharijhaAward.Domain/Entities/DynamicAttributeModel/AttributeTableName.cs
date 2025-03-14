﻿using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    // الفئات الفرعية
    public class AttributeTableName : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
