using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.DeleteUserNoteOnForm
{
    public class DeleteUserNoteOnFormCommand : IRequest<BaseResponse<object>>
    {
        public int UserNoteOnFormForArbitrationId { get; set; }
        public string? lang { get; set; }
    }
}
