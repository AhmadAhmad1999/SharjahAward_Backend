using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
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
        private readonly IJwtProvider _JWTProvider;

        public GetAllFormsForSortingProcessHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _UserRoleRepository = UserRoleRepository;
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
                UserRole? CheckIfThisUserHaveAllAccess = await _UserRoleRepository
                    .Include(x => x.Role!)
                    .FirstOrDefaultAsync(x => x.UserId == UserId && x.Role!.HaveFullAccess);

                if (CheckIfThisUserHaveAllAccess is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator is not Found"
                        : "المحكم غير موجود";

                    return new BaseResponse<List<GetAllFormsForSortingProcessListVM>>(ResponseMessage, false, 404);
                }

                UserId = 0;
            }

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
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .ToListAsync();
            }
            else
            {
                ArbitrationsEntities = await _ArbitrationRepository
                    .Where(x => UserId != 0 
                        ? x.ArbitratorId == UserId
                        : true)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .Include(x => x.Arbitrator!)
                    .Include(x => x.ProvidedForm!)
                    .Include(x => x.ProvidedForm!.Category!)
                    .ToListAsync();
            }

            List<DynamicAttributeValue> SubscribersNames = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Include(x => x.DynamicAttribute!.DynamicAttributeSection)
                .Where(x => ArbitrationsEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                    x.DynamicAttribute!.EnglishLabel.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                .ToListAsync();

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
                    Reason = string.Empty
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
                            : true));
            }
                
            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllFormsForSortingProcessListVM>>(ResponseMessage, true, 200,
                Response, PaginationParameter);
        }
    }
}
