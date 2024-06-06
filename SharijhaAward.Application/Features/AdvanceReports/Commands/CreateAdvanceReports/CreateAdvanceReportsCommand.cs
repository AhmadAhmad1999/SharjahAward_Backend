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
        public string[] cycleColumns { get; set; } = null!;
        public string[]? categoryColumns { get; set; }
        public string[]? subCategoryColumns { get; set; } 
        public string[]? providedFormColumns { get; set; } 
        public string[]? userColumns { get; set; } 
        public string[]? coordinatorColumns { get; set; } 
        public string[]? arbitratorColumns { get; set; } 

    }
}
