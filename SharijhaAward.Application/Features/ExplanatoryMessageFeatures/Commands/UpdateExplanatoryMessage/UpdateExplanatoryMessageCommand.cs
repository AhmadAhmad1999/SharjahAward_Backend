using MediatR;
using SharijhaAward.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Commands.UpdateExplanatoryMessage
{
    public class UpdateExplanatoryMessageCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [MaxLength]
        public string ArabicText { get; set; } = null!;
        [MaxLength]
        public string EnglishText { get; set; } = null!;
        public string? lang { get; set; }
    }
}
