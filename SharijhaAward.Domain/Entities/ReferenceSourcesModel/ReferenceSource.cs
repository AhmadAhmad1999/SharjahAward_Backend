﻿using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ReferenceSourcesModel
{
    public class ReferenceSource : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Sources { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
