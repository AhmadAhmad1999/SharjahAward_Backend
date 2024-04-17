using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.MessageTypes.Queries.AsignMessageToRole
{
    public class AsignMessageToRoleQuery : IRequest<BaseResponse<object>>
    {
        public int TypeId {  get; set; }
        public int RoleId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
