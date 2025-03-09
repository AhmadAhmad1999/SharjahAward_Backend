using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard
{
    public class GetAllEducationalEntitiesForAdminDashboardHandler : IRequestHandler<GetAllEducationalEntitiesForAdminDashboardQuery,
        BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduInstitutionCoordinatorRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IMapper _Mapper;
        public GetAllEducationalEntitiesForAdminDashboardHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduInstitutionCoordinatorRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IMapper Mapper)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
            this._CycleRepository = _CycleRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>> 
            Handle(GetAllEducationalEntitiesForAdminDashboardQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };
            List<GetAllEducationalEntitiesForAdminDashboardListVM> EducationalEntities = new List<GetAllEducationalEntitiesForAdminDashboardListVM>();

            if (Request.CycleId is null)
            {
                Cycle? CycleEntity = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (CycleEntity is null)
                    return new BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>();

                Request.CycleId = CycleEntity.Id;
            }

            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                EducationalEntities = _Mapper.Map<List<GetAllEducationalEntitiesForAdminDashboardListVM>>
                    (await _EducationalEntityRepository
                        .WhereThenFilter(x => x.CycleId == Request.CycleId, FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync());
            }
            else
            {
                EducationalEntities = _Mapper.Map<List<GetAllEducationalEntitiesForAdminDashboardListVM>>
                    (await _EducationalEntityRepository
                        .WhereThenFilter(x => x.CycleId == Request.CycleId, FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .ToListAsync());
            }

            List<EducationalInstitution> EducationalInstitutionEntities = await _EducationalInstitutionRepository
                .Where(x => EducationalEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                .ToListAsync();

            List<EduEntitiesCoordinator> CoordinatorFromEducationalEntities = await _EduInstitutionCoordinatorRepository
                .Where(x => EducationalEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                .ToListAsync();

            EducationalEntities = EducationalEntities
                .Select(x => new GetAllEducationalEntitiesForAdminDashboardListVM()
                {
                    Id = x.Id,
                    ArabicName = x.ArabicName,
                    EnglishName = x.EnglishName,
                    EducationalInstitutions = EducationalInstitutionEntities
                        .Where(y => y.EducationalEntityId == x.Id)
                        .Select(y => new EducationalInstitutionListVM()
                        {
                            Id = y.Id,
                            ArabicName = y.ArabicName,
                            EnglishName = y.EnglishName,
                            Coordinators = _Mapper.Map<List<CoordinatorDto>>(CoordinatorFromEducationalEntities
                                .Where(z => z.EducationalEntityId == x.Id)
                                .Select(z => z.Coordinator))
                        }).ToList()
                }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _EducationalEntityRepository
                .WhereThenFilter(x => x.CycleId == Request.CycleId, FilterObject)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>(ResponseMessage, true, 200,
                EducationalEntities, PaginationParameter);
        }
    }
}
