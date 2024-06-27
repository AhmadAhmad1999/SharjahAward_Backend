﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetAllGeneralFAQs
{
    public class GetAllGeneralFAQListVM
    {
        public int Id { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public int GeneralFrequentlyAskedQuestionCategoryId { get; set; }
        public string GeneralFrequentlyAskedQuestionCategoryName { get; set; } = null!;
    }
}
