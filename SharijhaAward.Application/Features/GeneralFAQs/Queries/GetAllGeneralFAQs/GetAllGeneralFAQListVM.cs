﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetAllGeneralFAQs
{
    public class GetAllGeneralFAQListVM
    {
        public Guid Id { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
    }
}
