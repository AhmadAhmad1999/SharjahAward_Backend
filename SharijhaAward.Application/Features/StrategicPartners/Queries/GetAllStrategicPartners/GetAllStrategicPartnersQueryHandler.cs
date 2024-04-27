﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.StrategicPartnerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.StrategicPartners.Queries.GetAllStrategicPartners
{
    public class GetAllStrategicPartnersQueryHandler
        : IRequestHandler<GetAllStrategicPartnersQuery, BaseResponse<List<StrategicPartnerListVM>>>
    {
        private readonly IAsyncRepository<StrategicPartner> _strategicPartnerRepository;
        private readonly IMapper _mapper;

        public GetAllStrategicPartnersQueryHandler(IAsyncRepository<StrategicPartner> strategicPartnerRepository, IMapper mapper)
        {
            _strategicPartnerRepository = strategicPartnerRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<StrategicPartnerListVM>>> Handle(GetAllStrategicPartnersQuery request, CancellationToken cancellationToken)
        {
            var AllStrategicPartners = await _strategicPartnerRepository.GetPagedReponseAsync(request.page, request.pageSize);

            var data = _mapper.Map<List<StrategicPartnerListVM>>(AllStrategicPartners);

            int Count = _strategicPartnerRepository.GetCount(p => !p.isDeleted);

            Pagination pagination = new Pagination(request.page, request.pageSize, Count);

            return new BaseResponse<List<StrategicPartnerListVM>>("", true, 200, data, pagination);
        }
    }
}
