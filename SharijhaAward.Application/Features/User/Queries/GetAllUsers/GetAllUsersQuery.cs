using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<BaseResponse<List<UserListVm>>>
    {
        public int page {  get; set; }
        public int pageSize { get; set; }
    }
}
