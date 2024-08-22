using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Commands.UpdateResponsibility
{
    public class UpdateResponsibilityCommandHandler
        : IRequestHandler<UpdateResponsibilityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IAsyncRepository<UserRole> _userRoleRepository;
        private readonly IAsyncRepository<ResponsibilityUser> _responsibilityUser;
        private readonly IMapper _mapper;

        public UpdateResponsibilityCommandHandler(IAsyncRepository<ResponsibilityUser> responsibilityUser, IAsyncRepository<UserRole> userRoleRepository,IAsyncRepository<Responsibility> responsibilityRepository, IAsyncRepository<Role> roleRepository, IMapper mapper)
        {
            _responsibilityRepository = responsibilityRepository;
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
            _responsibilityUser = responsibilityUser;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateResponsibilityCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Responsibility has been Updated"
                : "تم تعديل المسؤولية";

            var Responsibility = await _responsibilityRepository.GetByIdAsync(request.Id);         
           
            if(Responsibility == null)
            {
                msg = request.lang == "en"
                ? "Responsibility not Found"
                : "المسؤولية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var role = await _roleRepository.GetByIdAsync(request.RoleId);
          
            if(role == null)
            {
                msg = request.lang == "en"
                ? "Role not Found"
                : "الدور غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, Responsibility, typeof(UpdateResponsibilityCommand), typeof(Responsibility));
            
            await _responsibilityRepository.UpdateAsync(Responsibility);

            var UserResponsibilities = _responsibilityUser
                .Where(r => r.ResponsibilityId == Responsibility.Id)
                .ToList();

            foreach (var userResponsibility in UserResponsibilities)
            {
                userResponsibility.IsAccept = false;
            }

            await _responsibilityUser.UpdateListAsync(UserResponsibilities);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
