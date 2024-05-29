using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.DeleteAdvancedFormBuilderListValue
{
    public class DeleteAdvancedFormBuilderListValueCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}