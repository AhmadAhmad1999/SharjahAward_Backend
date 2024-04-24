using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<BaseResponse<List<GetAllUsersListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
