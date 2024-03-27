using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Commands.UpdateAchievement
{
    public class UpdateAchievementCommandHandler
        : IRequestHandler<UpdateAchievementCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Achievement> _achievementsRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateAchievementCommandHandler(IAsyncRepository<Achievement> achievementsRepository, IJwtProvider jwtProvider, IUserRepository userRepository, IMapper mapper)
        {
            _achievementsRepository = achievementsRepository;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAchievementCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Achievement has been Updated"
                : "تم تعديل الإنجازات";

            var UserId = _jwtProvider.GetUserIdFromToken(request.token);

            var User = UserId != null
                ? await _userRepository.GetByIdAsync(new Guid(UserId))
                : null;
            if (User == null)
            {
                return new BaseResponse<object>("User Not Found",false,401);
            }

            var Achievement =await _achievementsRepository.Where(a => a.UserId == User.Id).FirstOrDefaultAsync();

            if (Achievement == null)
            {
                Achievement = new Achievement()
                {
                    UserId = User.Id,
                };
                await _achievementsRepository.AddAsync(Achievement);
            }

            _mapper.Map(request, Achievement, typeof(UpdateAchievementCommand), typeof(Achievement));

            if (request.EditeOnDistinctionField)
                Achievement.UpdateDistinctionField = DateTime.Now.Date;

            if (request.EditeOnProjects)
                Achievement.UpdateProjects = DateTime.Now.Date;

            if (request.EditeOnSkillsAndExperiences)
                Achievement.UpdateSkillsAndExperiences = DateTime.Now.Date;

            if (request.EditeOnSocialMedia)
                Achievement.UpdateSocialMedia = DateTime.Now.Date;


            await _achievementsRepository.UpdateAsync(Achievement);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
