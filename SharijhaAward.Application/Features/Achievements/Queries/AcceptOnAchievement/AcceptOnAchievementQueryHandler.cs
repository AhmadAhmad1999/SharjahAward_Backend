using AutoMapper;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Queries.AcceptOnAchievement
{
    public class AcceptOnAchievementQueryHandler
        : IRequestHandler<AcceptOnAchievementQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Achievement> _achievementsRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;


        public AcceptOnAchievementQueryHandler(IAsyncRepository<Achievement> achievementsRepository, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _achievementsRepository = achievementsRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;

        }

        public async Task<BaseResponse<object>> Handle(AcceptOnAchievementQuery request, CancellationToken cancellationToken)
        {
            var AdminId = _jwtProvider.GetUserIdFromToken(request.token);

            if (AdminId.IsNullOrEmpty())
            {
                return new BaseResponse<object>("Un Auth", false, 401);
            }
            var Admin = await _userRepository.GetByIdAsync(int.Parse(AdminId));

            if (Admin == null)
            {
                return new BaseResponse<object>("Un Auth", false, 401);
            }

            var User = await _userRepository.GetByIdAsync(request.UserId);
            if (User == null)
            {
                return new BaseResponse<object>("", false, 404);
            }

            var Achievements = await _achievementsRepository.FirstOrDefaultAsync(a => a.UserId == User!.Id);

            Achievements!.IsAccepted = request.IsAccepted;

            await _achievementsRepository.UpdateAsync(Achievements);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
