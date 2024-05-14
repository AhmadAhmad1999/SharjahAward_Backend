using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Commands.UpdateAwardPublication
{
    public class UpdateAwardPublicationCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public bool updateOnImage { get; set; }
        public IFormFile Image { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string PublicationDescription { get; set; } = string.Empty;
        public bool updateOnPublication { get; set; }
        public IFormFile Publication { get; set; } = null!;
        public string AutherName { get; set; } = string.Empty;
        public string? AutherDescription { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
