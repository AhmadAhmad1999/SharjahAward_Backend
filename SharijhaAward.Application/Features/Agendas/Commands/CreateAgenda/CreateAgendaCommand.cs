using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AgendaConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda
{
    public class CreateAgendaCommand : IRequest<BaseResponse<object>>
    {
        public string lang { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public IFormFile Icon { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime EndDate { get; set; }
        public AgendaDateType DateType { get; set; }
        public int CycleId { get; set; }
    }
}
