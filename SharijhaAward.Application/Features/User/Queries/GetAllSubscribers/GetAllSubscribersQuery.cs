using MediatR;
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetAllSubscribers
{
    public class GetAllSubscribersQuery : IRequest<BaseResponse<List<UserListVm>>>
    {

    }
}
