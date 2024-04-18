﻿namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class ArbitratorDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool isChairman { get; set; } = false;
        public string? lang { get; set; }
        public List<ArbitratorCategoryDto> ArbitratorCategories { get; set; } = new List<ArbitratorCategoryDto>();
    }
}
