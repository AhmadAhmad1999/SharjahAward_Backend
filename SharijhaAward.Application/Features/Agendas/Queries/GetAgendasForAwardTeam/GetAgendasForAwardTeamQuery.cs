using MediatR;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAgendasForAwardTeam
{
    public class GetAgendasForAwardTeamQuery : IRequest<BaseResponse<List<AgendaListVm>>>
    {
        public int? CycleId { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string token { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
