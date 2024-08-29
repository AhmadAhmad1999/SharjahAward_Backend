using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess
{
    public class GetAllFormsForSortingProcessHandler : IRequestHandler<GetAllFormsForSortingProcessQuery,
        BaseResponse<List<GetAllFormsForSortingProcessListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetAllFormsForSortingProcessHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<ComitteeArbitrator> ComitteeArbitratorRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _UserRoleRepository = UserRoleRepository;
            _ComitteeArbitratorRepository = ComitteeArbitratorRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<List<GetAllFormsForSortingProcessListVM>>>
            Handle(GetAllFormsForSortingProcessQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository.FirstOrDefaultAsync(x => x.Id == UserId);

            if (ArbitratorEntity is null)
            {
                List<UserRole> CheckIfThisUserHaveAllAccess = await _UserRoleRepository
                    .Where(x => x.UserId == UserId)
                    .ToListAsync();

                UserId = 0;

                List<Arbitration> ArbitrationsEntities = new List<Arbitration>();

                if (Request.filter is not null)
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Where(x => (UserId != 0
                            ? x.ArbitratorId == UserId
                            : true) &&
                            (!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.filter.isAccepted != null
                                ? x.isAccepted == Request.filter.isAccepted.Value
                                : true) &&
                            (Request.filter.CategoriesIds.Count() > 0
                                ? Request.filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Where(x => UserId != 0
                            ? x.ArbitratorId == UserId
                            : true)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }

                List<DynamicAttributeValue> SubscribersNames = new List<DynamicAttributeValue>();

                if (Request.filter != null
                        ? !string.IsNullOrEmpty(Request.filter.SubscriberName)
                        : false)
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(Request.filter.SubscriberName.ToLower()))
                        .ToListAsync();

                    ArbitrationsEntities = ArbitrationsEntities
                        .Where(x => SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .ToList();
                }
                else
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .ToListAsync();
                }

                List<GetAllFormsForSortingProcessListVM> Response = ArbitrationsEntities
                    .Select(x => new GetAllFormsForSortingProcessListVM()
                    {
                        Id = x.Id,
                        FormId = x.ProvidedFormId,
                        SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
                        ArbitratorId = x.ArbitratorId,
                        ArbitratorName = Request.lang == "en"
                            ? x.Arbitrator!.EnglishName
                            : x.Arbitrator!.ArabicName,
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm.Category.EnglishName
                            : x.ProvidedForm.Category.ArabicName,
                        isAccepted = x.isAccepted,
                        Reason = x.ReasonForRejecting,
                        isAcceptedFromChairman = x.isAcceptedFromChairman,
                        Categories = ArbitrationsEntities
                            .Select(y => new GetAllFormsForSortingProcessListVMCategories()
                            {
                                Id = y.ProvidedForm!.Category!.Id,
                                CategoryName = Request.lang == "en"
                                    ? y.ProvidedForm!.Category!.EnglishName
                                    : y.ProvidedForm!.Category!.ArabicName
                            }).AsEnumerable()
                            .DistinctBy(y => y.Id)
                            .ToList()
                    }).ToList();

                int TotalCount = 0;

                if (Request.filter is null)
                    TotalCount = await _ArbitrationRepository.GetCountAsync(x => UserId != 0
                        ? x.ArbitratorId == UserId
                        : true);

                else
                {
                    TotalCount = await _ArbitrationRepository
                        .GetCountAsync(x => (UserId != 0
                            ? x.ArbitratorId == UserId
                            : true) &&
                            (!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.filter.isAccepted != null
                                ? x.isAccepted == Request.filter.isAccepted.Value
                                : true) &&
                            (Request.filter.CategoriesIds.Count() > 0
                                ? Request.filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.filter.SubscriberName)
                                ? SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId)
                                : true));
                }

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFormsForSortingProcessListVM>>(ResponseMessage, true, 200,
                    Response, PaginationParameter);
            }
            else if (ArbitratorEntity.isChairman && (Request.AsChairman != null
                ? Request.AsChairman.Value : false))
            {
                List<int> ArbitratorsIds = await _ComitteeArbitratorRepository
                    .Where(x => x.Committee!.ChairmanId == ArbitratorEntity.Id)
                    .Select(x => x.ArbitratorId)
                    .ToListAsync();

                List<Arbitration> ArbitrationsEntities = new List<Arbitration>();

                if (Request.filter is not null)
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Where(x => ArbitratorsIds.Contains(x.ArbitratorId) &&
                            x.isAccepted == FormStatus.Accepted &&
                            (!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.filter.isAccepted != null
                                ? x.isAccepted == Request.filter.isAccepted.Value
                                : true) &&
                            (Request.filter.CategoriesIds.Count() > 0
                                ? Request.filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Where(x => ArbitratorsIds.Contains(x.ArbitratorId) &&
                            x.isAccepted == FormStatus.Accepted)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }

                List<DynamicAttributeValue> SubscribersNames = new List<DynamicAttributeValue>();

                if (Request.filter != null
                        ? !string.IsNullOrEmpty(Request.filter.SubscriberName)
                        : false)
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(Request.filter.SubscriberName.ToLower()))
                        .ToListAsync();

                    ArbitrationsEntities = ArbitrationsEntities
                        .Where(x => SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .ToList();
                }
                else
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .ToListAsync();
                }

                List<GetAllFormsForSortingProcessListVM> Response = ArbitrationsEntities
                    .Select(x => new GetAllFormsForSortingProcessListVM()
                    {
                        Id = x.Id,
                        FormId = x.ProvidedFormId,
                        SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
                        ArbitratorId = x.ArbitratorId,
                        ArbitratorName = Request.lang == "en"
                            ? x.Arbitrator!.EnglishName
                            : x.Arbitrator!.ArabicName,
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm.Category.EnglishName
                            : x.ProvidedForm.Category.ArabicName,
                        isAccepted = x.isAccepted,
                        Reason = x.ReasonForRejecting,
                        isAcceptedFromChairman = x.isAcceptedFromChairman,
                        Categories = ArbitrationsEntities
                            .Select(y => new GetAllFormsForSortingProcessListVMCategories()
                            {
                                Id = y.ProvidedForm!.Category!.Id,
                                CategoryName = Request.lang == "en"
                                    ? y.ProvidedForm!.Category!.EnglishName
                                    : y.ProvidedForm!.Category!.ArabicName
                            }).AsEnumerable()
                            .DistinctBy(y => y.Id)
                            .ToList()
                    }).ToList();

                int TotalCount = 0;

                if (Request.filter is null)
                    TotalCount = await _ArbitrationRepository.GetCountAsync(x => ArbitratorsIds.Contains(x.ArbitratorId));

                else
                {
                    TotalCount = await _ArbitrationRepository
                        .GetCountAsync(x => ArbitratorsIds.Contains(x.ArbitratorId) &&
                            (!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.filter.isAccepted != null
                                ? x.isAccepted == Request.filter.isAccepted.Value
                                : true) &&
                            (Request.filter.CategoriesIds.Count() > 0
                                ? Request.filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.filter.SubscriberName)
                                ? SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId)
                                : true));
                }

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFormsForSortingProcessListVM>>(ResponseMessage, true, 200,
                    Response, PaginationParameter);
            }
            else
            {
                List<Arbitration> ArbitrationsEntities = new List<Arbitration>();

                if (Request.filter is not null)
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Where(x => (UserId != 0
                            ? x.ArbitratorId == UserId
                            : true) &&
                            (!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.filter.isAccepted != null
                                ? x.isAccepted == Request.filter.isAccepted.Value
                                : true) &&
                            (Request.filter.CategoriesIds.Count() > 0
                                ? Request.filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Where(x => UserId != 0
                            ? x.ArbitratorId == UserId
                            : true)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }

                List<DynamicAttributeValue> SubscribersNames = new List<DynamicAttributeValue>();

                if (Request.filter != null
                        ? !string.IsNullOrEmpty(Request.filter.SubscriberName)
                        : false)
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(Request.filter.SubscriberName.ToLower()))
                        .ToListAsync();

                    ArbitrationsEntities = ArbitrationsEntities
                        .Where(x => SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .ToList();
                }
                else
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .ToListAsync();
                }

                List<GetAllFormsForSortingProcessListVM> Response = ArbitrationsEntities
                    .Select(x => new GetAllFormsForSortingProcessListVM()
                    {
                        Id = x.Id,
                        FormId = x.ProvidedFormId,
                        SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
                        ArbitratorId = x.ArbitratorId,
                        ArbitratorName = Request.lang == "en"
                            ? x.Arbitrator!.EnglishName
                            : x.Arbitrator!.ArabicName,
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm.Category.EnglishName
                            : x.ProvidedForm.Category.ArabicName,
                        isAccepted = x.isAccepted,
                        Reason = x.ReasonForRejecting,
                        isAcceptedFromChairman = x.isAcceptedFromChairman,
                        Categories = ArbitrationsEntities
                            .Select(y => new GetAllFormsForSortingProcessListVMCategories()
                            {
                                Id = y.ProvidedForm!.Category!.Id,
                                CategoryName = Request.lang == "en"
                                    ? y.ProvidedForm!.Category!.EnglishName
                                    : y.ProvidedForm!.Category!.ArabicName
                            }).AsEnumerable()
                            .DistinctBy(y => y.Id)
                            .ToList()
                    }).ToList();

                int TotalCount = 0;

                if (Request.filter is null)
                    TotalCount = await _ArbitrationRepository.GetCountAsync(x => UserId != 0
                        ? x.ArbitratorId == UserId
                        : true);

                else
                {
                    TotalCount = await _ArbitrationRepository
                        .GetCountAsync(x => (UserId != 0
                            ? x.ArbitratorId == UserId
                            : true) &&
                            (!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.filter.isAccepted != null
                                ? x.isAccepted == Request.filter.isAccepted.Value
                                : true) &&
                            (Request.filter.CategoriesIds.Count() > 0
                                ? Request.filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.filter.SubscriberName)
                                ? SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId)
                                : true));
                }

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFormsForSortingProcessListVM>>(ResponseMessage, true, 200,
                    Response, PaginationParameter);
            }

            throw new NotImplementedException();
        }
    }
}
