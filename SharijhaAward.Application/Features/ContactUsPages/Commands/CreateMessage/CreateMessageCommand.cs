using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage
{
    public class CreateMessageCommand : IRequest<BaseResponse<int>>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? From { get; set; } = string.Empty;
        public string? To { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public int TypeId { get; set; }
        public int? MessageId { get; set; }

        public string? lang { get; set; } = string.Empty;
        public string? token { get; set; } = string.Empty;
        //public List<ContactUsAttachmentDto>? ContactUsAttachments { get; set; }
        public List<IFormFile>? EmailAttachments { get; set; } 
       
    }
}
