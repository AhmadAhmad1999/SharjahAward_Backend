using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities
{
    public class GetAllResponsibilitiesQuery : IRequest<BaseResponse<List<ResponsibilityListVM>>>
    {
        public int? RoleId { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;

    }
}
