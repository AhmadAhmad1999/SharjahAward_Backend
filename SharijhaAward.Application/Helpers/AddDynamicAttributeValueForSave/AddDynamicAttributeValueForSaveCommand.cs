using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValueForSave
{
    public class AddDynamicAttributeValueForSaveCommand : IRequest<BaseResponse<AddDynamicAttributeValueForSaveResponse>>
    {
        public int RecordId { get; set; }
        public List<AddDynamicAttributeValueForSaveMainCommand> DynamicAttributesWithValues { get; set; } = new List<AddDynamicAttributeValueForSaveMainCommand>();
        public List<AddDynamicAttributeTableValueForSaveMainCommand> DynamicAttributesWithTableValues { get; set; } = new List<AddDynamicAttributeTableValueForSaveMainCommand>();
        public List<AddDynamicAttributeValueMobileCommand>? DynamicAttributesWithValuesMobile { get; set; }
        public List<AddDynamicAttributeTableValueMobileCommand>? DynamicAttributesWithTableValuesMobile { get; set; }
        public List<IFormFile>? ValueAsBinaryFiles { get; set; }
        public List<IFormFile>? ValueAsBinaryFilesForTable { get; set; }
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
