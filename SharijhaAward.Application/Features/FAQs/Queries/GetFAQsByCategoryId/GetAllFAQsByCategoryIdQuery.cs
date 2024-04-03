﻿using MediatR;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetFAQsByCategoryId
{
    public class GetAllFAQsByCategoryIdQuery : IRequest<BaseResponse<List<FAQListVm>>>
    {
        public Guid CategoryId { get; set; }
        public int page {  get; set; }
        public int pageSize { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
