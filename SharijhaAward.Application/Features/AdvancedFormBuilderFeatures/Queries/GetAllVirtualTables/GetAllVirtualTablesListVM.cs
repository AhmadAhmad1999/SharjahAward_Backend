﻿namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllVirtualTables
{
    public class GetAllVirtualTablesListVM
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public bool isOpen { get; set; }
        public string PrivateHashKey { get; set; } = null!;
    }
}
