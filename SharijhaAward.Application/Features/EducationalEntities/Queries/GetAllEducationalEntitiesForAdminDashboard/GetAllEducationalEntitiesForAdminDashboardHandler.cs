using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard
{
    public class GetAllEducationalEntitiesForAdminDashboardHandler : IRequestHandler<GetAllEducationalEntitiesForAdminDashboardQuery,
        BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;
        private readonly IMapper _Mapper;
        public GetAllEducationalEntitiesForAdminDashboardHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IAsyncRepository<EduInstitutionCoordinator> EduInstitutionCoordinatorRepository,
            IMapper Mapper)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>> 
            Handle(GetAllEducationalEntitiesForAdminDashboardQuery Request, CancellationToken cancellationToken)
        {
            List<GetAllEducationalEntitiesForAdminDashboardListVM> EducationalEntities = _Mapper.Map<List<GetAllEducationalEntitiesForAdminDashboardListVM>>
                (await _EducationalEntityRepository
                    .GetPagedReponseAsync(Request.page, Request.pageSize));

            List<EducationalInstitution> EducationalInstitutionEntities = await _EducationalInstitutionRepository
                .Where(x => EducationalEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                .ToListAsync();

            List<EduEntitiesCoordinator> CoordinatorFromEducationalEntities = await _EduEntitiesCoordinatorRepository
                .Where(x => EducationalEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                .Include(x => x.Coordinator!)
                .ToListAsync();

            List<EduInstitutionCoordinator> CoordinatorFromEducationalInstitution = await _EduInstitutionCoordinatorRepository
                .Include(x => x.EducationalInstitution!)
                .Where(x => EducationalEntities.Select(y => y.Id).Contains(x.EducationalInstitution!.EducationalEntityId))
                .Include(x => x.Coordinator!)
                .ToListAsync();

            EducationalEntities = EducationalEntities.Select(x => new GetAllEducationalEntitiesForAdminDashboardListVM()
            {
                Id = x.Id,
                ArabicName = x.ArabicName,
                EnglishName = x.EnglishName,
                EducationalInstitutions = EducationalInstitutionEntities.Where(y => y.EducationalEntityId == x.Id)
                    .Select(y => new EducationalInstitutionListVM()
                    {
                        Id = y.Id,
                        ArabicName = y.ArabicName,
                        EnglishName = y.EnglishName
                    }).ToList(),
                Coordinators = CoordinatorFromEducationalEntities
                    .Select(y => new EducaltionalEntitiesCoordinatorListVM()
                    {
                        Id = y.Coordinator!.Id,
                        ArabicName = y.Coordinator!.ArabicName,
                        EnglishName = y.Coordinator!.EnglishName
                    }).Concat(CoordinatorFromEducationalInstitution
                    .Select(y => new EducaltionalEntitiesCoordinatorListVM()
                    {
                        Id = y.Coordinator!.Id,
                        ArabicName = y.Coordinator!.ArabicName,
                        EnglishName = y.Coordinator!.EnglishName
                    }))
                .Distinct().ToList() 
            }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _EducationalEntityRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>(ResponseMessage, true, 200, EducationalEntities, PaginationParameter);
        }
    }
}
