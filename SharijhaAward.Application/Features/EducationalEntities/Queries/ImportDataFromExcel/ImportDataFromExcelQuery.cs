using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.ImportDataFromExcel
{
    public class ImportDataFromExcelQuery : IRequest<BaseResponse<object>>
    {
        public IFormFile ImporterFile { get; set; } = null!;
        public bool Replace { get; set; }
        public string? lang { get; set; }
    }
}
