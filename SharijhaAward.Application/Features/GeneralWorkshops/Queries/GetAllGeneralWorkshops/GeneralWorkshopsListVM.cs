﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetAllGeneralWorkshops
{
    public class GeneralWorkshopsListVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string Thumbnale { get; set; } = string.Empty;
        public DateTime DateOfWorkShop { get; set; }
        public string DayName { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string? Video { get; set; } = string.Empty;
        public string? RegistrationUrl { get; set; } = string.Empty;
    }
}
