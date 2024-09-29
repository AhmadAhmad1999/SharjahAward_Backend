using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Circulars.Queries.GetCircularById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars
{
    public class GetAllCircularsQueryHandler
        : IRequestHandler<GetAllCircularsQuery, BaseResponse<CircularListVm>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IAsyncRepository<CircularArbitrator> _circularArbitratorRepository;
        private readonly IAsyncRepository<CircularCoordinator> _circularCoordinatorRepository;
        private readonly IAsyncRepository<CircularChairman> _circularChairmanRepository;
        private readonly IAsyncRepository<UserRole> _userRoleRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAllCircularsQueryHandler(IAsyncRepository<Role> roleRepository, IAsyncRepository<UserRole> userRoleRepository, IAsyncRepository<Circular> circularRepository, IAsyncRepository<Arbitrator> arbitratorRepository, IAsyncRepository<CircularArbitrator> circularArbitratorRepository, IAsyncRepository<CircularCoordinator> circularCoordinatorRepository, IAsyncRepository<CircularChairman> circularChairmanRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _circularRepository = circularRepository;
            _roleRepository = roleRepository;
            _arbitratorRepository = arbitratorRepository;
            _circularArbitratorRepository = circularArbitratorRepository;
            _circularCoordinatorRepository = circularCoordinatorRepository;
            _circularChairmanRepository = circularChairmanRepository;
            _userRoleRepository = userRoleRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<CircularListVm>> Handle(GetAllCircularsQuery request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            var User = _jwtProvider.GetUserIdFromToken(request.token!);
            if (User == null)
            {
                return new BaseResponse<CircularListVm>("UnAuth", false, 401);
            }

            var Roles = _userRoleRepository
                .Where(u => u.UserId == int.Parse(User))
                .Select(u => u.RoleId)
                .ToList();

            var allCircular = new List<Circular>();

            foreach (var role in Roles)
            {
                var Role = await _roleRepository.GetByIdAsync(role);

                if (Role!.EnglishName == "Coordinator")
                {
                    var Circulars = _circularCoordinatorRepository
                        .WhereThenFilter(c => c.CoordinatorId == int.Parse(User), filterObject)
                        .Select(c => c.Circular)
                        .ToList();

                    allCircular.AddRange(Circulars);
                }
                else if (Role!.EnglishName == "Arbitrator")
                {
                    var Arbitrator = await _arbitratorRepository.GetByIdAsync(int.Parse(User));

                    var Circulars = _circularArbitratorRepository
                        .WhereThenFilter(c => c.ArbitratorId == int.Parse(User), filterObject)
                        .Select(c => c.Circular)
                        .ToList();

                    if (Arbitrator!.isChairman)
                    {
                        var ChairmanCirculars = _circularChairmanRepository
                        .WhereThenFilter(c => c.ChairmanId == int.Parse(User), filterObject)
                        .Select(c => c.Circular)
                        .ToList();

                        allCircular.AddRange(ChairmanCirculars);
                    }
                    allCircular.AddRange(Circulars);
                }
                else if (Role!.EnglishName == "Admin")
                {
                    allCircular = await _circularRepository
                        .OrderByDescending(filterObject, x => x.Id, request.page, request.perPage)
                        .ToListAsync();
                }
            }
            var CircularsList = new CircularListVm()
            {
                Circulars = _mapper.Map<List<CircularDto>>(allCircular),
                NumberOfUnRead = allCircular.Where(c=>c.IsRead).Count()
            };

            int Count = _circularRepository.WhereThenFilter(c => true, filterObject).Count();
           
            Pagination pagination = new Pagination(request.page, request.perPage, Count);
          
            return new BaseResponse<CircularListVm>("", true, 200, CircularsList, pagination);
        }
    }
}
