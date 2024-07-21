using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.WinnersFeatures.Commands.SelectWinningForms
{
    public class SelectWinningFormsCommand : IRequest<BaseResponse<object>>
    {
        public int CategoryId { get; set; }
        public int? NewFormId { get; set; }
        public int? DeleteFormId { get; set; }
        public string? lang { get; set; }
    }
}
