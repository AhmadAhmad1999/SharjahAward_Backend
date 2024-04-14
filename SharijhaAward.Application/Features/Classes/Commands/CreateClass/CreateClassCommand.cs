using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Commands.CreateClass
{
    public class CreateClassCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public int CycleId { get; set; }
        public string? lang { get; set; }
    }
}
