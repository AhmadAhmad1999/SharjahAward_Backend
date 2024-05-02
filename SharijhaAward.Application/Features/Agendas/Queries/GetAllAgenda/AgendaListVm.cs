﻿using SharijhaAward.Application.Helpers.DateTimeConverter;
using SharijhaAward.Domain.Constants.AgendaConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda
{
    public class AgendaListVm
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [JsonConverter(typeof(DateTimeNoFormatConverter))]
        public DateTime CurrentDate { get; set; }
        public AgendaStatus Status { get; set; }
        public AgendaDateType DateType { get; set; }
        public int CycleId { get; set; }
    }
}
