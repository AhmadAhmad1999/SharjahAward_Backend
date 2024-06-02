using Microsoft.AspNetCore.Http;

namespace SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValue
{
    public class AddAdvancedFormBuilderTableValueMainCommand
    {
        public int AdvancedFormBuilderId { get; set; }
        public int RowId { get; set; }
        public string? ValueAsString { get; set; } = null!;
        public IFormFile? ValueAsBinaryFile { get; set; } = null!;
    }
}
