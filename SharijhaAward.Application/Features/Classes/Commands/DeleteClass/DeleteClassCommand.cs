using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Commands.DeleteClass
{
    public class DeleteClassCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string? lang { get; set; }
    }
}
