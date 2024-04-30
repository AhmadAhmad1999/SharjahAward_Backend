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

namespace SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsById
{
    public class GetAchievementsByIdQueryHandler
        : IRequestHandler<GetAchievementsByIdQuery, BaseResponse<AchievementsDto>>
    {
        private readonly IAsyncRepository<Achievement> _achievementsRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAchievementsByIdQueryHandler(IAsyncRepository<Achievement> achievementsRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _achievementsRepository = achievementsRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<AchievementsDto>> Handle(GetAchievementsByIdQuery request, CancellationToken cancellationToken)
        {
            var AdminId = _jwtProvider.GetUserIdFromToken(request.token);

            if (AdminId.IsNullOrEmpty())
            {
                return new BaseResponse<AchievementsDto>("Un Auth", false, 401);
            }
            var Admin = await _userRepository.GetByIdAsync(int.Parse(AdminId));

            if (Admin == null)
            {
                return new BaseResponse<AchievementsDto>("Un Auth", false, 401);
            }

            var User = await _userRepository.GetByIdAsync(request.UserId);
            if(User == null)
            {
                return new BaseResponse<AchievementsDto>("", false, 404);
            }

            var Achievements = await _achievementsRepository.FirstOrDefaultAsync(a => a.UserId == User!.Id);

            var data = _mapper.Map<AchievementsDto>(Achievements);

            return new BaseResponse<AchievementsDto>("", true, 200, data);
        }
    }
}
