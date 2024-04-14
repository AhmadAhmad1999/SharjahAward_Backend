using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.DeleteEducationalEntity
{
    public class DeleteEducationalEntityCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
