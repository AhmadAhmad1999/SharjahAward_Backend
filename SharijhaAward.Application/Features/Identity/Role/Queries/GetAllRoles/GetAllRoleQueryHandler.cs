using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Identity.Role.Queries.GetAllRoles
{
    public class GetAllRoleQueryHandler 
        : IRequestHandler<GetAllRolesQuery , List<RoleListVm>>
    {
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.Role> _roleRepository;
        private IMapper _mapper;

        public GetAllRoleQueryHandler(IAsyncRepository<Domain.Entities.IdentityModels.Role> roleRepository , IMapper mapper)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task<List<RoleListVm>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var allRoles = await _roleRepository.ListAllAsync();
            if(allRoles == null)
            {
                throw new OpenQA.Selenium.NotFoundException("There is No Roles");
            }
            return _mapper.Map<List<RoleListVm>>(allRoles);

        }
    }
}
