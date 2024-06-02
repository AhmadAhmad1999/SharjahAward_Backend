using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValueForSave
{
    public class AddAdvancedFormBuilderValueForSaveCommand : IRequest<BaseResponse<AddAdvancedFormBuilderValueForSaveResponse>>
    {
        public int VirtualTableId { get; set; }
        public List<AddAdvancedFormBuilderValueForSaveMainCommand> AdvancedFormBuildersWithValues { get; set; } = new List<AddAdvancedFormBuilderValueForSaveMainCommand>();
        public List<AddAdvancedFormBuilderTableValueForSaveMainCommand> AdvancedFormBuildersWithTableValues { get; set; } = new List<AddAdvancedFormBuilderTableValueForSaveMainCommand>();
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
