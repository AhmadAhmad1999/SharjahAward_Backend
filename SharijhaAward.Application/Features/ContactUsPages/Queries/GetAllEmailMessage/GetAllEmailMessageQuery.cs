using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage
{
    public class GetAllEmailMessageQuery : IRequest<BaseResponse<List<EmailMessageListVM>>>
    {
        public string token { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
        public int page {  get; set; }
        public int pageSize { get; set; }
        public string? query { get; set; } = string.Empty;
        public int? filter { get; set; } //0 for all - 1 for inComing - 2 for OutComing
    }
}
