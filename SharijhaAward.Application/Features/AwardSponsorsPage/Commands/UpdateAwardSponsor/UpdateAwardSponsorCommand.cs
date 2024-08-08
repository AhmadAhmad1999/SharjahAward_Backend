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

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Commands.UpdateAwardSponsor
{
    public class UpdateAwardSponsorCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public bool UpdateOnImage1 { get; set; }
        public IFormFile? Image { get; set; } = null!;
        public string EnglishUpbringingAndAiographyFirst { get; set; } = string.Empty;
        public string EnglishUpbringingAndAiographySecound { get; set; } = string.Empty;
        public string ArabicUpbringingAndAiographyFirst { get; set; } = string.Empty;
        public string ArabicUpbringingAndAiographySecound { get; set; } = string.Empty;
        public bool UpdateOnImage2 { get; set; }
        public IFormFile? Image2 { get; set; } = null!;
        public string EnglishHonoraryPositions { get; set; } = string.Empty;
        public string ArabicHonoraryPositions { get; set; } = string.Empty;
        public bool UpdateOnImage3 { get; set; }
        public IFormFile? Image3 { get; set; } = null!;
        public string EnglishEducationalStages { get; set; } = string.Empty;
        public string ArabicEducationalStages { get; set; } = string.Empty;
        public string EnglishWritings { get; set; } = string.Empty;
        public string ArabicWritings { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
