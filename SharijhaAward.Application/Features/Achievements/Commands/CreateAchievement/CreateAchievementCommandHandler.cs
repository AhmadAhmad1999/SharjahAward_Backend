using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;

namespace SharijhaAward.Application.Features.Achievements.Commands.CreateAchievement
{
    public class CreateAchievementCommandHandler
        : IRequestHandler<CreateAchievementCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Achievement> _AchievementsRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;

        public CreateAchievementCommandHandler(IUserRepository UserRepository,
            IAsyncRepository<Achievement> AchievementsRepository, 
            IJwtProvider JwtProvider, 
            IMapper Mapper)
        {
            _AchievementsRepository = AchievementsRepository;
            _UserRepository = UserRepository;
            _JwtProvider = JwtProvider;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAchievementCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token));

            Domain.Entities.IdentityModels.User? User = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            Achievement NewAchievementEntity = _Mapper.Map<Achievement>(Request);

            NewAchievementEntity.UserId = User!.Id;

            await _AchievementsRepository.AddAsync(NewAchievementEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
