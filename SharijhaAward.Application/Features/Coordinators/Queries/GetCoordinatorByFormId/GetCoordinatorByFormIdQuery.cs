using MediatR;
using SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorByFormId
{
    public class GetCoordinatorByFormIdQuery : IRequest<BaseResponse<List<CoordinatorsListVM>>>
    {
        public int formId { get; set; }
        public string token { get; set; } = string.Empty;
        public string? lang { get; set; }

    }
}
