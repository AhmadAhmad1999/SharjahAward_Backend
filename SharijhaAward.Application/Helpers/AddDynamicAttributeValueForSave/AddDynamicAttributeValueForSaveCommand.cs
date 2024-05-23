using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValueForSave
{
    public class AddDynamicAttributeValueForSaveCommand : IRequest<BaseResponse<AddDynamicAttributeValueForSaveResponse>>
    {
        public int RecordId { get; set; }
        public List<AddDynamicAttributeValueForSaveMainCommand> DynamicAttributesWithValues { get; set; } = new List<AddDynamicAttributeValueForSaveMainCommand>();
        public List<AddDynamicAttributeTableValueForSaveMainCommand> DynamicAttributesWithTableValues { get; set; } = new List<AddDynamicAttributeTableValueForSaveMainCommand>();
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
