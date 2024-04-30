using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetAllMainPages
{
    public class GetAllMainPagesQuery : IRequest<BaseResponse<List<MainPageListVM>>>
    {
        public string? lang { get; set; }
    }
}
