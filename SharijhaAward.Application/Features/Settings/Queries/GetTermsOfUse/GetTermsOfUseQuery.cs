using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Queries.GetTermsOfUse
{
    public class GetTermsOfUseQuery : IRequest<BaseResponse<GetTermsOfUseDto>>
    {
        public string? lang { get; set; }
    }
}
