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

            int TotalCount = 0;

            List<ArbitrationResult> ArbitrationResultEntities = new List<ArbitrationResult>();

            if (!Request.GetDataRandomly)
            {
                if (Request.CategoryId is not null)
                {
                    TotalCount = await _ArbitrationResultRepository
                        .Include(x => x.ProvidedForm!)
                        .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId.Value &&
                            x.Winner && x.EligibleToWin)
                        .CountAsync();

                    if (Request.page != 0 && Request.PerPage != -1)
                    {
                        ArbitrationResultEntities = await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId.Value &&
                                x.Winner && x.EligibleToWin)
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.PerPage)
                            .Take(Request.PerPage)
                            .Include(x => x.ProvidedForm!.Category!)
                            .Include(x => x.ProvidedForm!.Category!.Cycle!)
                            .ToListAsync();
                    }
                    else
                    {
                        ArbitrationResultEntities = await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId.Value &&
                                x.Winner && x.EligibleToWin)
                            .OrderByDescending(x => x.CreatedAt)
                            .Include(x => x.ProvidedForm!.Category!)
                            .Include(x => x.ProvidedForm!.Category!.Cycle!)
                            .ToListAsync();
                    }
                }
                else
                {
                    TotalCount = await _ArbitrationResultRepository.GetCountAsync(null);

                    if (Request.page != 0 && Request.PerPage != -1)
                    {
                        ArbitrationResultEntities = await _ArbitrationResultRepository
                            .Where(x => x.Winner && x.EligibleToWin)
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.PerPage)
                            .Take(Request.PerPage)
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.Category!)
                            .Include(x => x.ProvidedForm!.Category!.Cycle!)
                            .ToListAsync();
                    }
                    else
                    {
                        ArbitrationResultEntities = await _ArbitrationResultRepository
                            .Where(x => x.Winner && x.EligibleToWin)
                            .OrderByDescending(x => x.CreatedAt)
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.Category!)
                            .Include(x => x.ProvidedForm!.Category!.Cycle!)
                            .ToListAsync();
                    }
                }

                List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                    .Where(x => ArbitrationResultEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                    .ToListAsync();

                List<FinalArbitration> FinalArbitrationEntities = await _FinalArbitrationRepository
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
                        InitialArbitrationScore = ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId),
                        ArbitrationAuditScore = ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId),
                        FinalArbitrationScore = FinalArbitrationEntities
                            .FirstOrDefault(y => y.ProvidedFormId == x.ProvidedFormId)
                                ?.FinalScore ?? 0
                    }).ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.PerPage, TotalCount);

                return new BaseResponse<List<GetAllWinnersDashboardListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
            else
            {
                ArbitrationResultEntities = await _ArbitrationResultRepository
                    .Where(x => x.Winner && x.EligibleToWin)
                    .Include(x => x.ProvidedForm!)
                    .Include(x => x.ProvidedForm!.Category!)
                    .Include(x => x.ProvidedForm!.Category!.Cycle!)
                    .ToListAsync();

                List<DynamicAttributeValue> DynamicAttributeValueEntities = new List<DynamicAttributeValue>();

                if (!string.IsNullOrEmpty(Request.SubscriberName))
                {
                    DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                        .Include(x => x.DynamicAttribute!)
                        .Where(x => ArbitrationResultEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)" &&
                            x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                        .ToListAsync();

                    ArbitrationResultEntities = ArbitrationResultEntities
                        .Where(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId))
                        .ToList();
                }
                else
                {
                    DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                        .Include(x => x.DynamicAttribute!)
                        .Where(x => ArbitrationResultEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                        .ToListAsync();
                }
                
                if (Request.CategoryId is not null)
                {
                    TotalCount = ArbitrationResultEntities.Count();
                    
                    if (Request.page != 0 && Request.PerPage != -1)
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

                        ArbitrationResultEntities = ArbitrationResultEntities
                            .Skip((Request.page - 1) * Request.PerPage)
                            .Take(Request.PerPage)
                            .ToList();
                    }
                    else
                    {
                        ArbitrationResultEntities = ArbitrationResultEntities
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId.Value &&
                                x.Winner && x.EligibleToWin)
                            .ToList();

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
                }
                else
                {
                    TotalCount = await _ArbitrationResultRepository.GetCountAsync(null);

                    if (Request.page != 0 && Request.PerPage != -1)
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

                        ArbitrationResultEntities = ArbitrationResultEntities
                            .Skip((Request.page - 1) * Request.PerPage)
                            .Take(Request.PerPage)
                            .ToList();
                    }
                    else
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
                }

                List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                    .Where(x => ArbitrationResultEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                    .ToListAsync();

                var SubscribersNames = DynamicAttributeValueEntities
                    .Select(x => new
                    {
                        FormId = x.RecordId,
                        SubscriberName = x.Value
                    }).ToList();

                List<FinalArbitration> FinalArbitrationEntities = await _FinalArbitrationRepository
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
                        InitialArbitrationScore = ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId),
                        ArbitrationAuditScore = ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId),
                        FinalArbitrationScore = FinalArbitrationEntities
                            .FirstOrDefault(y => y.ProvidedFormId == x.ProvidedFormId)
                                ?.FinalScore ?? 0,
                        SubscriberName = SubscribersNames
                            .FirstOrDefault(y => y.FormId == x.ProvidedFormId)
                            ? .SubscriberName ?? string.Empty
                    }).ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.PerPage, TotalCount);

                return new BaseResponse<List<GetAllWinnersDashboardListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
        }
    }
}
