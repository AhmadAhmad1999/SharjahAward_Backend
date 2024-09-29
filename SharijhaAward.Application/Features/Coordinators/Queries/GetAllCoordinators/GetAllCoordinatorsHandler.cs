using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using System.Collections.Generic;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators
{
    public class GetAllCoordinatorsHandler : IRequestHandler<GetAllCoordinatorsQuery,
        BaseResponse<List<CoordinatorsListVM>>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IMapper _Mapper;

        public GetAllCoordinatorsHandler(
            IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IMapper Mapper)
        {
            _CoordinatorRepository = CoordinatorRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<CoordinatorsListVM>>> Handle(GetAllCoordinatorsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            List<CoordinatorsListVM> Coordinators = _Mapper.Map<List<CoordinatorsListVM>>(await _CoordinatorRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync());

            List<EduEntitiesCoordinator> EduEntitiesCoordinatorEntities = await _EduEntitiesCoordinatorRepository
                .Where(x => Coordinators.Select(y => y.Id).Contains(x.CoordinatorId))
                .ToListAsync();

            if(Request.EducationalEntityId != null)
            {
                Coordinators = _Mapper.Map <List<CoordinatorsListVM>>(await _EduEntitiesCoordinatorRepository
                    .WhereThenFilter(e => e.EducationalEntityId == Request.EducationalEntityId, filterObject)
                    .Select(e => e.Coordinator)
                    .ToListAsync());
            }

            Coordinators = Coordinators.Select(x => new CoordinatorsListVM()
            {
                Id = x.Id,
                ArabicName = x.ArabicName,
                Email = x.Email,
                EnglishName = x.EnglishName,
                PhoneNumber = x.PhoneNumber,
                EducationalEntities = EduEntitiesCoordinatorEntities
                    .Where(y => y.CoordinatorId == x.Id)
                    .Select(y => new CoordinatorEducationalEntitiesDto()
                    {
                        Id = y.Id,
                        Name = Request.lang == "en"
                            ? y.EducationalEntity!.EnglishName
                            : y.EducationalEntity!.ArabicName
                    }).ToList()
            }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _CoordinatorRepository.WhereThenFilter(a => true, filterObject).CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<CoordinatorsListVM>>(ResponseMessage, true, 200, Coordinators, PaginationParameter);
        }
    }
}
