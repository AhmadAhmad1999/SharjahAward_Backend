using MediatR;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.SearchForFAQs
{
    public class SearchForFAQsQuery : IRequest<BaseResponse<List<FAQListVm>>>
    {
        public string? SrearchQuery { get; set; }
        public string? lang { get; set; }
    }
}
