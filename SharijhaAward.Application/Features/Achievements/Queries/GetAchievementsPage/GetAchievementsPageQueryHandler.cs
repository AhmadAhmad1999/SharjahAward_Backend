using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;

namespace SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage
{
    public class GetAchievementsPageQueryHandler
        : IRequestHandler<GetAchievementsPageQuery, BaseResponse<AchievementsDto>>
    {
        private readonly IAsyncRepository<Achievement> _AchievementRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;

        public GetAchievementsPageQueryHandler(IAsyncRepository<Achievement> _AchievementRepository,
            IUserRepository _UserRepository,
            IJwtProvider _JwtProvider, 
            IMapper _Mapper)
        {
            this._AchievementRepository = _AchievementRepository;
            this._UserRepository = _UserRepository;
            this._JwtProvider = _JwtProvider;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<AchievementsDto>> Handle(GetAchievementsPageQuery Request, CancellationToken cancellationToken)
        {
            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token));

            Domain.Entities.IdentityModels.User? User = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            Achievement? AchievementEntity = await _AchievementRepository
                .FirstOrDefaultAsync(x => x.UserId == User!.Id);

            AchievementsDto AchievementsDto = _Mapper.Map<AchievementsDto>(AchievementEntity);

            return new BaseResponse<AchievementsDto>("", true, 200,AchievementsDto);
        }
    }
}
