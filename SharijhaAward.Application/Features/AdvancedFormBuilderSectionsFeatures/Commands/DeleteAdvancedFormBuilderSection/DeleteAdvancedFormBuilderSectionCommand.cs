using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.DeleteAdvancedFormBuilderSection
{
    public class DeleteAdvancedFormBuilderSectionCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
