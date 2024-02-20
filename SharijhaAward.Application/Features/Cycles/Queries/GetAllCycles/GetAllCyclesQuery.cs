using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles
{
    public class GetAllCyclesQuery :IRequest<BaseResponse<List<CycleListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page {  get; set; }
        public int pageSize {  get; set; }
    }
}
