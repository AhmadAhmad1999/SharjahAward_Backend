﻿using Microsoft.AspNetCore.Http;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValue
{
    public class AddDynamicAttributeTableValueMainCommand
    {
        public int DynamicAttributeId { get; set; }
        public int RowId { get; set; }
        public string? ValueAsString { get; set; } = null!;
        public IFormFile? ValueAsBinaryFile { get; set; } = null!;
    }
}
