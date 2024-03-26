using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class GetCoordinatorByIdQuery : IRequest<BaseResponse<GetCoordinatorByIdRespnse>>
    {
        public Guid CoordinatorId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
