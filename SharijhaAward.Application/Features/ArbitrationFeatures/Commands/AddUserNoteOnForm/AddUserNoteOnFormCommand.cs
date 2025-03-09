using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AddUserNoteOnForm
{
    public class AddUserNoteOnFormCommand : IRequest<BaseResponse<object>>
    {
        public int ProvidedFormId { get; set; }
        public ArbitrationStep ArbitrationStep { get; set; }
        public string Note { get; set; } = null!;
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
