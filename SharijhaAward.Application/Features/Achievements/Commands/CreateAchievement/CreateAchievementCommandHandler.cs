using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Commands.CreateAchievement
{
    public class CreateAchievementCommandHandler
        : IRequestHandler<CreateAchievementCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Achievement> _achievementsRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public CreateAchievementCommandHandler(IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository,IAsyncRepository<Achievement> achievementsRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _achievementsRepository = achievementsRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAchievementCommand request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            if(User == null)
            {
                return new BaseResponse<object>("",false,401);
            }
            
            var Achievement = _mapper.Map<Achievement>(request);

            Achievement.UserId = User.Id;

            await _achievementsRepository.AddAsync(Achievement);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
