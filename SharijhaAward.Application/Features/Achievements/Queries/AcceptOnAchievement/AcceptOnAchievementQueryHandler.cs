using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;

namespace SharijhaAward.Application.Features.Achievements.Queries.AcceptOnAchievement
{
    public class AcceptOnAchievementQueryHandler
        : IRequestHandler<AcceptOnAchievementQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Achievement> _AchievementRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JwtProvider;
        public AcceptOnAchievementQueryHandler(IAsyncRepository<Achievement> _AchievementRepository,
            IUserRepository _UserRepository, 
            IJwtProvider _JwtProvider)
        {
            this._AchievementRepository = _AchievementRepository;
            this._UserRepository = _UserRepository;
            this._JwtProvider = _JwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(AcceptOnAchievementQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int AdminId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token));

            Domain.Entities.IdentityModels.User? Admin = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == AdminId);

            Domain.Entities.IdentityModels.User? User = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.UserId);
            
            if (User is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Achievement? AchievementEntity = await _AchievementRepository
                .FirstOrDefaultAsync(x => x.UserId == User!.Id);
            
            AchievementEntity!.AcceptedOnDistinctionField = Request.AcceptOn == 1 
                ? Request.IsAccepted 
                : AchievementEntity!.AcceptedOnDistinctionField;

            AchievementEntity!.AcceptedOnProjects = Request.AcceptOn == 2 
                ? Request.IsAccepted 
                : AchievementEntity!.AcceptedOnProjects;

            AchievementEntity!.AcceptedOnSkillsAndExperiences = Request.AcceptOn == 3 
                ? Request.IsAccepted 
                : AchievementEntity!.AcceptedOnSkillsAndExperiences;

            await _AchievementRepository.UpdateAsync(AchievementEntity!);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
