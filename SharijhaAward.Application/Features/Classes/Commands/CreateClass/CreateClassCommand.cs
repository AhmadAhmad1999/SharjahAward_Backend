using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Commands.CreateClass
{
    public class CreateClassCommand : IRequest<BaseResponse<object>>
    {
        public string Name { get; set; } = null!;
        public string? lang { get; set; }
    }
}
