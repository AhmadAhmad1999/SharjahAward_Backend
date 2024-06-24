using MediatR;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValueForSave;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeForNewRow
{
    public class AddDynamicAttributeForNewRowCommand : IRequest<BaseResponse<List<AddDynamicAttributeTableValueForSaveMainCommand>>>
    {
        public List<AddDynamicAttributeTableValueForSaveMainCommand> DynamicAttributesWithTableValues { get; set; } = new List<AddDynamicAttributeTableValueForSaveMainCommand>();
        public string? lang { get; set; }
    }
}
