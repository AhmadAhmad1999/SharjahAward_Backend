using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetFAQById
{
    public class GetFAQByIdQuery : IRequest<BaseResponse<FAQDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; }=string.Empty;
    }
}
