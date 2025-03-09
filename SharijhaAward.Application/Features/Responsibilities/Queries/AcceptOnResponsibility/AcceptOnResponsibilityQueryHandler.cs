using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
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

namespace SharijhaAward.Application.Features.Responsibilities.Queries.AcceptOnResponsibility
{
    public class AcceptOnResponsibilityQueryHandler
        : IRequestHandler<AcceptOnResponsibilityQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;
        private readonly IAsyncRepository<ResponsibilityUser> _responsibilityUserRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public AcceptOnResponsibilityQueryHandler(IAsyncRepository<Role> roleRepository, IAsyncRepository<Responsibility> responsibilityRepository, IAsyncRepository<ResponsibilityUser> responsibilityUserRepository, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _responsibilityRepository = responsibilityRepository;
            _responsibilityUserRepository = responsibilityUserRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(AcceptOnResponsibilityQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
           
            if (User == null)
            {
                return new BaseResponse<object>("Un Auth", false, 401);
            }

            var Responsibility = await _responsibilityRepository
                .FirstOrDefaultAsync(r => r.Id == request.ResponsibilityId);

            if(Responsibility == null)
            {
                return new BaseResponse<object>("Responsibility not found", false, 404);
            }
            
            List<ResponsibilityUser> ResponsibilityUserEntitites = await _responsibilityUserRepository
                .Where(x => x.ResponsibilityId == request.ResponsibilityId)
                .ToListAsync();

            if (ResponsibilityUserEntitites.Any(x => x.UserId == User.Id && x.ResponsibilityId == request.ResponsibilityId)!)
            {

                var responsibilityUser = _responsibilityUserRepository.FirstOrDefault(x => x.UserId == User.Id && x.ResponsibilityId == request.ResponsibilityId);
                responsibilityUser!.IsAccept = request.Accept;
                await _responsibilityUserRepository.UpdateAsync(responsibilityUser);

            }
            else
            {
                var ResponsibilityUser = new ResponsibilityUser()
                {
                    IsAccept = request.Accept,
                    UserId = User.Id,
                    ResponsibilityId = Responsibility.Id
                };

                await _responsibilityUserRepository.AddAsync(ResponsibilityUser);
            }

            return new BaseResponse<object>("", true, 200);
        }
    }
}
