using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.UnAsignFormToCoordinator
{
    public class UnAsignFormToCoordinatorQueryHandler
        : IRequestHandler<UnAsignFormToCoordinatorQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<CoordinatorForm> _coordinatorFormRepository;
        private readonly IAsyncRepository<UserToken> _userTokenRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public UnAsignFormToCoordinatorQueryHandler(IAsyncRepository<CoordinatorForm> coordinatorFormRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<UserToken> userTokenRepository, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _providedFormRepository = providedFormRepository;
            _coordinatorRepository = coordinatorRepository;
            _coordinatorFormRepository = coordinatorFormRepository;
            _userTokenRepository = userTokenRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(UnAsignFormToCoordinatorQuery request, CancellationToken cancellationToken)
        {
            var adminId = _jwtProvider.GetUserIdFromToken(request.token);
            var Admin = await _userRepository.GetByIdAsync(int.Parse(adminId));
        
            if(Admin == null)
            {
                return new BaseResponse<object>("", false, 401);
            }

            var form = await _providedFormRepository.GetByIdAsync(request.formId);
            if(form == null)
            {
                return new BaseResponse<object>("Form Not Found", false, 404);
            }

            var coordinator = await _coordinatorRepository.GetByIdAsync(request.coordinatorId);    
            if(coordinator == null)
            {
                return new BaseResponse<object>("Coordinator not Found", false, 404);
            }

            var coordinatorForm = await _coordinatorFormRepository.FirstOrDefaultAsync(c => c.ProvidedFormId == form.Id && c.CoordinatorId == coordinator.Id);
            if(coordinatorForm == null)
            {
                return new BaseResponse<object>("Asign already not exisit", false, 400);
            }

            await _coordinatorFormRepository.DeleteAsync(coordinatorForm);

            return new BaseResponse<object>("", true, 200);
            
        }
    }
}
