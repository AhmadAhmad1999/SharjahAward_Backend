using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterionItem
{
    public class DeleteCriterionItemCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string? lang { get; set; }
    }
}
