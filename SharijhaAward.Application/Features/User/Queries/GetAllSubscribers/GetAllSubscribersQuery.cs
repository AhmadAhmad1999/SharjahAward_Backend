using MediatR;
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.User.Queries.GetAllSubscribers
{
    public class GetAllSubscribersQuery : IRequest<BaseResponse<List<UserListVm>>>
    {
        public bool? isValidAccount { get; set; }
        public int page {  get; set; }
        public int pageSize { get; set; }
        public List<Filter>? filters { get; set; }
    }
}
