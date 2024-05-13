using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators
{
    public class GetAllCoordinatorsHandler : IRequestHandler<GetAllCoordinatorsQuery,
        BaseResponse<List<GetAllCoordinatorsListVM>>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IMapper _Mapper;

        public GetAllCoordinatorsHandler(IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IMapper Mapper)
        {
            _CoordinatorRepository = CoordinatorRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllCoordinatorsListVM>>> Handle(GetAllCoordinatorsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };
            List<GetAllCoordinatorsListVM> Coordinators = _Mapper.Map<List<GetAllCoordinatorsListVM>>(await _CoordinatorRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.pageSize)
                .ToListAsync());

            List<EduEntitiesCoordinator> CoordinatorsEducationalEntities = await _EduEntitiesCoordinatorRepository
                .Where(x => Coordinators.Select(y => y.Id).Contains(x.CoordinatorId))
                .Include(x => x.EducationalEntity!)
                .ToListAsync();

            Coordinators = Coordinators.Select(x => new GetAllCoordinatorsListVM()
            {
                Id = x.Id,
                ArabicName = x.ArabicName,
                Email = x.Email,
                EnglishName = x.EnglishName,
                PhoneNumber = x.PhoneNumber,
                EducationalEntities = CoordinatorsEducationalEntities.Where(y => y.CoordinatorId == x.Id)
                    .Select(y => new EduEntitiesCoordinatorDto()
                    {
                        Id = y.EducationalEntity!.Id,
                        ArabicName = y.EducationalEntity.ArabicName,
                        EnglishName = y.EducationalEntity.EnglishName
                    }).ToList()
            }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _CoordinatorRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllCoordinatorsListVM>>(ResponseMessage, true, 200, Coordinators, PaginationParameter);
        }
    }
}
