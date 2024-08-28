using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
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
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduInstitutionCoordinatorRepository;
        private readonly IMapper _Mapper;
        public GetAllEducationalEntitiesForAdminDashboardHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduInstitutionCoordinatorRepository,
            IMapper Mapper)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>> 
            Handle(GetAllEducationalEntitiesForAdminDashboardQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            List<GetAllEducationalEntitiesForAdminDashboardListVM> EducationalEntities = _Mapper.Map<List<GetAllEducationalEntitiesForAdminDashboardListVM>>
                (await _EducationalEntityRepository
                    .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                    .ToListAsync());

            List<EducationalInstitution> EducationalInstitutionEntities = await _EducationalInstitutionRepository
                .Where(x => EducationalEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                .ToListAsync();

            List<EduEntitiesCoordinator> CoordinatorFromEducationalEntities = await _EduInstitutionCoordinatorRepository
                .Include(x => x.EducationalEntity!)
                .Include(x => x.Coordinator!)
                .Where(x => EducationalEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
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
                        EnglishName = y.EnglishName,
                        Coordinators = _Mapper.Map<List<CoordinatorDto>>(CoordinatorFromEducationalEntities.Select(c=>c.Coordinator))
                    }).ToList()
            }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _EducationalEntityRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>(ResponseMessage, true, 200, EducationalEntities, PaginationParameter);
        }
    }
}
