using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults
{
    public class GetAllArbitrationResultsHandler
        : IRequestHandler<GetAllArbitrationResultsQuery, BaseResponse<List<GetAllArbitrationResultsListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetAllArbitrationResultsHandler(IAsyncRepository<Arbitration> _ArbitrationRepository,
            IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository,
            IJwtProvider _JwtProvider)
        {
            this._ArbitrationRepository = _ArbitrationRepository;
            this._ArbitrationResultRepository = _ArbitrationResultRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._CycleRepository = _CycleRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._ArbitrationAuditRepository = _ArbitrationAuditRepository;
            this._JwtProvider = _JwtProvider;

        }
        public async Task<BaseResponse<List<GetAllArbitrationResultsListVM>>> 
            Handle(GetAllArbitrationResultsQuery Request, CancellationToken cancellationToken)
        {
            bool? EligibleForCertification = null;
            bool? EligibleForAStatement1 = null;
            bool? EligibleForAStatement2 = null;

            if (Request.EligableFilter is not null)
            {
                if (Request.EligableFilter == EligableFilter.EligibleForCertification)
                {
                    EligibleForCertification = true;
                }
                else if (Request.EligableFilter == EligableFilter.NotEligibleForCertification)
                {
                    EligibleForCertification = false;
                }
                else if(Request.EligableFilter == EligableFilter.EligibleForAStatement1)
                {
                    EligibleForAStatement1 = true;
                }
                else if (Request.EligableFilter == EligableFilter.NotEligibleForAStatement1)
                {
                    EligibleForAStatement1 = false;
                }
                else if(Request.EligableFilter == EligableFilter.EligibleForAStatement2)
                {
                    EligibleForAStatement2 = true;
                }
                else if (Request.EligableFilter == EligableFilter.NotEligibleForAStatement2)
                {
                    EligibleForAStatement2 = false;
                }
            }

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            UserRole? CheckIfUserHaveFullAccess = await _UserRoleRepository
                .FirstOrDefaultAsync(x => x.UserId == UserId &&
                    x.Role!.HaveFullAccess);

            if (CheckIfUserHaveFullAccess is not null)
            {
                List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)" &&
                        (!string.IsNullOrEmpty(Request.SubscriberName)
                            ? x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower())
                            : true))
                    .ToListAsync();

                List<ArbitrationResult> ArbitrationResultEntities = new List<ArbitrationResult>();

                int TotalCount = _ArbitrationResultRepository
                    .WhereThenFilter(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId) &&
                        (Request.CategoryId != null
                            ? x.ProvidedForm!.categoryId == Request.CategoryId.Value
                            : true) &&
                        (Request.CycleNumber != null
                            ? x.ProvidedForm!.CycleNumber == Request.CycleNumber
                            : true) &&
                        (!string.IsNullOrEmpty(Request.CategoryName)
                            ? (Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName.ToLower().StartsWith(Request.CategoryName.ToLower())
                                : x.ProvidedForm!.Category!.ArabicName.ToLower().StartsWith(Request.CategoryName.ToLower()))
                            : true) &&
                        (Request.EligibleToWin != null
                            ? x.EligibleToWin == Request.EligibleToWin
                            : true) &&
                        (Request.EligableFilter != null
                            ? (EligibleForCertification != null
                                ? (x.EligibleForCertification == EligibleForCertification)
                                : (EligibleForAStatement1 != null
                                    ? (EligibleForAStatement1.Value
                                        ? x.FinalArbitrationId == null
                                        : x.FinalArbitrationId != null)
                                    : (x.EligibleForAStatement == EligibleForAStatement2)))
                            : true), FilterObject)
                    .AsEnumerable()
                    .DistinctBy(x => x.ProvidedFormId)
                    .AsEnumerable()
                    .Count();

                if (Request.page != 0 && Request.PerPage != -1)
                {
                    ArbitrationResultEntities = _ArbitrationResultRepository
                        .WhereThenFilter(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId) &&
                            (Request.CategoryId != null
                                ? x.ProvidedForm!.categoryId == Request.CategoryId.Value
                                : true) &&
                            (Request.CycleNumber != null
                                ? x.ProvidedForm!.CycleNumber == Request.CycleNumber
                                : true) &&
                            (!string.IsNullOrEmpty(Request.CategoryName)
                                ? (Request.lang == "en"
                                    ? x.ProvidedForm!.Category!.EnglishName.ToLower().StartsWith(Request.CategoryName.ToLower())
                                    : x.ProvidedForm!.Category!.ArabicName.ToLower().StartsWith(Request.CategoryName.ToLower()))
                                : true) &&
                            (Request.EligibleToWin != null
                                ? x.EligibleToWin == Request.EligibleToWin
                                : true) &&
                            (Request.EligableFilter != null
                                ? (EligibleForCertification != null
                                    ? (x.EligibleForCertification == EligibleForCertification)
                                    : (EligibleForAStatement1 != null
                                        ? (EligibleForAStatement1.Value
                                            ? x.FinalArbitrationId == null
                                            : x.FinalArbitrationId != null)
                                        : (x.EligibleForAStatement == EligibleForAStatement2)))
                                : true), FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .AsEnumerable()
                        .DistinctBy(x => x.ProvidedFormId)
                        .AsEnumerable()
                        .Skip((Request.page - 1) * Request.PerPage)
                        .Take(Request.PerPage)
                        .ToList();
                }
                else
                {
                    ArbitrationResultEntities = _ArbitrationResultRepository
                        .WhereThenFilter(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId) &&
                            (Request.CategoryId != null
                                ? x.ProvidedForm!.categoryId == Request.CategoryId.Value
                                : true) &&
                            (Request.CycleNumber != null
                                ? x.ProvidedForm!.CycleNumber == Request.CycleNumber
                                : true) &&
                            (!string.IsNullOrEmpty(Request.CategoryName)
                                ? (Request.lang == "en"
                                    ? x.ProvidedForm!.Category!.EnglishName.ToLower().StartsWith(Request.CategoryName.ToLower())
                                    : x.ProvidedForm!.Category!.ArabicName.ToLower().StartsWith(Request.CategoryName.ToLower()))
                                : true) &&
                            (Request.EligibleToWin != null
                                ? x.EligibleToWin == Request.EligibleToWin
                                : true) &&
                            (Request.EligableFilter != null
                                ? (EligibleForCertification != null
                                    ? (x.EligibleForCertification == EligibleForCertification)
                                    : (EligibleForAStatement1 != null
                                        ? (EligibleForAStatement1.Value
                                            ? x.FinalArbitrationId == null
                                            : x.FinalArbitrationId != null)
                                        : (x.EligibleForAStatement == EligibleForAStatement2)))
                                : true), FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .AsEnumerable()
                        .DistinctBy(x => x.ProvidedFormId)
                        .AsEnumerable()
                        .ToList();
                }

                var SubscribersNames = DynamicAttributeValueEntities
                    .Select(x => new
                    {
                        FormId = x.RecordId,
                        SubscriberName = x.Value
                    }).ToList();

                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntities = await _ArbitrationRepository
                    .Where(x => ArbitrationResultEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId) &&
                        x.isAcceptedFromChairman == FormStatus.Accepted)
                    .GroupBy(x => x.ProvidedFormId)
                    .ToListAsync();

                List<Arbitration> ArbitrationEntities = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration))
                    .ToList();

                List<int> FormsIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.ProvidedFormId))
                    .Distinct()
                    .ToList();

                List<ArbitrationAudit> ArbitrationAuditEntities = await _ArbitrationAuditRepository
                    .Where(x => FormsIds.Contains(x.ProvidedFormId))
                    .ToListAsync();

                List<FinalArbitration> FinalArbitrationEntities = ArbitrationResultEntities
                    .Where(x => x.FinalArbitrationId != null)
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
                        CategoryContainStatement1 = x.ProvidedForm!.Category!.ContainStatment1,
                        CategoryContainStatement2 = (x.ProvidedForm!.Category!.MinimumAmountToObtainAStatement2 == null ||
                            x.ProvidedForm!.Category!.MaximumAmountToObtainAStatement2 == null)
                                ? false : true,
                        CategoryContainCertificate = (x.ProvidedForm!.Category!.MinimumRequirementToObtainACertificate == null ||
                            x.ProvidedForm!.Category!.MaximumRequirementToObtainACertificate == null)
                                ? false : true,
                        InitialArbitrationScoreDto = ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => new InitialArbitrationScoreDto()
                            {
                                InitialArbitrationScore = y.FullScore
                            }).ToList(),
                        ArbitrationAuditScore = ArbitrationAuditEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Sum(y => y.ArbitrationScore),
                        FinalArbitrationScore = FinalArbitrationEntities
                            .FirstOrDefault(y => y.ProvidedFormId == x.ProvidedFormId)
                                ?.FinalScore ?? 0,
                        EligibleForCertification = x.EligibleForCertification,
                        EligibleForAStatement1 = FinalArbitrationEntities
                            .Any(y => y.ProvidedFormId == x.ProvidedFormId)
                                ? false : true,
                        EligibleForAStatement2 = x.EligibleForAStatement,
                        EligibleToWin = x.EligibleToWin,
                        GotCertification = x.GotCertification,
                        GotStatement1 = x.GotStatement1,
                        GotStatement2 = x.GotStatement2,
                        Winner = x.Winner,
                        DateOfObtainingTheCertificate = x.DateOfObtainingTheCertificate,
                        DateOfObtainingTheStatement1 = x.DateOfObtainingTheStatement1,
                        DateOfObtainingTheStatement2 = x.DateOfObtainingTheStatement2,
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
            else
            {
                Cycle? ActiveCycleEntity = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (ActiveCycleEntity is null)
                    return new BaseResponse<List<GetAllArbitrationResultsListVM>>(ResponseMessage, true, 200);

                int ActiveCycleEntityId = ActiveCycleEntity.Id;

                List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)" &&
                        (!string.IsNullOrEmpty(Request.SubscriberName)
                            ? x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower())
                            : true))
                    .ToListAsync();

                List<ArbitrationResult> ArbitrationResultEntities = new List<ArbitrationResult>();

                int TotalCount = _ArbitrationResultRepository
                    .WhereThenFilter(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId) &&
                        (Request.CategoryId != null
                            ? x.ProvidedForm!.categoryId == Request.CategoryId.Value
                            : true) &&
                        (Request.CycleNumber != null
                            ? x.ProvidedForm!.CycleNumber == Request.CycleNumber
                            : true) &&
                        (!string.IsNullOrEmpty(Request.CategoryName)
                            ? (Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName.ToLower().StartsWith(Request.CategoryName.ToLower())
                                : x.ProvidedForm!.Category!.ArabicName.ToLower().StartsWith(Request.CategoryName.ToLower()))
                            : true) &&
                        (Request.EligibleToWin != null
                            ? x.EligibleToWin == Request.EligibleToWin
                            : true) &&
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleEntityId &&
                        (Request.EligableFilter != null
                            ? (EligibleForCertification != null
                                ? (x.EligibleForCertification == EligibleForCertification)
                                : (EligibleForAStatement1 != null
                                    ? (EligibleForAStatement1.Value
                                        ? x.FinalArbitrationId == null
                                        : x.FinalArbitrationId != null)
                                    : (x.EligibleForAStatement == EligibleForAStatement2)))
                            : true), FilterObject)
                    .AsEnumerable()
                    .DistinctBy(x => x.ProvidedFormId)
                    .AsEnumerable()
                    .Count();

                if (Request.page != 0 && Request.PerPage != -1)
                {
                    ArbitrationResultEntities = _ArbitrationResultRepository
                        .Where(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId) &&
                            (Request.CategoryId != null
                                ? x.ProvidedForm!.categoryId == Request.CategoryId.Value
                                : true) &&
                            (Request.CycleNumber != null
                                ? x.ProvidedForm!.CycleNumber == Request.CycleNumber
                                : true) &&
                            (!string.IsNullOrEmpty(Request.CategoryName)
                                ? (Request.lang == "en"
                                    ? x.ProvidedForm!.Category!.EnglishName.ToLower().StartsWith(Request.CategoryName.ToLower())
                                    : x.ProvidedForm!.Category!.ArabicName.ToLower().StartsWith(Request.CategoryName.ToLower()))
                                : true) &&
                            (Request.EligibleToWin != null
                                ? x.EligibleToWin == Request.EligibleToWin
                                : true) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleEntityId &&
                            (Request.EligableFilter != null
                                ? (EligibleForCertification != null
                                    ? (x.EligibleForCertification == EligibleForCertification)
                                    : (EligibleForAStatement1 != null
                                        ? (EligibleForAStatement1.Value
                                            ? x.FinalArbitrationId == null
                                            : x.FinalArbitrationId != null)
                                        : (x.EligibleForAStatement == EligibleForAStatement2)))
                                : true))
                        .OrderByDescending(x => x.CreatedAt)
                        .AsEnumerable()
                        .DistinctBy(x => x.ProvidedFormId)
                        .AsEnumerable()
                        .Skip((Request.page - 1) * Request.PerPage)
                        .Take(Request.PerPage)
                        .ToList();
                }
                else
                {
                    ArbitrationResultEntities = _ArbitrationResultRepository
                        .Where(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Any(y => y == x.ProvidedFormId) &&
                            (Request.CategoryId != null
                                ? x.ProvidedForm!.categoryId == Request.CategoryId.Value
                                : true) &&
                            (Request.CycleNumber != null
                                ? x.ProvidedForm!.CycleNumber == Request.CycleNumber
                                : true) &&
                            (!string.IsNullOrEmpty(Request.CategoryName)
                                ? (Request.lang == "en"
                                    ? x.ProvidedForm!.Category!.EnglishName.ToLower().StartsWith(Request.CategoryName.ToLower())
                                    : x.ProvidedForm!.Category!.ArabicName.ToLower().StartsWith(Request.CategoryName.ToLower()))
                                : true) &&
                            (Request.EligibleToWin != null
                                ? x.EligibleToWin == Request.EligibleToWin
                                : true) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleEntityId &&
                            (Request.EligableFilter != null
                                ? (EligibleForCertification != null
                                    ? (x.EligibleForCertification == EligibleForCertification)
                                    : (EligibleForAStatement1 != null
                                        ? (EligibleForAStatement1.Value
                                            ? x.FinalArbitrationId == null
                                            : x.FinalArbitrationId != null)
                                        : (x.EligibleForAStatement == EligibleForAStatement2)))
                                : true))
                        .OrderByDescending(x => x.CreatedAt)
                        .AsEnumerable()
                        .DistinctBy(x => x.ProvidedFormId)
                        .AsEnumerable()
                        .ToList();
                }

                var SubscribersNames = DynamicAttributeValueEntities
                    .Select(x => new
                    {
                        FormId = x.RecordId,
                        SubscriberName = x.Value
                    }).ToList();

                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntities = await _ArbitrationRepository
                    .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleEntityId)
                    .GroupBy(x => x.ProvidedFormId)
                    .ToListAsync();

                List<int> ArbitrationIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.Id))
                    .ToList();

                List<Arbitration> ArbitrationEntities = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration))
                    .ToList();

                List<int> FormsIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.ProvidedFormId))
                    .Distinct()
                    .ToList();

                List<ArbitrationAudit> ArbitrationAuditEntities = await _ArbitrationAuditRepository
                    .Where(x => FormsIds.Contains(x.ProvidedFormId))
                    .ToListAsync();

                List<FinalArbitration> FinalArbitrationEntities = ArbitrationResultEntities
                    .Where(x => x.FinalArbitrationId != null)
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
                        CategoryContainStatement1 = x.ProvidedForm!.Category!.ContainStatment1,
                        CategoryContainStatement2 = (x.ProvidedForm!.Category!.MinimumAmountToObtainAStatement2 == null ||
                            x.ProvidedForm!.Category!.MaximumAmountToObtainAStatement2 == null)
                                ? false : true,
                        CategoryContainCertificate = (x.ProvidedForm!.Category!.MinimumRequirementToObtainACertificate == null ||
                            x.ProvidedForm!.Category!.MaximumRequirementToObtainACertificate == null)
                                ? false : true,
                        InitialArbitrationScoreDto = ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => new InitialArbitrationScoreDto()
                            {
                                InitialArbitrationScore = y.FullScore
                            }).ToList(),
                        ArbitrationAuditScore = ArbitrationAuditEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Sum(y => y.ArbitrationScore),
                        FinalArbitrationScore = FinalArbitrationEntities.Any() 
                            ? (FinalArbitrationEntities
                                .FirstOrDefault(y => y.ProvidedFormId == x.ProvidedFormId)
                                ?.FinalScore ?? 0)
                            : 0,
                        EligibleForCertification = x.EligibleForCertification,
                        EligibleForAStatement1 = FinalArbitrationEntities
                            .Any(y => y.ProvidedFormId == x.ProvidedFormId)
                                ? false : true,
                        EligibleForAStatement2 = x.EligibleForAStatement,
                        EligibleToWin = x.EligibleToWin,
                        GotCertification = x.GotCertification,
                        GotStatement1 = x.GotStatement1,
                        GotStatement2 = x.GotStatement2,
                        Winner = x.Winner,
                        DateOfObtainingTheCertificate = x.DateOfObtainingTheCertificate,
                        DateOfObtainingTheStatement1 = x.DateOfObtainingTheStatement1,
                        DateOfObtainingTheStatement2 = x.DateOfObtainingTheStatement2,
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
}
