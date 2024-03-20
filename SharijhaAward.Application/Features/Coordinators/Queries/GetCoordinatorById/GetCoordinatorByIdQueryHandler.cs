using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
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
        private readonly IAsyncRepository<EduInstitutionCoordinator> _eduInstitutionCoordinatorRepository;
        private readonly IAsyncRepository<EducationalInstitution> _educationalInstitutionRepository;
        private readonly IMapper _mapper;

        public GetCoordinatorByIdQueryHandler(IAsyncRepository<EducationalInstitution> educationalInstitutionRepository,IAsyncRepository<EduInstitutionCoordinator> eduInstitutionCoordinatorRepository,IAsyncRepository<Coordinator> coordinatorRepository, IMapper mapper)
        {
            _coordinatorRepository = coordinatorRepository;
            _eduInstitutionCoordinatorRepository = eduInstitutionCoordinatorRepository;
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<CoordinatorDto>> Handle(GetCoordinatorByIdQuery request, CancellationToken cancellationToken)
        {
            var coordinator = await _coordinatorRepository.GetByIdAsync(request.CoordinatorId);
            if(coordinator == null)
            {
                return new BaseResponse<CoordinatorDto>("",false,404);
            }
            var EduInstitutions = _eduInstitutionCoordinatorRepository.Where(i => i.CoordinatorId == coordinator.Id).ToList();

            var data = _mapper.Map<CoordinatorDto>(coordinator);
            for(int i = 0; i < EduInstitutions.Count(); i++)
            {
                var Institutions = await _educationalInstitutionRepository.GetByIdAsync(EduInstitutions[i].Id);
                if(Institutions != null)
                {
                    data.SchoolName.Add(request.lang=="en" ? Institutions.EnglishName : Institutions.ArabicName);
                }
               
            }
            data.Name = request.lang == "en"
                ? data.EnglishName
                : data.ArabicName;
            return new BaseResponse<CoordinatorDto>("", true, 200, data);

        }
    }
}
