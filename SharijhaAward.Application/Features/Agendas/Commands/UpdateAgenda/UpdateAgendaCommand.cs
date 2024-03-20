using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AgendaConstants;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Commands.UpdateAgenda
{
    public class UpdateAgendaCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public AgendaStatus Status { get; set; }
        public Guid CycleId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
