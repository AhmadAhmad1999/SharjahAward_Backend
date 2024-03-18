using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetGeneralWorkshopById
{
    public class GetGeneralWorkshopByIdQuery : IRequest<BaseResponse<GeneralWorkshopDto>>
    {
        public Guid Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
