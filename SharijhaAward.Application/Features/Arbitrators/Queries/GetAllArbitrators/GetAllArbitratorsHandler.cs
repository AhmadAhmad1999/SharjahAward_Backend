using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators
{
    public class GetAllArbitratorsHandler : IRequestHandler<GetAllArbitratorsQuery,
        BaseResponse<List<ArbitratorsListVM>>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IMapper _Mapper;
        public GetAllArbitratorsHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IMapper Mapper)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<ArbitratorsListVM>>> Handle(GetAllArbitratorsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };
           
            List<ArbitratorsListVM> Arbitrators = _Mapper.Map<List<ArbitratorsListVM>>(await _ArbitratorRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync());

            List<CategoryArbitrator> CategoryArbitratorEntities = await _CategoryArbitratorRepository
                .Where(x => Arbitrators.Select(y => y.Id).Contains(x.ArbitratorId))
                .OrderByDescending(x => x.CreatedAt)
                .Include(x => x.Category!)
                .ToListAsync();

            Arbitrators = Arbitrators.Select(x => new ArbitratorsListVM()
            {
                Id = x.Id,
                ArabicName = x.ArabicName,
                Email = x.Email,
                EnglishName = x.EnglishName,
                PhoneNumber = x.PhoneNumber,
                isChairman = x.isChairman,
                AtbitratorCategories = CategoryArbitratorEntities.Where(y => y.ArbitratorId == x.Id)
                    .Select(y => new ArbitratorCategoryListVM()
                    {
                        Id = y.CategoryId,
                        ArabicName = y.Category!.ArabicName,
                        EnglishName = y.Category!.EnglishName
                    }).ToList()
            }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _ArbitratorRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<ArbitratorsListVM>>(ResponseMessage, true, 200, Arbitrators, PaginationParameter);
        }
    }
}
