using MediatR;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilitiesByUserId
{
    public class GetAllResponsibilitiesByUserIdQuery : IRequest<BaseResponse<List<ResponsibilityListVM>>>
    {
        public int? UserId { get; set; }
        public string? UserToken { get; set; }
        public string? lang { get; set; }

    }
}
