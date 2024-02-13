using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs
{
    public class GetAllFAQsQuery : IRequest<List<FAQListVm>>
    {
        public string lang { get; set; } = string.Empty;
    }
}
