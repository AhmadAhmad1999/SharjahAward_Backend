using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllArbitratorsForArbitration
{
    public class GetAllArbitratorsForArbitrationHandler : IRequestHandler<GetAllArbitratorsForArbitrationQuery,
        BaseResponse<List<GetAllArbitratorsForArbitrationListVM>>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        public GetAllArbitratorsForArbitrationHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _ArbitrationRepository = ArbitrationRepository;
        }

        public async Task<BaseResponse<List<GetAllArbitratorsForArbitrationListVM>>> 
            Handle(GetAllArbitratorsForArbitrationQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            List<Arbitrator> Arbitrators = await _ArbitratorRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync();

            List<CategoryArbitrator> CategoryArbitratorEntities = await _CategoryArbitratorRepository
                .Where(x => Arbitrators.Select(y => y.Id).Contains(x.ArbitratorId))
                .OrderByDescending(x => x.CreatedAt)
                .Include(x => x.Category!)
                .ToListAsync();

            List<Arbitration> AllArbitrations = await _ArbitrationRepository
                .Include(x => x.ProvidedForm!)
                .Where(x => x.ProvidedForm!.PercentCompletion == 100)
                .ToListAsync();

            List<GetAllArbitratorsForArbitrationListVM> ArbitratorsForArbitration = Arbitrators
                .Select(x => new GetAllArbitratorsForArbitrationListVM()
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
                        }).ToList(),
                    NumberOfAcceptedAssignedForms = AllArbitrations.Where(y => y.ArbitratorId == x.Id && 
                        y.isAccepted == FormStatus.Accepted).Count(),
                    NumberOfRejectedAssignedForms = AllArbitrations.Where(y => y.ArbitratorId == x.Id &&
                        y.isAccepted == FormStatus.Rejected).Count()
                }).ToList();

            string ResponseMessage = string.Empty;

            int TotalCount = await _ArbitratorRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllArbitratorsForArbitrationListVM>>(ResponseMessage, true, 200,
                ArbitratorsForArbitration, PaginationParameter);
        }
    }
}
