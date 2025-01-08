using MediatR;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.ForwordEmail
{
    public class ForwordEmailQueryHandler
        : IRequestHandler<ForwordEmailQuery, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        public ForwordEmailQueryHandler(IUserRepository _UserRepository,
            IJwtProvider _JWTProvider,
            IAsyncRepository<EmailMessage> _EmailMessageRepository)
        {
            this._UserRepository = _UserRepository;
            this._JWTProvider = _JWTProvider;
            this._EmailMessageRepository = _EmailMessageRepository;
        }

        public async Task<BaseResponse<object>> Handle(ForwordEmailQuery Request, CancellationToken cancellationToken)
        {
            EmailMessage? EmailMessageEntity = await _EmailMessageRepository
                .IncludeThenFirstOrDefaultAsync(x => x.message!, x => x.Id == Request.MsgId);

            if(EmailMessageEntity is null)
                return new BaseResponse<object>("", false, 404);

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!)));

            if (UserEntity is null)
                return new BaseResponse<object>("", false, 401);

            EmailMessageEntity.From = UserEntity.Email;

            if (!Request.To.IsNullOrEmpty())
            {
                Domain.Entities.IdentityModels.User? UserAssignEntity = await _UserRepository
                    .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.To!.ToLower() &&
                        string.IsNullOrEmpty(x.SubscriberId));
               
                if (UserAssignEntity is null)
                    return new BaseResponse<object>("This email is not found", false, 400);
               
                EmailMessageEntity.To = Request.To;

                EmailMessageEntity.AsignId = UserAssignEntity.Id;
            }

            if(Request.TypeId != null)
                EmailMessageEntity.TypeId = (int)Request.TypeId;

            await _EmailMessageRepository.UpdateAsync(EmailMessageEntity);

            return new BaseResponse<object>("تم إعادة توجيه الرسالة بنجاح", true, 200);
        }
    }
}
