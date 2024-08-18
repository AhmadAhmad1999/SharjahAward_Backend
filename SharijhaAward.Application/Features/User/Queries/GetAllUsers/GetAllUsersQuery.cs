﻿using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<BaseResponse<List<UserListVm>>>
    {
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
