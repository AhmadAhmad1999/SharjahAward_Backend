using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorFormModel;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorsByFormId
{
    public class GetArbitratorsByFormIdQueryHandler
        : IRequestHandler<GetArbitratorsByFormIdQuery, BaseResponse<List<ArbitratorsListVM>>>
    {
        private readonly IAsyncRepository<ArbitratorForm> _arbitratorFormRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetArbitratorsByFormIdQueryHandler(IAsyncRepository<ArbitratorForm> arbitratorFormRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _arbitratorFormRepository = arbitratorFormRepository;
            _providedFormRepository = providedFormRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<ArbitratorsListVM>>> Handle(GetArbitratorsByFormIdQuery request, CancellationToken cancellationToken)
        {
            var adminId = _jwtProvider.GetUserIdFromToken(request.token);

            var Admin = await _userRepository.GetByIdAsync(int.Parse(adminId));
            if (Admin == null)
            {
                return new BaseResponse<List<ArbitratorsListVM>>("UnAuht", false, 401);
            }

            var form = await _providedFormRepository.GetByIdAsync(request.formId);
            if (form == null)
            {
                return new BaseResponse<List<ArbitratorsListVM>>("Form Not Found", false, 404);
            }

            var Arbitrators = await _arbitratorFormRepository
                .Where(a => a.ProvidedFormId == form.Id)
                .Include(f => f.Arbitrator!)
                .Select(f => f.Arbitrator)
                .ToListAsync();
                
            var data = _mapper.Map<List<ArbitratorsListVM>>(Arbitrators);

            return new BaseResponse<List<ArbitratorsListVM>>("", true, 200, data);
        }
    }
}
