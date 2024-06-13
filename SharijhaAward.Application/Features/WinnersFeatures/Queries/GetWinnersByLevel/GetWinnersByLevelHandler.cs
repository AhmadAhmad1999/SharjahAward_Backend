using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Linq;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel
{
    public class GetWinnersByLevelHandler 
        : IRequestHandler<GetWinnersByLevelQuery, BaseResponse<GetWinnersByLevelMainResponse>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public GetWinnersByLevelHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }

        public async Task<BaseResponse<GetWinnersByLevelMainResponse>> 
            Handle(GetWinnersByLevelQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<IGrouping<float, ArbitrationResult>> ArbitrationResultEntities = await _ArbitrationResultRepository
                .Include(x => x.ProvidedForm!)
                .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId &&
                    x.Winner && x.EligibleToWin)
                .OrderByDescending(x => x.FinalArbitration!.FinalScore)
                .Include(x => x.FinalArbitration!)
                .GroupBy(x => x.FinalArbitration!.FinalScore)
                .ToListAsync();

            var DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Where(x => ArbitrationResultEntities.Any(y => y.Select(z => z.ProvidedFormId).Any(y => y == x.RecordId)) &&
                    x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                .Select(x => new
                {
                    FormId = x.RecordId,
                    SubscriberName = x.Value
                }).ToListAsync();

            List<IGrouping<float, ArbitrationResult>> RequestedWinnersList = ArbitrationResultEntities
                .Take(Request.MaxLevelOfWinners)
                .ToList();

            List<GetWinnersByLevelListVM> RequestedWinners = new List<GetWinnersByLevelListVM>();

            foreach (List<ArbitrationResult> RequestedWinner in RequestedWinnersList.Select(x => x.ToList()))
            {
                RequestedWinners.AddRange(RequestedWinner
                    .Select(x => new GetWinnersByLevelListVM()
                    {
                        FormId = x.ProvidedFormId,
                        FinalScore = x.FinalArbitration!.FinalScore,
                        SubscriberName = DynamicAttributeValueEntities
                            .FirstOrDefault(y => y.FormId == x.ProvidedFormId)
                            ? .SubscriberName ?? string.Empty
                    }).ToList());
            }

            int TotalCount = await _ArbitrationResultRepository
                .GetCountAsync(x => !RequestedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId));
            
            List<GetWinnersByLevelListVM> RemainingWinners = await _ArbitrationResultRepository
                .Where(x => !RequestedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId))
                .Skip((Request.page != 0 && Request.PerPage != -1)
                    ? (Request.page - 1) * Request.PerPage
                    : 0)
                .Take((Request.page != 0 && Request.PerPage != -1)
                    ? Request.PerPage
                    : TotalCount)
                .Select(x => new GetWinnersByLevelListVM()
                {
                    FormId = x.ProvidedFormId,
                    FinalScore = x.FinalArbitration!.FinalScore,
                    SubscriberName = DynamicAttributeValueEntities
                        .FirstOrDefault(y => y.FormId == x.ProvidedFormId)!.SubscriberName
                }).ToListAsync();

            GetWinnersByLevelMainResponse Response = new GetWinnersByLevelMainResponse()
            {
                RequestedWinners = RequestedWinners,
                RemainingWinners = RemainingWinners
            };

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.PerPage, TotalCount);

            return new BaseResponse<GetWinnersByLevelMainResponse>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
