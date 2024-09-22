using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetUnAssignedArbitratorsByFormId
{
    public class GetUnAssignedArbitratorsByFormIdHandler 
        : IRequestHandler<GetUnAssignedArbitratorsByFormIdQuery, BaseResponse<List<GetUnAssignedArbitratorsByFormIdListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        public GetUnAssignedArbitratorsByFormIdHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
        }

        public async Task<BaseResponse<List<GetUnAssignedArbitratorsByFormIdListVM>>> 
            Handle(GetUnAssignedArbitratorsByFormIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<int> AlreadyAssignedArbitratorsToThisForm = await _ArbitrationRepository
                .Select(x => x.ArbitratorId)
                .ToListAsync();

            List<GetUnAssignedArbitratorsByFormIdListVM> Arbitrators = await _ArbitratorRepository
                .WhereThenFilter(x => !AlreadyAssignedArbitratorsToThisForm.Contains(x.Id), FilterObject)
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.perPage)
                .Take(Request.perPage)
                .Select(x => new GetUnAssignedArbitratorsByFormIdListVM()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName
                }).ToListAsync();

            int TotalCount = await _ArbitratorRepository
                .WhereThenFilter(x => !AlreadyAssignedArbitratorsToThisForm.Contains(x.Id), FilterObject)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetUnAssignedArbitratorsByFormIdListVM>>(ResponseMessage, true, 200, Arbitrators, PaginationParameter);
        }
    }
}
