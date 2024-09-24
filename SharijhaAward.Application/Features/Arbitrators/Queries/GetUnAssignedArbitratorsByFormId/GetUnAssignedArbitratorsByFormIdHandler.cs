using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetUnAssignedArbitratorsByFormId
{
    public class GetUnAssignedArbitratorsByFormIdHandler
        : IRequestHandler<GetUnAssignedArbitratorsByFormIdQuery, BaseResponse<List<GetUnAssignedArbitratorsByFormIdListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        public GetUnAssignedArbitratorsByFormIdHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
        }

        public async Task<BaseResponse<List<GetUnAssignedArbitratorsByFormIdListVM>>>
            Handle(GetUnAssignedArbitratorsByFormIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<int> AlreadyAssignedArbitratorsToThisForm = await _ArbitrationRepository
                .Select(x => x.ArbitratorId)
                .ToListAsync();

            List<Arbitrator> Arbitrators = await _ArbitratorRepository
                .WhereThenFilter(x => !AlreadyAssignedArbitratorsToThisForm.Contains(x.Id), FilterObject)
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.perPage)
                .Take(Request.perPage)
                .ToListAsync();

            List<CategoryArbitrator> CategoryArbitratorEntities = await _CategoryArbitratorRepository
                .Where(x => Arbitrators.Select(y => y.Id).Contains(x.ArbitratorId))
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            List<Arbitration> AllArbitrations = await _ArbitrationRepository
                .Where(x => x.ProvidedForm!.PercentCompletion == 100)
                .ToListAsync();

            List<GetUnAssignedArbitratorsByFormIdListVM> ArbitratorsForArbitration = Arbitrators
                .Select(x => new GetUnAssignedArbitratorsByFormIdListVM()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName,
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

            int TotalCount = await _ArbitratorRepository
                .WhereThenFilter(x => !AlreadyAssignedArbitratorsToThisForm.Contains(x.Id), FilterObject)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetUnAssignedArbitratorsByFormIdListVM>>(ResponseMessage, true, 200,
                ArbitratorsForArbitration, PaginationParameter);
        }
    }
}
