using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard
{
    public class GetAllEducationalEntitiesForAdminDashboardHandler : IRequestHandler<GetAllEducationalEntitiesForAdminDashboardQuery,
        BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IMapper _Mapper;
        public GetAllEducationalEntitiesForAdminDashboardHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IMapper Mapper)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
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
                .Include(x => x.EducationalEntity!)
                .ToListAsync();

            EducationalEntities = EducationalEntities.Select(x => new GetAllEducationalEntitiesForAdminDashboardListVM()
            {
                Id = x.Id,
                ArabicName = x.ArabicName,
                EnglishName = x.EnglishName,
                EducationalInstitutions = EducationalInstitutionEntities.Where(y => y.EducationalEntityId == x.Id)
                    .Select(y => new EducationalInstitutionListVM()
                    {
                        Id = y.EducationalEntity!.Id,
                        ArabicName = y.EducationalEntity!.ArabicName,
                        EnglishName = y.EducationalEntity!.EnglishName
                    }).ToList()
            }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _EducationalEntityRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>(ResponseMessage, true, 200, EducationalEntities, PaginationParameter);
        }
    }
}
