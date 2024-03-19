﻿using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage
{
    public class AboutPageDto
    {
        public string AboutTitle { get; set; } = string.Empty;
        public string AboutDescription { get; set; } = string.Empty;
        public string ArabicAboutTitle { get; set; } = string.Empty;
        public string EnglishAboutTitle { get; set; } = string.Empty;
        public string ArabicAboutDescription { get; set; } = string.Empty;
        public string EnglishAboutDescription { get; set; } = string.Empty;
        public string AboutImage { get; set; } = string.Empty;
        public string OurVisionTitle { get; set; } = string.Empty;
        public string OurVisionDescription { get; set; } = string.Empty;
        public string ArabicOurVisionTitle { get; set; } = string.Empty;
        public string EnglishOurVisionTitle { get; set; } = string.Empty;
        public string ArabicOurVisionDescription { get; set; } = string.Empty;
        public string EnglishOurVisionDescription { get; set; } = string.Empty;
        public string OurVisionImage { get; set; } = string.Empty;
        public List<OurGoalsDto> OurGoals { get; set; } = null!;
    }
}
