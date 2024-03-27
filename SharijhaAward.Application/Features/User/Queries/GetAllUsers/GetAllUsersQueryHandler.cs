using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler
        : IRequestHandler<GetAllUsersQuery , BaseResponse<List<UserListVm>>>
    {
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler
            (
            IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository ,
            IMapper mapper,
            IAsyncRepository<Role> roleRepository
            )
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task<BaseResponse<List<UserListVm>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var Users = await _userRepository.GetPagedReponseAsync(request.page, request.pageSize);

            var data = _mapper.Map<List<UserListVm>>(Users );

            var count = _userRepository.GetCount(u => true);
           
            Pagination pagination = new Pagination(request.page, request.pageSize, count);
           
            return new BaseResponse<List<UserListVm>>("", true, 200, data, pagination);
        }
    }
}
