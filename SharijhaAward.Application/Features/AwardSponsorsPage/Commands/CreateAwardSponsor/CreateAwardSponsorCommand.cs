using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
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
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public IFormFile Image { get; set; } = null!;
        public string EnglishUpbringingAndAiography { get; set; } = string.Empty;
        public string ArabicUpbringingAndAiography { get; set; } = string.Empty;
        public IFormFile Image2 { get; set; } = null!;
        public string EnglishHonoraryPositions { get; set; } = string.Empty;
        public string ArabicHonoraryPositions { get; set; } = string.Empty;
        public IFormFile Image3 { get; set; } = null!;
        public string EnglishEducationalStages { get; set; } = string.Empty;
        public string ArabicEducationalStages { get; set; } = string.Empty;
        public string EnglishWritings { get; set; } = string.Empty;
        public string ArabicWritings { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
