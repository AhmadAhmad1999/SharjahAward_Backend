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
                    .Include(x => x.Role!)
                    .Where(x => x.UserId == UserId)
                    .ToListAsync();

                if (CheckIfThisUserHaveAllAccess.Any(x => x.Role!.HaveFullAccess))
                    UserId = 0;

                else 
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator is not Found"
                        : "المحكم غير موجود";

                    return new BaseResponse<List<GetAllFormsForSortingProcessListVM>>(ResponseMessage, false, 404);
                }
            }
            else if (ArbitratorEntity.isChairman)
            {
                List<int> ArbitratorsIds = await _ComitteeArbitratorRepository
                    .Include(x => x.Committee!)
                    .Where(x => x.Committee!.ChairmanId == ArbitratorEntity.Id)
                    .Select(x => x.ArbitratorId)
                    .ToListAsync();

                List<Arbitration> ArbitrationsEntities = new List<Arbitration>();

                if (Request.Filter is not null)
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Include(x => x.Arbitrator!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category)
                        .Where(x => ArbitratorsIds.Contains(x.ArbitratorId) &&
                            (!string.IsNullOrEmpty(Request.Filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.Filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.Filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.Filter.isAccepted != null
                                ? x.isAccepted == Request.Filter.isAccepted.Value
                                : true) &&
                            (Request.Filter.CategoriesIds.Count() > 0
                                ? Request.Filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Where(x => ArbitratorsIds.Contains(x.ArbitratorId))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .Include(x => x.Arbitrator!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .ToListAsync();
                }

                List<DynamicAttributeValue> SubscribersNames = new List<DynamicAttributeValue>();
                
                if (Request.Filter != null
                        ? !string.IsNullOrEmpty(Request.Filter.SubscriberName)
                        : false)
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Include(x => x.DynamicAttribute!)
                        .Include(x => x.DynamicAttribute!.DynamicAttributeSection)
                        .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(Request.Filter.SubscriberName.ToLower()))
                        .ToListAsync();

                    ArbitrationsEntities = ArbitrationsEntities
                        .Where(x => SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .ToList();
                }
                else
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Include(x => x.DynamicAttribute!)
                        .Include(x => x.DynamicAttribute!.DynamicAttributeSection)
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

                if (Request.Filter is null)
                    TotalCount = await _ArbitrationRepository.GetCountAsync(x => ArbitratorsIds.Contains(x.ArbitratorId));

                else
                {
                    TotalCount = await _ArbitrationRepository
                        .GetCountAsync(x => ArbitratorsIds.Contains(x.ArbitratorId) &&
                            (!string.IsNullOrEmpty(Request.Filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.Filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.Filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.Filter.isAccepted != null
                                ? x.isAccepted == Request.Filter.isAccepted.Value
                                : true) &&
                            (Request.Filter.CategoriesIds.Count() > 0
                                ? Request.Filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.Filter.SubscriberName)
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

                if (Request.Filter is not null)
                {
                    ArbitrationsEntities = await _ArbitrationRepository
                        .Include(x => x.Arbitrator!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category)
                        .Where(x => (UserId != 0
                            ? x.ArbitratorId == UserId
                            : true) &&
                            (!string.IsNullOrEmpty(Request.Filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.Filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.Filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.Filter.isAccepted != null
                                ? x.isAccepted == Request.Filter.isAccepted.Value
                                : true) &&
                            (Request.Filter.CategoriesIds.Count() > 0
                                ? Request.Filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
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
                        .Include(x => x.Arbitrator!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .ToListAsync();
                }

                List<DynamicAttributeValue> SubscribersNames = new List<DynamicAttributeValue>();

                if (Request.Filter != null
                        ? !string.IsNullOrEmpty(Request.Filter.SubscriberName)
                        : false)
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Include(x => x.DynamicAttribute!)
                        .Include(x => x.DynamicAttribute!.DynamicAttributeSection)
                        .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(Request.Filter.SubscriberName.ToLower()))
                        .ToListAsync();

                    ArbitrationsEntities = ArbitrationsEntities
                        .Where(x => SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .ToList();
                }
                else
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Include(x => x.DynamicAttribute!)
                        .Include(x => x.DynamicAttribute!.DynamicAttributeSection)
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

                if (Request.Filter is null)
                    TotalCount = await _ArbitrationRepository.GetCountAsync(x => UserId != 0
                        ? x.ArbitratorId == UserId
                        : true);

                else
                {
                    TotalCount = await _ArbitrationRepository
                        .GetCountAsync(x => (UserId != 0
                            ? x.ArbitratorId == UserId
                            : true) &&
                            (!string.IsNullOrEmpty(Request.Filter.ArbitratorName)
                                ? Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.Filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.Filter.ArbitratorName.ToLower())
                                : true) &&
                            (Request.Filter.isAccepted != null
                                ? x.isAccepted == Request.Filter.isAccepted.Value
                                : true) &&
                            (Request.Filter.CategoriesIds.Count() > 0
                                ? Request.Filter.CategoriesIds.Any(y => y == x.ProvidedForm!.categoryId)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.Filter.SubscriberName)
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
