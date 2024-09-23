using MediatR;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPages;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPagesInCell
{
    public class GetPagesInCellQuery : IRequest<BaseResponse<List<MainPageListVM>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public string? lang { get; set; }
    }
}
