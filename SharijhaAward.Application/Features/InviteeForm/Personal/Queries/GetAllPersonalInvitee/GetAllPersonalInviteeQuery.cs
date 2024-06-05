using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee
{
    public class GetAllPersonalInviteeQuery : IRequest<BaseResponse<List<PersonalInviteeListVM>>>
    {
        public int? EventId { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
        public string? name { get; set; } = string.Empty;
    }
}
