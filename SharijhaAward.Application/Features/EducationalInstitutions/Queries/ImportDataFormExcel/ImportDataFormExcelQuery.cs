using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.ImportDataFormExcel
{
    public class ImportDataFormExcelQuery : IRequest<BaseResponse<List<int>>>
    {
        public IFormFile ImporterFile { get; set; } = null!;
        public bool Replace { get; set; }
        public string? lang { get; set; }
    }
}
