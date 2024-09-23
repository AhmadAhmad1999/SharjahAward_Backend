using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.StrategicPartners.Commands.UpdateStrategicPartner
{
    public class UpdateStrategicPartnerCommand 
        : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public bool UpdateOnLogo {  get; set; }
        public IFormFile? Logo { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Url { get; set; }
        public string? lang { get; set; }
        public int orderId { get; set; }
        public bool IsHide { get; set; } = false;
        public int PageId { get; set; } = 3;
    }
}
