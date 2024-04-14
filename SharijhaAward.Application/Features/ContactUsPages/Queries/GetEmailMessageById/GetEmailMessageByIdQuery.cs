using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById
{
    public class GetEmailMessageByIdQuery : IRequest<BaseResponse<EmailMessageDto>>
    {
        public int Id { get; set; }
        public string token { get; set; } = string.Empty;
    }
}
