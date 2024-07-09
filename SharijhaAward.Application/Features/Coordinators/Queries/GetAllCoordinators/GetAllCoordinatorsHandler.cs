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
        BaseResponse<List<CoordinatorsListVM>>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IMapper _Mapper;

        public GetAllCoordinatorsHandler(
            IAsyncRepository<Coordinator> CoordinatorRepository,
            IMapper Mapper)
        {
            _CoordinatorRepository = CoordinatorRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<CoordinatorsListVM>>> Handle(GetAllCoordinatorsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };
            List<CoordinatorsListVM> Coordinators = _Mapper.Map<List<CoordinatorsListVM>>(await _CoordinatorRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync());

            Coordinators = Coordinators.Select(x => new CoordinatorsListVM()
            {
                Id = x.Id,
                ArabicName = x.ArabicName,
                Email = x.Email,
                EnglishName = x.EnglishName,
                PhoneNumber = x.PhoneNumber
            }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _CoordinatorRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<CoordinatorsListVM>>(ResponseMessage, true, 200, Coordinators, PaginationParameter);
        }
    }
}
