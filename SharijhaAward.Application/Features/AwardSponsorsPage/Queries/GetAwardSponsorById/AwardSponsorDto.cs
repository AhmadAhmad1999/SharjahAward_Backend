﻿using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Queries.GetAwardSponsorById
{
    public class AwardSponsorDto
    {
        public int Id { get; set; }
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string UpbringingAndAiography { get; set; } = string.Empty;
        public string EnglishUpbringingAndAiography { get; set; } = string.Empty;
        public string ArabicUpbringingAndAiography { get; set; } = string.Empty;
        public string Image2 { get; set; } = string.Empty;
        public string HonoraryPositions { get; set; } = string.Empty;
        public string EnglishHonoraryPositions { get; set; } = string.Empty;
        public string ArabicHonoraryPositions { get; set; } = string.Empty;
        public string Image3 { get; set; } = string.Empty;
        public string EducationalStages { get; set; } = string.Empty;
        public string Writings { get; set; } = string.Empty;
        public string EnglishEducationalStages { get; set; } = string.Empty;
        public string ArabicEducationalStages { get; set; } = string.Empty;
        public string EnglishWritings { get; set; } = string.Empty;
        public string ArabicWritings { get; set; } = string.Empty;
    }
}
