using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs
{
    public class GetAllFAQsQuery : IRequest<BaseResponse<List<FAQListVm>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page {  get; set; }
        public int pageSize { get; set; }
    }
}
