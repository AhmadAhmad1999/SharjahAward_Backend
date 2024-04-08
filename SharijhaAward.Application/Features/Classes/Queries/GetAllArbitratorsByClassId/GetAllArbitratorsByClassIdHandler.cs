using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllArbitratorsByClassId
{
    public class GetAllArbitratorsByClassIdHandler : IRequestHandler<GetAllArbitratorsByClassIdQuery,
        BaseResponse<List<GetAllArbitratorsListVM>>>
    {
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IMapper _Mapper;
        public GetAllArbitratorsByClassIdHandler(IAsyncRepository<ArbitratorClass> ArbitratorClassRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IMapper Mapper)
        {
            _ArbitratorClassRepository = ArbitratorClassRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllArbitratorsListVM>>> Handle(GetAllArbitratorsByClassIdQuery Request, 
            CancellationToken cancellationToken)
        {
            List<GetAllArbitratorsListVM> Arbitrators = _Mapper.Map<List<GetAllArbitratorsListVM>>(await _ArbitratorClassRepository
                .Where(x => x.EducationalClassId == Request.EducationalClassId)
                .Include(x => x.Arbitrator!)
                .Select(x => x.Arbitrator!)
                .ToListAsync());

            List<CategoryArbitrator> CategoryArbitratorEntities = await _CategoryArbitratorRepository
                .Where(x => Arbitrators.Select(y => y.Id).Contains(x.ArbitratorId))
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
