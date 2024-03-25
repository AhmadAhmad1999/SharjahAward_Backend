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

namespace SharijhaAward.Application.Features.Achievements.Commands.UpdateDistinctionField
{
    public class UpdateAchievementCommandHandler
        : IRequestHandler<UpdateAchievementCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Achievement> _achievementsRepository;
        private readonly IJwtProvider jwtProvider;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public Task<BaseResponse<object>> Handle(UpdateAchievementCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
