using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.StrategicPartners.Queries.GetAllStrategicPartners
{
    public class GetAllStrategicPartnersQuery : IRequest<BaseResponse<List<StrategicPartnerListVM>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
