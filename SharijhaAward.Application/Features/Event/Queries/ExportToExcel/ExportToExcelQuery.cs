﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.ExportToExcel
{
    public class ExportToExcelQuery : IRequest<List<EventsExportVM>>
    {
        public string typeOfExport { get; set; } = string.Empty;
    }
}
