using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetRelatedAccoutProfileById
{
    public class GetRelatedAccoutProfileByIdHandler
        : IRequestHandler<GetRelatedAccoutProfileByIdQuery, BaseResponse<GetRelatedAccoutProfileByIdResponse>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _FormRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetRelatedAccoutProfileByIdHandler(IMapper Mapper,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> FormRepository,
            IUserRepository UserRepository,
            IAsyncRepository<RelatedAccount> RelatedAccountRepository,
            IJwtProvider JWTProvider)
        {
            _Mapper = Mapper;
            _FormRepository = FormRepository;
            _UserRepository = UserRepository;
            _RelatedAccountRepository = RelatedAccountRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<GetRelatedAccoutProfileByIdResponse>> Handle(GetRelatedAccoutProfileByIdQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            RelatedAccount? RelatedAccountEntity = await _RelatedAccountRepository
                .FirstOrDefaultAsync(x => x.Id == Request.RelatedAccountId &&
                    x.User1Id == UserId);

            if (RelatedAccountEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Related account is not found"
                    : "الحساب المرتبط غير موجود";

                return new BaseResponse<GetRelatedAccoutProfileByIdResponse>(ResponseMessage, false, 404);
            }

            Domain.Entities.IdentityModels.User? RelatedAccountUserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == RelatedAccountEntity.User2Id);

            if (RelatedAccountUserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Profile is not found"
                    : "الملف الشخصي غير موجود";

                return new BaseResponse<GetRelatedAccoutProfileByIdResponse>(ResponseMessage, false, 404);
            }

            RelatedAccountProfileData ProfileData = _Mapper.Map<RelatedAccountProfileData>(RelatedAccountUserEntity);

            ProfileData.Name = Request.lang == "en"
                ? RelatedAccountUserEntity.EnglishName
                : RelatedAccountUserEntity.ArabicName;

            List<RelatedAccountProvidedForms> ProvidedForms = await _FormRepository
                .Where(x => x.userId == RelatedAccountEntity.User2Id &&
                    (Request.Type != null
                        ? x.Type == Request.Type
                        : true))
                .Include(x => x.Category!.Parent!)
                .Select(x => new RelatedAccountProvidedForms()
                {
                    CategoryId = x.categoryId,
                    CategoryName = Request.lang == "en"
                        ? x.Category!.Parent!.EnglishName
                        : x.Category!.Parent!.ArabicName,
                    CreatedAt = x.CreatedAt,
                    CurrentStep = x.CurrentStep,
                    CycleNumber = x.CycleNumber,
                    CycleYear = x.CycleYear,
                    FinalScore = x.FinalScore,
                    Id = x.Id,
                    PercentCompletion = x.PercentCompletion,
                    Status = x.Status,
                    SubscriberType = x.SubscriberType,
                    Type = x.Type,
                    subCategoryName = Request.lang == "en"
                        ? x.Category.EnglishName
                        : x.Category.ArabicName,
                }).ToListAsync();

            GetRelatedAccoutProfileByIdResponse Response = new GetRelatedAccoutProfileByIdResponse()
            {
                ProfileData = ProfileData,
                ProvidedForms = ProvidedForms
            };

            return new BaseResponse<GetRelatedAccoutProfileByIdResponse>(ResponseMessage, true, 200, Response);
        }
    }
}
