﻿using MediatR;
using Microsoft.AspNetCore.Http;
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
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public bool IsPrivate { get; set; }
        public bool UpdateOnIcone {  get; set; }
        public IFormFile? Icon { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime EndDate { get; set; }
        public AgendaDateType DateType { get; set; }
        public int CycleId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
