using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.OpenFormForUpdate
{
    public class OpenFormForUpdateCommand : IRequest<BaseResponse<object>>
    {
        public int ProvidedFormId { get; set; }
        public string? lang { get; set; }
    }
}
