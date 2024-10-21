using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage
{
    public class GetAboutPageQuery : IRequest<BaseResponse<AboutPageDto>>
    {
        public string lang { get; set; } = string.Empty;
    }
}
