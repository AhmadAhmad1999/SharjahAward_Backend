using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Commands.UpdateAwardSponsor
{
    public class UpdateAwardSponsorCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool UpdateOnImage1 { get; set; }
        public IFormFile Image { get; set; } = null!;
        public string UpbringingAndAiography { get; set; } = string.Empty;
        public bool UpdateOnImage2 { get; set; }
        public IFormFile Image2 { get; set; } = null!;
        public string HonoraryPositions { get; set; } = string.Empty;
        public bool UpdateOnImage3 { get; set; }
        public IFormFile Image3 { get; set; } = null!;
        public string EducationalStages { get; set; } = string.Empty;
        public string Writings { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
