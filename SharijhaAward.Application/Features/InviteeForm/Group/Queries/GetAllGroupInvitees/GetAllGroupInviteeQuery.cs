using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees
{
    public class GetAllGroupInviteeQuery : IRequest<BaseResponse<List<GroupInviteeListVM>>>
    {
        public int page {  get; set; }
        public int pageSize { get; set; }
        public string? name { get; set; } = string.Empty;
    }
}
