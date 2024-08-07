using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Settings.Queries.GetAboutApp
{
    public class GetAboutAppQuery : IRequest<BaseResponse<AboutAppDto>>
    {
        public string Slug { get; set; } = null!;
        public string? lang { get; set; }
    }
}
