using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetAllSubscribers
{
    public class GetAllSubscribersQueryHandler
        : IRequestHandler<GetAllSubscribersQuery, BaseResponse<List<UserListVm>>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public GetAllSubscribersQueryHandler(IUserRepository userRepository, IRoleRepository roleRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<UserListVm>>> Handle(GetAllSubscribersQuery request, CancellationToken cancellationToken)
        {
            var SubscriberRole = await _roleRepository.GetByName("Subscriber");

            if(SubscriberRole == null)
            {
                return new BaseResponse<List<UserListVm>>("faild in roles", false,  400);
            }

            var Subscribers = _userRepository.Where(u => u.RoleId == SubscriberRole.RoleId);

            var data = _mapper.Map<List<UserListVm>>(Subscribers);

            return new BaseResponse<List<UserListVm>>("", true, 200);
        }
    }
}
