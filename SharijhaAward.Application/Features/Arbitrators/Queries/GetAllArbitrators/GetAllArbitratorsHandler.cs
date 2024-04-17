using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators
{
    public class GetAllArbitratorsHandler : IRequestHandler<GetAllArbitratorsQuery,
        BaseResponse<List<GetAllArbitratorsListVM>>>
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
        public async Task<BaseResponse<List<GetAllArbitratorsListVM>>> Handle(GetAllArbitratorsQuery Request, CancellationToken cancellationToken)
        {
            List<GetAllArbitratorsListVM> Arbitrators = _Mapper.Map<List<GetAllArbitratorsListVM>>(await _ArbitratorRepository
                .OrderByDescending(x => x.CreatedAt, Request.page, Request.pageSize)
                .ToListAsync());

            List<CategoryArbitrator> CategoryArbitratorEntities = await _CategoryArbitratorRepository
                .Where(x => Arbitrators.Select(y => y.Id).Contains(x.ArbitratorId))
                .OrderByDescending(x => x.CreatedAt)
                .Include(x => x.Category!)
                .ToListAsync();

            Arbitrators = Arbitrators.Select(x => new GetAllArbitratorsListVM()
            {
                Id = x.Id,
                ArabicName = x.ArabicName,
                Email = x.Email,
                EnglishName = x.EnglishName,
                PhoneNumber = x.PhoneNumber,
                AtbitratorCategories = CategoryArbitratorEntities.Where(y => y.ArbitratorId == x.Id)
                    .Select(y => new ArbitratorCategoryListVM()
                    {
                        Id = y.Id,
                        ArabicName = y.Category!.ArabicName,
                        EnglishName = y.Category!.EnglishName
                    }).ToList()
            }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _ArbitratorRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllArbitratorsListVM>>(ResponseMessage, true, 200, Arbitrators, PaginationParameter);
        }
    }
}
