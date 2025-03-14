﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetCycleById
{
    public class GetCycleByIdQueryHandler
        : IRequestHandler<GetCycleByIdQuery, BaseResponse<CycleDto>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public GetCycleByIdQueryHandler(IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<CycleDto>> Handle(GetCycleByIdQuery request, CancellationToken cancellationToken)
        {
            var Cycle = await _cycleRepository.GetByIdAsync(request.Id);
            string msg;
           
            if(Cycle == null)
            {
                msg = request.lang == "en"
                    ? "The Cycle is Not Found"
                    : "الدورة غير موجودة";

                return new BaseResponse<CycleDto>(msg, false, 404);
            }
            var Data = _mapper.Map<CycleDto>(Cycle);

            return new BaseResponse<CycleDto>("", true, 200, Data);
        }
    }
}
