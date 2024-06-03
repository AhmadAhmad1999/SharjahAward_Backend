﻿using Microsoft.AspNetCore.Http;

namespace SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValueForSave
{
    public class AddAdvancedFormBuilderTableValueForSaveMainCommand
    {
        public int AdvancedFormBuilderId { get; set; }
        public int RowId { get; set; }
        public string? ValueAsString { get; set; } = null!;
        public IFormFile? ValueAsBinaryFile { get; set; } = null!;
    }
}
