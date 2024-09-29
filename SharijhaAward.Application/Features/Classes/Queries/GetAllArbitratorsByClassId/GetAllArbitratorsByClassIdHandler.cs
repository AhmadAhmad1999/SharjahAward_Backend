using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllArbitratorsByClassId
{
    public class GetAllArbitratorsByClassIdHandler : IRequestHandler<GetAllArbitratorsByClassIdQuery,
        BaseResponse<List<ArbitratorsListVM>>>
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

        public async Task<BaseResponse<List<ArbitratorsListVM>>> Handle(GetAllArbitratorsByClassIdQuery Request, 
            CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            List<Arbitrator> ArbitratorClassesEntities = new List<Arbitrator>();
            
            if (Request.page != 0 && Request.perPage != -1)
                ArbitratorClassesEntities = await _ArbitratorClassRepository
                    .WhereThenFilter(x => x.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId, filterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .Select(x => x.Arbitrator!)
                    .ToListAsync();
            else
                ArbitratorClassesEntities = await _ArbitratorClassRepository
                    .WhereThenFilter(x => x.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId, filterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => x.Arbitrator!)
                    .ToListAsync();

            List<ArbitratorsListVM> Arbitrators = _Mapper.Map<List<ArbitratorsListVM>>(ArbitratorClassesEntities);

            List<CategoryArbitrator> CategoryArbitratorEntities = await _CategoryArbitratorRepository
                .Where(x => Arbitrators.Select(y => y.Id).Contains(x.ArbitratorId))
                .ToListAsync();

            Arbitrators = Arbitrators.Select(x => new ArbitratorsListVM()
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

            int TotalCount = await _ArbitratorRepository.WhereThenFilter(a=>true, filterObject).CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<ArbitratorsListVM>>(ResponseMessage, true, 200, Arbitrators, PaginationParameter);
        }
    }
}
