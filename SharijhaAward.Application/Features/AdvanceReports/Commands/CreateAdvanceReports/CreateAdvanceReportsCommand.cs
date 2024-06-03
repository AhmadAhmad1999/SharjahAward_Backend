using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AdvanceReports.Commands.CreateAdvanceReports
{
    public class CreateAdvanceReportsCommand 
        : IRequest<BaseResponse<List<Dictionary<string,object>>>>
    {
        public string[] cycleColums { get; set; } = null!;
        public string[]? categoryColums { get; set; }
        public string[]? subCategoryColums { get; set; } 
        public string[]? ProvidedFormColums { get; set; } 
    }
}
