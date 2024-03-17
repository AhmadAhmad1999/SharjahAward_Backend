using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetAllGeneralWorkshops
{
    public class GetAllGeneralWorkshopsQuery : IRequest<BaseResponse<List<GeneralWorkshopsListVM>>>
    {
        public int page {  get; set; }
        public int pageSize { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
