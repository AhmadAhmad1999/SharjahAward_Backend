using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.StrategicPartners.Commands.CreateStrategicPartner
{
    public class CreateStrategicPartnerCommand : IRequest<BaseResponse<object>>
    {
        public IFormFile Logo { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string? Url { get; set; }
        public string? lang { get; set; }
    }
}
 