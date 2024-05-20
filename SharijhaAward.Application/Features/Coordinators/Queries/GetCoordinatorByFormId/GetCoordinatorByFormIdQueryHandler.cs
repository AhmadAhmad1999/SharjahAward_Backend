using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorByFormId
{
    public class GetCoordinatorByFormIdQueryHandler
        : IRequestHandler<GetCoordinatorByFormIdQuery, BaseResponse<List<CoordinatorsListVM>>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<CoordinatorForm> _coordinatorFormRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetCoordinatorByFormIdQueryHandler(IMapper mapper, IUserRepository userRepository, IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<CoordinatorForm> coordinatorFormRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IJwtProvider jwtProvider)
        {
            _coordinatorRepository = coordinatorRepository;
            _coordinatorFormRepository = coordinatorFormRepository;
            _providedFormRepository = providedFormRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CoordinatorsListVM>>> Handle(GetCoordinatorByFormIdQuery request, CancellationToken cancellationToken)
        {
            var adminId = _jwtProvider.GetUserIdFromToken(request.token);
            
            var Admin = await _userRepository.GetByIdAsync(int.Parse(adminId));
            if(Admin == null)
            {
                return new BaseResponse<List<CoordinatorsListVM>>("UnAuht", false, 401);
            }

            var form = await _coordinatorFormRepository.GetByIdAsync(request.formId);
            if(form == null)
            {
                return new BaseResponse<List<CoordinatorsListVM>>("Form Not Found", false, 404);
            }

            var Coordinators = await _coordinatorFormRepository
                .Where(x => x.ProvidedFormId == request.formId)
                .Include(x => x.Coordinator!)
                .Select(x => x.Coordinator!)
                .ToListAsync();

            var data = _mapper.Map<List<CoordinatorsListVM>>(Coordinators);

            return new BaseResponse<List<CoordinatorsListVM>>("", true, 200, data);


        }
    }
}
