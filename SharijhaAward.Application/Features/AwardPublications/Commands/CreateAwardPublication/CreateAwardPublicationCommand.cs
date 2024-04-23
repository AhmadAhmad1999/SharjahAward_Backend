using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Commands.CreateAwardPublication
{
    public class CreateAwardPublicationCommand : IRequest<BaseResponse<int>>
    {
        public IFormFile Image { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string PublicationDescription { get; set; } = string.Empty;
        public IFormFile Publication { get; set; } = null!;
        public string AutherName { get; set; } = string.Empty;
        public string? AutherDescription { get; set; } = string.Empty;
        public int CycleId { get; set; }
        public string? lang { get; set; }
    }
}
