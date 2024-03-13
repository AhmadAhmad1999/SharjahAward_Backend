using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class GetCoordinatorByIdQueryHandler
        : IRequestHandler<GetCoordinatorByIdQuery, BaseResponse<CoordinatorDto>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IMapper _mapper;

        public GetCoordinatorByIdQueryHandler(IAsyncRepository<Coordinator> coordinatorRepository, IMapper mapper)
        {
            _coordinatorRepository = coordinatorRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<CoordinatorDto>> Handle(GetCoordinatorByIdQuery request, CancellationToken cancellationToken)
        {
            var coordinator = await _coordinatorRepository.GetByIdAsync(request.CoordinatorId);
            if(coordinator == null)
            {
                return new BaseResponse<CoordinatorDto>("",false,404);
            }
            var data = _mapper.Map<CoordinatorDto>(coordinator);

            return new BaseResponse<CoordinatorDto>("", true, 200, data);

        }
    }
}
