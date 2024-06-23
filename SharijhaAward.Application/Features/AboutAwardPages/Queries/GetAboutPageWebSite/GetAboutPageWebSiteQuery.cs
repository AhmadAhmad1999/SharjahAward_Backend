using MediatR;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPageWebSite
{
    public class GetAboutPageWebSiteQuery : IRequest<BaseResponse<AboutPageDto>>
    {
        public string lang { get; set; } = string.Empty;
    }
}
