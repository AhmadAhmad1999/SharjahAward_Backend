using MediatR;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllMsgForAwardTeam
{
    public class GetAllMsgForAwardTeamQuery : IRequest<BaseResponse<List<EmailMessageListVM>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public string token { get; set; } = string.Empty;
        public string? lang {  get; set; }
        public bool FromWebsite { get; set; }
    }
}
