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
        private readonly IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> _SubscriberRepository;
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetRelatedAccoutProfileByIdHandler(IMapper Mapper,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> FormRepository,
            IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> SubscriberRepository,
            IAsyncRepository<RelatedAccount> RelatedAccountRepository,
            IJwtProvider JWTProvider)
        {
            _Mapper = Mapper;
            _FormRepository = FormRepository;
            _SubscriberRepository = SubscriberRepository;
            _RelatedAccountRepository = RelatedAccountRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<GetRelatedAccoutProfileByIdResponse>> Handle(GetRelatedAccoutProfileByIdQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (string.IsNullOrEmpty(Request.token))
            {
                ResponseMessage = "You must enter the token in the request";

                return new BaseResponse<GetRelatedAccoutProfileByIdResponse>(ResponseMessage, false, 400);
            }

            RelatedAccount? RelatedAccountEntity = await _RelatedAccountRepository
                .FirstOrDefaultAsync(x => x.Id == Request.RelatedAccountId);

            if (RelatedAccountEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Related account is not found"
                    : "الحساب المرتبط غير موجود";

                return new BaseResponse<GetRelatedAccoutProfileByIdResponse>(ResponseMessage, false, 404);
            }

            Guid UserId = new Guid(_JWTProvider.GetUserIdFromToken(Request.token!));
            Guid RelatedAccountSubscriberId;

            if (RelatedAccountEntity.Subscriber1Id == UserId)
                RelatedAccountSubscriberId = RelatedAccountEntity.Subscriber2Id;

            else if (RelatedAccountEntity.Subscriber2Id == UserId)
                RelatedAccountSubscriberId = RelatedAccountEntity.Subscriber1Id;

            else
            {
                ResponseMessage = "An error occurred. Please check the IDs in RelatedAccountEntity";

                return new BaseResponse<GetRelatedAccoutProfileByIdResponse>(ResponseMessage, false, 400);
            }

            Domain.Entities.SubscriberModel.Subscriber? RelatedAccountSubscriberEntity = await _SubscriberRepository
                .FirstOrDefaultAsync(x => x.Id == RelatedAccountSubscriberId);

            if (RelatedAccountSubscriberEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Profile is not found"
                    : "الملف الشخصي غير موجود";

                return new BaseResponse<GetRelatedAccoutProfileByIdResponse>(ResponseMessage, false, 404);
            }

            RelatedAccountProfileData ProfileData = _Mapper.Map<RelatedAccountProfileData>(RelatedAccountSubscriberEntity);
            
            ProfileData.Name = Request.lang == "en"
                ? RelatedAccountSubscriberEntity.EnglishName
                : RelatedAccountSubscriberEntity.ArabicName;

            List <RelatedAccountProvidedForms> ProvidedForms = _Mapper.Map<List<RelatedAccountProvidedForms>>(Request.Type == null
                ? await _FormRepository.Where(x => x.userId == RelatedAccountSubscriberId).ToListAsync()
                : await _FormRepository.Where(x => x.userId == RelatedAccountSubscriberId && x.Type == Request.Type).ToListAsync());

            GetRelatedAccoutProfileByIdResponse Response = new GetRelatedAccoutProfileByIdResponse()
            {
                ProfileData = ProfileData,
                ProvidedForms = ProvidedForms
            };

            return new BaseResponse<GetRelatedAccoutProfileByIdResponse>(ResponseMessage, true, 200, Response);
        }
    }
}
