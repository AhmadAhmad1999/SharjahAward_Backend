using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllWebsiteResponsesForMessage
{
    public class GetAllWebsiteResponsesForMessageQuery : IRequest<BaseResponse<List<GetAllWebsiteResponsesForMessageListVM>>>
    {
        public int MessageId { get; set; }
        public string? lang { get; set; }
    }
}
