using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.CoordinatorProvidedFormModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.AsignFormToCoordinator
{
    public class AsignFormToCoordinatorQueryHandler
        : IRequestHandler<AsignFormToCoordinatorQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IUserRepository _userRepository;
        private readonly IAsyncRepository<UserRole> _userRoleRepository;
        private readonly IAsyncRepository<UserToken> _userTokenRepository;
        private readonly IAsyncRepository<CoordinatorForm> _coordinatorProvidedFormRepository;

        public AsignFormToCoordinatorQueryHandler(IAsyncRepository<CoordinatorForm> coordinatorProvidedFormRepository, IAsyncRepository<UserToken> userTokenRepository, IAsyncRepository<UserRole> userRoleRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<Coordinator> coordinatorRepository, IJwtProvider jwtProvider, IUserRepository userRepository)
        {
            _providedFormRepository = providedFormRepository;
            _coordinatorRepository = coordinatorRepository;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _userTokenRepository = userTokenRepository;
            _coordinatorProvidedFormRepository = coordinatorProvidedFormRepository;
        }

        public async Task<BaseResponse<object>> Handle(AsignFormToCoordinatorQuery request, CancellationToken cancellationToken)
        {
            var userId =  _jwtProvider.GetUserIdFromToken(request.token);
            var Admin = await _userRepository.FirstOrDefaultAsync(a => a.Id == int.Parse(userId));
            if(Admin == null)
            {
                return new BaseResponse<object>("Un Auth", false, 401);
            }
            var AdminToken = _userTokenRepository.FirstOrDefault(t => t.UserId == int.Parse(userId) && t.Token == request.token);
            
            if(AdminToken == null)
            {
                return new BaseResponse<object>("Un Auth", false, 401);
            }

            if( _userRoleRepository.FirstOrDefault(r => r.UserId == Admin.Id && r.RoleId == 1) == null)
            {
                return new BaseResponse<object>("", false, 400);
            }
            var form = await _providedFormRepository.GetByIdAsync(request.formId);
            if(form == null)
            {
                return new BaseResponse<object>("Form not Found", false, 404);
            }
            var coordinator = await _coordinatorRepository.GetByIdAsync(request.coordinatorId);
            if(coordinator == null)
            {
                return new BaseResponse<object>("Coordinator not Found", false, 404);
            }

            var CoordinatorForm = new CoordinatorForm()
            {
                ProvidedFormId = form.Id,
                CoordinatorId = coordinator.Id
            };

            await _coordinatorProvidedFormRepository.AddAsync(CoordinatorForm);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
