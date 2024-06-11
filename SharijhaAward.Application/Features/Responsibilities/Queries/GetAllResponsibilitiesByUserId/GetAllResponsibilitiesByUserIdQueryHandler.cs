using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilitiesByUserId
{
    public class GetAllResponsibilitiesByUserIdQueryHandler
        : IRequestHandler<GetAllResponsibilitiesByUserIdQuery, BaseResponse<List<ResponsibilityListVM>>>
    {
        private readonly IAsyncRepository<ResponsibilityUser> _responsibilityUserRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAllResponsibilitiesByUserIdQueryHandler(IAsyncRepository<Role> roleRepository, IAsyncRepository<ResponsibilityUser> responsibilityUserRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _responsibilityUserRepository = responsibilityUserRepository;
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<ResponsibilityListVM>>> Handle(GetAllResponsibilitiesByUserIdQuery request, CancellationToken cancellationToken)
        {

            var UserId = request.UserToken != null
                ? int.Parse(_jwtProvider.GetUserIdFromToken(request.UserToken!))
                : request.UserId;

            if (UserId == null && request.UserId == null)
            {
                return new BaseResponse<List<ResponsibilityListVM>>("", false, 400);
            }
            else if(UserId == null && request.UserToken == null)
            {
                return new BaseResponse<List<ResponsibilityListVM>>("Un Auth", false, 401);
            }
            var User = await _userRepository.GetByIdAsync(UserId);

            if(User == null)
            {
                return new BaseResponse<List<ResponsibilityListVM>>("", false, 404);
            }


            var Responsibilities = _responsibilityUserRepository
                .Include(x => x.Responsibility)
                .Where(x => x.UserId == UserId)
                .Select(x => x.Responsibility)
                .Include(x=>x.ResponsibilityUsers).ToList();
            
            var data = _mapper.Map<List<ResponsibilityListVM>>(Responsibilities);
            
            for(int i=0; i < data.Count(); i++)
            {
                data[i].ResponsibilityUsers = _mapper.Map<List<ResponsibilityUserDto>>(Responsibilities[i].ResponsibilityUsers);

                data[i].RoleName = (await _roleRepository.GetByIdAsync(Responsibilities[i].RoleId))!.ArabicName;
            }

            return new BaseResponse<List<ResponsibilityListVM>>("", true, 200, data);

        }
    }
}
