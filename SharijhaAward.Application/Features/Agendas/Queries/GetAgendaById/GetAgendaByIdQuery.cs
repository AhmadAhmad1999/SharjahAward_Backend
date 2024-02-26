using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAgendaById
{
    public class GetAgendaByIdQuery :IRequest<BaseResponse<AgendaDto>>
    {
        public Guid Id {  get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
