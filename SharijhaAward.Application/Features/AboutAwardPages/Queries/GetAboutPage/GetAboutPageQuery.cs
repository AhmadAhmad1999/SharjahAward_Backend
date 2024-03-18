using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage
{
    public class GetAboutPageQuery : IRequest<BaseResponse<AboutPageDto>>
    {
        public string lang { get; set; } = string.Empty;
    }
}
