using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Security.Cryptography;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersDashboard
{
    public class GetAllWinnersDashboardHandler 
        : IRequestHandler<GetAllWinnersDashboardQuery, BaseResponse<List<GetAllWinnersDashboardListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public GetAllWinnersDashboardHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }

        public async Task<BaseResponse<List<GetAllWinnersDashboardListVM>>> 
            Handle(GetAllWinnersDashboardQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Where(x => x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)" &&
                    (!string.IsNullOrEmpty(Request.SubscriberName)
                        ? x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower())
                        : true))
                .ToListAsync();

            List<ArbitrationResult> ArbitrationResultEntities = await _ArbitrationResultRepository
                .Include(x => x.ProvidedForm!)
                .Where(x => x.Winner && x.EligibleToWin &&
                    (Request.CategoryId != null
                        ? x.ProvidedForm!.categoryId == Request.CategoryId.Value
                        : true) &&
                    (Request.CycleYear != null
                        ? x.ProvidedForm!.CycleYear == Request.CycleYear
                        : true) &&
                    (Request.CycleNumber != null
                        ? x.ProvidedForm!.CycleNumber == Request.CycleNumber
                        : true) &&
                    (DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId)))
                .Include(x => x.ProvidedForm!.User!)
                .Include(x => x.ProvidedForm!.Category!)
                .Include(x => x.ProvidedForm!.Category!.Cycle!)
                .Include(x => x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!)
                .Include(x => x.ProvidedForm!.CategoryEducationalEntity!.EducationalEntity!)
                .Include(x => x.FinalArbitration!)
                .ToListAsync();

            int TotalCount = ArbitrationResultEntities.Count();

            if (Request.GetDataRandomly)
            {
                // Shuffle the data randomly
                using (RandomNumberGenerator RandomNumberGenerator = RandomNumberGenerator.Create())
                {
                    int TotelRows = ArbitrationResultEntities.Count;
                    while (TotelRows > 1)
                    {
                        byte[] buffer = new byte[4];
                        RandomNumberGenerator.GetBytes(buffer);
                        int k = BitConverter.ToInt32(buffer, 0) % TotelRows;
                        TotelRows--;
                        ArbitrationResultEntities[TotelRows] = ArbitrationResultEntities[k];
                        ArbitrationResultEntities[k] = ArbitrationResultEntities[TotelRows];
                    }
                }
            }

            if (Request.page != 0 && Request.PerPage != -1)
            {
                ArbitrationResultEntities = ArbitrationResultEntities
                    .Skip((Request.page - 1) * Request.PerPage)
                    .Take(Request.PerPage)
                    .ToList();
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

            List<GetAllWinnersDashboardListVM> Response = ArbitrationResultEntities
                .Select(x => new GetAllWinnersDashboardListVM()
                {
                    FormId = x.ProvidedFormId,
                    CategoryId = x.ProvidedForm!.categoryId,
                    CategoryName = Request.lang == "en"
                        ? x.ProvidedForm!.Category!.EnglishName
                        : x.ProvidedForm!.Category!.ArabicName,
                    InitialArbitrationScore = (ArbitrationEntities.Any() && ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                        ? (ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId))
                        : 0,
                    ArbitrationAuditScore = (ArbitrationEntities.Any() && ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                        ? (ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId))
                        : 0,
                    FinalArbitrationScore = x.FinalArbitration! ?.FinalScore ?? 0,
                    SubscriberName = SubscribersNames
                        .FirstOrDefault(y => y.FormId == x.ProvidedFormId)
                            ?.SubscriberName ?? string.Empty,
                    CycleNumber = x.ProvidedForm!.CycleNumber,
                    CycleYear = x.ProvidedForm!.CycleYear,
                    EducationalClassName = Request.lang == "en"
                        ? x.ProvidedForm!.CategoryEducationalClass? .EducationalClass!.EnglishName ?? null
                        : x.ProvidedForm!.CategoryEducationalClass? .EducationalClass!.ArabicName ?? null,
                    EducationalEntityName = Request.lang == "en"
                        ? x.ProvidedForm!.CategoryEducationalEntity? .EducationalEntity!.EnglishName ?? null
                        : x.ProvidedForm!.CategoryEducationalEntity? .EducationalEntity!.ArabicName ?? null,
                    ProfilePhoto = x.ProvidedForm!.User.ImageURL,
                    Gender = x.ProvidedForm!.User.Gender,
                    WinningLevel = x.WinningLevel!.Value
                }).ToList();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.PerPage, TotalCount);

            return new BaseResponse<List<GetAllWinnersDashboardListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
