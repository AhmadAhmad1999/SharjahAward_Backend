using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Commands.UpdateClass
{
    public class UpdateClassCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? lang { get; set; }
    }
}
