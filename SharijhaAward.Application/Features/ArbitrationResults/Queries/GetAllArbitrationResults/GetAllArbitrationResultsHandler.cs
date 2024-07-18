using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults
{
    public class GetAllArbitrationResultsHandler
        : IRequestHandler<GetAllArbitrationResultsQuery, BaseResponse<List<GetAllArbitrationResultsListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;

        public GetAllArbitrationResultsHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }
        public async Task<BaseResponse<List<GetAllArbitrationResultsListVM>>> 
            Handle(GetAllArbitrationResultsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int TotalCount = 0;

            List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Where(x => x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)" &&
                    (!string.IsNullOrEmpty(Request.SubscriberName)
                        ? x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower())
                        : true))
                .ToListAsync();

            List<ArbitrationResult> ArbitrationResultEntities = new List<ArbitrationResult>();

            if (Request.CategoryId is not null)
            {
                TotalCount = await _ArbitrationResultRepository
                    .Include(x => x.ProvidedForm!)
                    .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId.Value)
                    .CountAsync();

                if (Request.page != 0 && Request.PerPage != -1)
                {
                    ArbitrationResultEntities = await _ArbitrationResultRepository
                        .Include(x => x.ProvidedForm!)
                        .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId.Value &&
                            DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.PerPage)
                        .Take(Request.PerPage)
                        .Include(x => x.ProvidedForm!.Category!)
                        .Include(x => x.ProvidedForm!.Category!.Cycle!)
                        .Include(x => x.FinalArbitration!)
                        .ToListAsync();
                }
                else
                {
                    ArbitrationResultEntities = await _ArbitrationResultRepository
                        .Include(x => x.ProvidedForm!)
                        .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId.Value &&
                            DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId))
                        .OrderByDescending(x => x.CreatedAt)
                        .Include(x => x.ProvidedForm!.Category!)
                        .Include(x => x.ProvidedForm!.Category!.Cycle!)
                        .Include(x => x.FinalArbitration!)
                        .ToListAsync();
                }
            }
            else
            {
                TotalCount = await _ArbitrationResultRepository.GetCountAsync(null);

                if (Request.page != 0 && Request.PerPage != -1)
                {
                    ArbitrationResultEntities = await _ArbitrationResultRepository
                        .Where(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.PerPage)
                        .Take(Request.PerPage)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .Include(x => x.ProvidedForm!.Category!.Cycle!)
                        .Include(x => x.FinalArbitration!)
                        .ToListAsync();
                }
                else
                {
                    ArbitrationResultEntities = await _ArbitrationResultRepository
                        .Where(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId))
                        .OrderByDescending(x => x.CreatedAt)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .Include(x => x.ProvidedForm!.Category!.Cycle!)
                        .Include(x => x.FinalArbitration!)
                        .ToListAsync();
                }
            }

            var SubscribersNames = DynamicAttributeValueEntities
                .Select(x => new
                {
                    FormId = x.RecordId,
                    SubscriberName = x.Value
                }).ToList();

            List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                .Where(x => ArbitrationResultEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                .ToListAsync();

            List<FinalArbitration> FinalArbitrationEntities = ArbitrationResultEntities
                .Select(x => x.FinalArbitration!)
                .ToList();
            
            List<GetAllArbitrationResultsListVM> Response = ArbitrationResultEntities
                .Select(x => new GetAllArbitrationResultsListVM()
                {
                    FormId = x.ProvidedFormId,
                    CategoryId = x.ProvidedForm!.categoryId,
                    CategoryName = Request.lang == "en"
                        ? x.ProvidedForm!.Category!.EnglishName
                        : x.ProvidedForm!.Category!.ArabicName,
                    InitialArbitrationScoreDto = ArbitrationEntities
                        .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                        .Select(y => new InitialArbitrationScoreDto()
                        {
                            InitialArbitrationScore = y.FullScore
                        }).ToList(),
                    ArbitrationAuditScore = ArbitrationEntities
                        .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                        .Select(y => y.FullScore)
                        .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId),
                    FinalArbitrationScore = FinalArbitrationEntities
                        .FirstOrDefault(y => y.ProvidedFormId == x.ProvidedFormId)
                            ?.FinalScore ?? 0,
                    EligibleForCertification = x.EligibleForCertification,
                    EligibleForAStatement = x.EligibleForAStatement,
                    EligibleToWin = x.EligibleToWin,
                    GotCertification = x.GotCertification,
                    GotStatement = x.GotStatement,
                    Winner = x.Winner,
                    DateOfObtainingTheCertificate = x.DateOfObtainingTheCertificate,
                    DateOfObtainingTheStatement = x.DateOfObtainingTheStatement,
                    WinningDate = x.WinningDate,
                    SubscriberName = SubscribersNames
                        .FirstOrDefault(y => y.FormId == x.ProvidedFormId)
                            ?.SubscriberName ?? string.Empty,
                    CycleNumber = x.ProvidedForm!.CycleNumber,
                    CycleYear = x.ProvidedForm!.CycleYear
                }).ToList();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.PerPage, TotalCount);

            return new BaseResponse<List<GetAllArbitrationResultsListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
