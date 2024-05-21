using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFormsForFinalArbitration
{
    public class GetAllFormsForFinalArbitrationHandler
        : IRequestHandler<GetAllFormsForFinalArbitrationQuery, BaseResponse<GetAllFormsForFinalArbitrationMainListVM>>
    {
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;

        public GetAllFormsForFinalArbitrationHandler(IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }
        public async Task<BaseResponse<GetAllFormsForFinalArbitrationMainListVM>>
            Handle(GetAllFormsForFinalArbitrationQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<FinalArbitration> FinalArbitrationEntities = new List<FinalArbitration>();

            int TotalCount = 0;

            if (Request.ArbitrationType is not null)
            {
                FinalArbitrationEntities = await _FinalArbitrationRepository
                    .Where(x => x.Type == Request.ArbitrationType)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .Include(x => x.ProvidedForm!)
                    .Include(x => x.ProvidedForm!.Category!)
                    .ToListAsync();

                TotalCount = await _FinalArbitrationRepository
                    .GetCountAsync(x => x.Type == Request.ArbitrationType);
            }
            else
            {
                FinalArbitrationEntities = await _FinalArbitrationRepository
                    .OrderByDescending(x => x.CreatedAt, Request.page, Request.pageSize)
                    .Include(x => x.ProvidedForm!)
                    .Include(x => x.ProvidedForm!.Category!)
                    .ToListAsync();

                TotalCount = await _FinalArbitrationRepository
                    .GetCountAsync(null);
            }
            
            var Names = await _DynamicAttributeValueRepository
                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId))
                .Select(x => new
                {
                    x.RecordId,
                    x.Value
                }).ToListAsync();

            List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                .Select(x => new GetAllFormsForFinalArbitrationListVM()
                {
                    FormId = x.ProvidedFormId,
                    Name = Names.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
                    CategoryId = x.ProvidedForm!.categoryId,
                    CategoryName = Request.lang == "en"
                        ? x.ProvidedForm!.Category!.EnglishName
                        : x.ProvidedForm!.Category!.ArabicName,
                    FinalScore = x.FinalScore
                }).ToList();

            Dictionary<ArbitrationType, int> TypeCounts = await _FinalArbitrationRepository
                .Where(x => true)
                .GroupBy(x => x.Type)
                .Select(x => new { Type = x.Key, Count = x.Count() })
                .ToDictionaryAsync(x => x.Type, x => x.Count);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            GetAllFormsForFinalArbitrationMainListVM Response = new GetAllFormsForFinalArbitrationMainListVM()
            {
                GetAllFormsForFinalArbitrationListVM = GetAllFormsForFinalArbitrationListVM,
                CountOfNotBeenArbitrated = TypeCounts.GetValueOrDefault(ArbitrationType.NotBeenArbitrated),
                CountOfBeingReviewed = TypeCounts.GetValueOrDefault(ArbitrationType.BeingReviewed),
                CountOfDoneArbitratod = TypeCounts.GetValueOrDefault(ArbitrationType.DoneArbitratod)
            };

            return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, true, 200,
                Response, PaginationParameter);
        }
    }
}
