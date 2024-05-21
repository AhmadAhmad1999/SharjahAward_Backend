using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorFormModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.AsignFormToArbitrator
{
    public class AsignFormToArbitratorQueryHandler
        : IRequestHandler<AsignFormToArbitratorQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IAsyncRepository<ArbitratorForm> _arbitratorFormRepository;
        private readonly IAsyncRepository<UserRole> _userRoleRepository;
        private readonly IAsyncRepository<UserToken> _userTokenRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public AsignFormToArbitratorQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<Arbitrator> arbitratorRepository, IAsyncRepository<ArbitratorForm> arbitratorFormRepository, IAsyncRepository<UserRole> userRoleRepository, IAsyncRepository<UserToken> userTokenRepository, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _providedFormRepository = providedFormRepository;
            _arbitratorRepository = arbitratorRepository;
            _arbitratorFormRepository = arbitratorFormRepository;
            _userRoleRepository = userRoleRepository;
            _userTokenRepository = userTokenRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(AsignFormToArbitratorQuery request, CancellationToken cancellationToken)
        {
            var userId = _jwtProvider.GetUserIdFromToken(request.token);
            var Admin = await _userRepository.FirstOrDefaultAsync(a => a.Id == int.Parse(userId));
            if (Admin == null)
            {
                return new BaseResponse<object>("Un Auth", false, 401);
            }
            var AdminToken = _userTokenRepository.FirstOrDefault(t => t.UserId == int.Parse(userId) && t.Token == request.token);

            //if (AdminToken == null)
            //{
            //    return new BaseResponse<object>("Un Auth", false, 401);
            //}

            if (_userRoleRepository.FirstOrDefault(r => r.UserId == Admin.Id && r.RoleId == 1) == null)
            {
                return new BaseResponse<object>("", false, 400);
            }
            var form = await _providedFormRepository.GetByIdAsync(request.formId);
            if (form == null)
            {
                return new BaseResponse<object>("Form not Found", false, 404);
            }
            var Arbitrator = await _arbitratorRepository.GetByIdAsync(request.arbitratorId);
            if (Arbitrator == null)
            {
                return new BaseResponse<object>("Arbitrator not Found", false, 404);
            }

            var ArbitratorForm = new ArbitratorForm()
            {
                ProvidedFormId = form.Id,
                ArbitratorId = Arbitrator.Id
            };

            await _arbitratorFormRepository.AddAsync(ArbitratorForm);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
