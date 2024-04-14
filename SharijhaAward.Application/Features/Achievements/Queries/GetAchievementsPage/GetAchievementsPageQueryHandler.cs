using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage
{
    public class GetAchievementsPageQueryHandler
        : IRequestHandler<GetAchievementsPageQuery, BaseResponse<AchievementsDto>>
    {
        private readonly IAsyncRepository<Achievement> _achievementsRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAchievementsPageQueryHandler(IAsyncRepository<Achievement> achievementsRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _achievementsRepository = achievementsRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<AchievementsDto>> Handle(GetAchievementsPageQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            
            if(UserId.IsNullOrEmpty())
            {
                return new BaseResponse<AchievementsDto>("Un Auth", false, 401);
            }
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));

            if(User == null)
            {
                return new BaseResponse<AchievementsDto>("User Not Found", false, 404);
            }
            var Achievements = await _achievementsRepository.FirstOrDefaultAsync(a => a.UserId == User.Id);

            var data = _mapper.Map<AchievementsDto>(Achievements);
            
            return new BaseResponse<AchievementsDto>("", true, 200,data);
        }
    }
}
