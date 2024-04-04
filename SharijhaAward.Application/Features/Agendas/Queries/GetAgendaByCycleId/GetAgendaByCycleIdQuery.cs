using MediatR;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAgendaByCycleId
{
    public class GetAgendaByCycleIdQuery : IRequest<BaseResponse<List<AgendaListVm>>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public string lang { get; set; } = string.Empty;
        public Guid? CycleId { get; set; }
    }
}
