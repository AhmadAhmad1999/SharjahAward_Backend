using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.AddCordinatorToEduEntity
{
    public class AddCoordinatorToEduEntityQueryHandler
        : IRequestHandler<AddCoordinatorToEduEntityQuery, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<EducationalEntity> _educationalEntityRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _entitiesCoordinatorRepository;
        private readonly IMapper _mapper;

        public AddCoordinatorToEduEntityQueryHandler(IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<EducationalEntity> educationalEntityRepository, IAsyncRepository<EduEntitiesCoordinator> entitiesCoordinatorRepository, IMapper mapper)
        {
            _coordinatorRepository = coordinatorRepository;
            _educationalEntityRepository = educationalEntityRepository;
            _entitiesCoordinatorRepository = entitiesCoordinatorRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(AddCoordinatorToEduEntityQuery request, CancellationToken cancellationToken)
        {
            var coordinator = await _coordinatorRepository.GetByIdAsync(request.CoordinatorId);
            var entity = await _educationalEntityRepository.GetByIdAsync(request.EducationalEntityId);
            if(coordinator == null || entity == null)
            {
                return new BaseResponse<int>("", false, 404);
            }
            var EntitiesCoordinator = _mapper.Map<EduEntitiesCoordinator>(request);
           
            var data = await _entitiesCoordinatorRepository.AddAsync(EntitiesCoordinator);
           
            return new BaseResponse<int>("", true, 200, data.Id);

        }
    }
}
