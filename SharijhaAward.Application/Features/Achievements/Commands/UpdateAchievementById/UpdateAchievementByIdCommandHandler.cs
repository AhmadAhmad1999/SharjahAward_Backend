using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Commands.UpdateAchievementById
{
    public class UpdateAchievementByIdCommandHandler
        : IRequestHandler<UpdateAchievementByIdCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Achievement> _achievementsRepository;
        private readonly IAsyncRepository<UserRole> _userRolesRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
       
        public UpdateAchievementByIdCommandHandler(IAsyncRepository<Achievement> achievementsRepository, IAsyncRepository<UserRole> userRolesRepository, IJwtProvider jwtProvider, IUserRepository userRepository, IMapper mapper)
        {
            _achievementsRepository = achievementsRepository;
            _userRolesRepository = userRolesRepository;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAchievementByIdCommand request, CancellationToken cancellationToken)
        {
            var AdminId = _jwtProvider.GetUserIdFromToken(request.token);
            
            var Admin = await _userRepository.GetByIdAsync(int.Parse(AdminId));
            if(Admin == null)
            {
                return new BaseResponse<object>("", false, 401);
            }

            var User = await _userRepository.GetByIdAsync(request.UserId);
            if(User == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            
            var Achievement = await _achievementsRepository.FirstOrDefaultAsync(a => a.UserId == User!.Id);

            _mapper.Map(request, Achievement, typeof(UpdateAchievementByIdCommand), typeof(Achievement));


            Achievement!.AcceptedOnDistinctionField = true;
            Achievement!.AcceptedOnProjects = true;
            Achievement!.AcceptedOnSkillsAndExperiences = true;

            await _achievementsRepository.UpdateAsync(Achievement!);

            return new BaseResponse<object>("", true, 200);
        
        }
    }
}
