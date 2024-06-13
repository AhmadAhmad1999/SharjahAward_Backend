using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite
{
    public class GetAllWinnersForWebsiteHandler 
        : IRequestHandler<GetAllWinnersForWebsiteQuery, BaseResponse<List<GetAllWinnersForWebsiteMainResponse>>>
    {
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public GetAllWinnersForWebsiteHandler(IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }

        public async Task<BaseResponse<List<GetAllWinnersForWebsiteMainResponse>>> 
            Handle(GetAllWinnersForWebsiteQuery Request, CancellationToken cancellationToken)
        {
            List<IGrouping<Category, ArbitrationResult>> WinnersEntities = await _ArbitrationResultRepository
                .Include(x => x.ProvidedForm!)
                .Include(x => x.ProvidedForm!.Category!)
                .Where(x => x.ProvidedForm!.Category!.CycleId == Request.CycleId &&
                    x.Winner && x.WinningLevel != null && x.WinningDate != null)
                .Include(x => x.ProvidedForm!.CategoryEducationalEntity!)
                .Include(x => x.ProvidedForm!.CategoryEducationalEntity!.EducationalEntity!)
                .GroupBy(x => x.ProvidedForm!.Category!)
                .ToListAsync();

            var DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Where(x => WinnersEntities.Any(y => y.Select(z => z.ProvidedFormId).Any(y => y == x.RecordId)) &&
                    x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                .Select(x => new
                {
                    FormId = x.RecordId,
                    SubscriberName = x.Value
                }).ToListAsync();

            List<GetAllWinnersForWebsiteMainResponse> FinalResponse = new List<GetAllWinnersForWebsiteMainResponse>();

            foreach (IGrouping<Category, ArbitrationResult> WinnersEntity in WinnersEntities)
            {
                FinalResponse.Add(new GetAllWinnersForWebsiteMainResponse()
                {
                    CategoryId = WinnersEntity.Key.Id,
                    CategoryName = Request.lang == "en"
                        ? WinnersEntity.Key.EnglishName
                        : WinnersEntity.Key.ArabicName,
                    Winners = WinnersEntity
                        .Select(x => new GetAllWinnersForWebsiteListVM()
                        {
                            FormId = x.ProvidedFormId,
                            WinningLevel = x.WinningLevel!.Value,
                            SubscriberName = DynamicAttributeValueEntities
                                .FirstOrDefault(y => y.FormId == x.ProvidedFormId)
                                ?.SubscriberName ?? string.Empty,
                            EducationalEntityName = x.ProvidedForm!.CategoryEducationalEntityId != null
                                ? (Request.lang == "en"
                                    ? x.ProvidedForm!.CategoryEducationalEntity!.EducationalEntity!.EnglishName
                                    : x.ProvidedForm!.CategoryEducationalEntity!.EducationalEntity!.EnglishName)
                                : null
                        }).ToList()
                });
            }

            return new BaseResponse<List<GetAllWinnersForWebsiteMainResponse>>(string.Empty, true, 200, FinalResponse);
        }
    }
}
