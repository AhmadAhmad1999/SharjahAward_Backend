using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite
{
    public class GetAllWinnersForWebsiteHandler 
        : IRequestHandler<GetAllWinnersForWebsiteQuery, BaseResponse<List<GetAllWinnersForWebsiteMainResponse>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public GetAllWinnersForWebsiteHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
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
                .Include(x => x.FinalArbitration!)
                .Include(x => x.ProvidedForm!.User!)
                .GroupBy(x => x.ProvidedForm!.Category!)
                .ToListAsync();

            List<int> ProvidedFormsIds = WinnersEntities
                .SelectMany(group => group.Select(result => result))
                .Select(x => x.ProvidedFormId)
                .ToList();

            List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                .Where(x => ProvidedFormsIds.Contains(x.ProvidedFormId))
                .ToListAsync();

            var DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Where(x => ProvidedFormsIds.Any(y => y == x.RecordId) &&
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
                    MainCateogryId = WinnersEntity.Key.ParentId != null
                        ? WinnersEntity.Key.ParentId.Value : 0,
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
                                : null,
                            InitialArbitrationScore = ArbitrationEntities
                                .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                .Select(y => y.FullScore)
                                .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId),
                            ArbitrationAuditScore = ArbitrationEntities
                                .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                .Select(y => y.FullScore)
                                .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId),
                            FinalArbitrationScore = x.FinalArbitration! ?.FinalScore ?? 0,
                            CycleNumber = x.ProvidedForm!.CycleNumber,
                            CycleYear = x.ProvidedForm!.CycleYear,
                            EducationalClassName = Request.lang == "en"
                                ? x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.EnglishName ?? null
                                : x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.ArabicName ?? null,
                            ProfilePhoto = x.ProvidedForm!.User.ImageURL,
                            Gender = x.ProvidedForm!.User.Gender,
                            CategoryId = WinnersEntity.Key.Id,
                            CategoryName = Request.lang == "en"
                                ? WinnersEntity.Key.EnglishName
                                : WinnersEntity.Key.ArabicName,
                        }).ToList()
                });
            }

            return new BaseResponse<List<GetAllWinnersForWebsiteMainResponse>>(string.Empty, true, 200, FinalResponse);
        }
    }
}
