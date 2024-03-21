using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetLimteNumberOfCategories
{
    public class GetLimteNumberOfCategoriesQueryHandler
        : IRequestHandler<GetLimteNumberOfCategoriesQuery, BaseResponse<LimitationDto>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public GetLimteNumberOfCategoriesQueryHandler(IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<LimitationDto>> Handle(GetLimteNumberOfCategoriesQuery request, CancellationToken cancellationToken)
        {
            var cycle = await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Status.Active);

            if (cycle == null)
            {
                return new BaseResponse<LimitationDto>("Cycle Not Found", false, 404);
            }
            var data = _mapper.Map<LimitationDto>(cycle);

            return new BaseResponse<LimitationDto>("", true, 200, data);
        }
    }
}
