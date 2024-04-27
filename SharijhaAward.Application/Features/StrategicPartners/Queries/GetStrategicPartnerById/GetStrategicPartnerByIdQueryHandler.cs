using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.StrategicPartnerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.StrategicPartners.Queries.GetStrategicPartnerById
{
    public class GetStrategicPartnerByIdQueryHandler
        : IRequestHandler<GetStrategicPartnerByIdQuery, BaseResponse<StrategicPartnerDto>>
    {
        private readonly IAsyncRepository<StrategicPartner> _strategicPartnerRepository;
        private readonly IMapper _mapper;

        public GetStrategicPartnerByIdQueryHandler(IAsyncRepository<StrategicPartner> strategicPartnerRepository, IMapper mapper)
        {
            _strategicPartnerRepository = strategicPartnerRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<StrategicPartnerDto>> Handle(GetStrategicPartnerByIdQuery request, CancellationToken cancellationToken)
        {
            var StrategicPartner = await _strategicPartnerRepository.GetByIdAsync(request.Id);
            if(StrategicPartner == null)
            {
                return new BaseResponse<StrategicPartnerDto>("", false, 404);
            }

            var data = _mapper.Map<StrategicPartnerDto>(StrategicPartner);

            return new BaseResponse<StrategicPartnerDto>("", true, 200, data);
        }
    }
}
