﻿using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetAllEvents
{
    public class EventListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SiteName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string ArabicSiteName { get; set; } = string.Empty;
        public string ArabicLocation { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string EnglishSiteName { get; set; } = string.Empty;
        public string EnglishLocation { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool isPublic { get; set; }
    }
}
