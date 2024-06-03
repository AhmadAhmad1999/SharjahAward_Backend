using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValue
{
    public class AddAdvancedFormBuilderValueCommand : IRequest<BaseResponse<AddAdvancedFormBuilderValueResponse>>
    {
        public int VirtualTableId { get; set; }
        public List<AddAdvancedFormBuilderValueMainCommand> AdvancedFormBuildersWithValues { get; set; } = new List<AddAdvancedFormBuilderValueMainCommand>();
        public List<AddAdvancedFormBuilderTableValueMainCommand> AdvancedFormBuildersWithTableValues { get; set; } = new List<AddAdvancedFormBuilderTableValueMainCommand>();
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
