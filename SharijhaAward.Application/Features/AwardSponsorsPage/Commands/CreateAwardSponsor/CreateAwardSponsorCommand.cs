using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Commands.CreateAwardSponsor
{
    public class CreateAwardSponsorCommand : IRequest<BaseResponse<object>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile Image { get; set; } = null!;
        public string UpbringingAndAiography { get; set; } = string.Empty;
        public IFormFile Image2 { get; set; } = null!;
        public string HonoraryPositions { get; set; } = string.Empty;
        public IFormFile Image3 { get; set; } = null!;
        public string EducationalStages { get; set; } = string.Empty;
        public string Writings { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
