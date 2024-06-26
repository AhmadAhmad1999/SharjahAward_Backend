using MediatR;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageBySlug
{
    public class GetPageBySlugQuery : IRequest<BaseResponse<PageDto>>
    {
        public string Slug { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
