using MediatR;
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.User.Queries.GetAllSubscribers
{
    public class GetAllSubscribersQuery : IRequest<BaseResponse<List<UserListVm>>>
    {
        public bool? isValidAccount { get; set; }
        public bool ForInterview { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
