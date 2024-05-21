using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorFormModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.UnAsignFormToArbitrator
{
    public class UnAsignFormToArbitratorQueryHandler
        : IRequestHandler<UnAsignFormToArbitratorQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IAsyncRepository<ArbitratorForm> _arbitratorFormRepository;
        private readonly IAsyncRepository<UserToken> _userTokenRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public UnAsignFormToArbitratorQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<Arbitrator> arbitratorRepository, IAsyncRepository<ArbitratorForm> arbitratorFormRepository, IAsyncRepository<UserToken> userTokenRepository, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _providedFormRepository = providedFormRepository;
            _arbitratorRepository = arbitratorRepository;
            _arbitratorFormRepository = arbitratorFormRepository;
            _userTokenRepository = userTokenRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(UnAsignFormToArbitratorQuery request, CancellationToken cancellationToken)
        {
            var adminId = _jwtProvider.GetUserIdFromToken(request.token);
            var Admin = await _userRepository.GetByIdAsync(int.Parse(adminId));

            if (Admin == null )
            {
                return new BaseResponse<object>("", false, 401);
            }

            var form = await _providedFormRepository.GetByIdAsync(request.formId);
            if (form == null)
            {
                return new BaseResponse<object>("Form Not Found", false, 404);
            }

            var Arbitrator = await _arbitratorRepository.GetByIdAsync(request.arbitratorId);
            if (Arbitrator == null)
            {
                return new BaseResponse<object>("Coordinator not Found", false, 404);
            }

            var ArbitratorForm = await _arbitratorFormRepository.FirstOrDefaultAsync(c => c.ProvidedFormId == form.Id && c.ArbitratorId == Arbitrator.Id);
            if (ArbitratorForm == null)
            {
                return new BaseResponse<object>("Asign already not exisit", false, 400);
            }

            await _arbitratorFormRepository.DeleteAsync(ArbitratorForm);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
