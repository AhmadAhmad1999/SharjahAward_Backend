using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Commands.UpdateClass
{
    public class UpdateClassCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string? lang { get; set; }
    }
}
