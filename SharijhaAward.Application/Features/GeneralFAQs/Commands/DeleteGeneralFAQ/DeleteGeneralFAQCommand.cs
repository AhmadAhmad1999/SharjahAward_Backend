using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralFAQs.Commands.DeleteGeneralFAQ
{
    public class DeleteGeneralFAQCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
