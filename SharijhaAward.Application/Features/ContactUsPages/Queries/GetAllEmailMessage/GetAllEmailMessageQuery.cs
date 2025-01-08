using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage
{
    public class GetAllEmailMessageQuery : IRequest<BaseResponse<List<EmailMessageListVM>>>
    {
        public string? token { get; set; } 
        public string? lang { get; set; }
        public int page {  get; set; }
        public int perPage { get; set; }
        public string? query { get; set; } = string.Empty;
        public int? filter { get; set; } //0 for all - 1 for OutComing - 2 for InComing
    }
}
