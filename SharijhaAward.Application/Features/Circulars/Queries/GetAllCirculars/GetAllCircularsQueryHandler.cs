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
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars
{
    public class GetAllCircularsQueryHandler
        : IRequestHandler<GetAllCircularsQuery, BaseResponse<CircularListVm>>
    {
        private readonly IAsyncRepository<Circular> _CircularRepository;
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CircularArbitrator> _CircularArbitratorRepository;
        private readonly IAsyncRepository<CircularCoordinator> _CircularCoordinatorRepository;
        private readonly IAsyncRepository<CircularChairman> _CircularChairmanRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<CircularUser> _CircularUserRepository;
        private readonly IAsyncRepository<CiruclarSubcommitteeOfficer> _CiruclarSubcommitteeOfficerRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;

        public GetAllCircularsQueryHandler(IAsyncRepository<Role> RoleRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<Circular> CircularRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CircularArbitrator> CircularArbitratorRepository,
            IAsyncRepository<CircularCoordinator> CircularCoordinatorRepository,
            IAsyncRepository<CircularChairman> CircularChairmanRepository,
            IJwtProvider JwtProvider,
            IMapper Mapper,
            IAsyncRepository<CircularUser> _CircularUserRepository,
            IAsyncRepository<CiruclarSubcommitteeOfficer> _CiruclarSubcommitteeOfficerRepository)
        {
            _CircularRepository = CircularRepository;
            _RoleRepository = RoleRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _CircularArbitratorRepository = CircularArbitratorRepository;
            _CircularCoordinatorRepository = CircularCoordinatorRepository;
            _CircularChairmanRepository = CircularChairmanRepository;
            _UserRoleRepository = UserRoleRepository;
            _JwtProvider = JwtProvider;
            _Mapper = Mapper;
            this._CircularUserRepository = _CircularUserRepository;
            this._CiruclarSubcommitteeOfficerRepository = _CiruclarSubcommitteeOfficerRepository;
        }

        public async Task<BaseResponse<CircularListVm>> Handle(GetAllCircularsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token!));

            List<UserRole> UserRoleEntities = await _UserRoleRepository
                .Where(x => x.UserId == UserId)
                .ToListAsync();

            List<CircularArbitrator> CircularArbitratorEntities = await _CircularArbitratorRepository
                .Where(x => x.ArbitratorId == UserId)
                .ToListAsync();

            List<CircularChairman> CircularChairmanEntities = await _CircularChairmanRepository
                .Where(x => x.ChairmanId == UserId)
                .ToListAsync();

            List<CircularCoordinator> CircularCoordinatorEntities = await _CircularCoordinatorRepository
                .Where(x => x.CoordinatorId == UserId)
                .ToListAsync();

            List<CiruclarSubcommitteeOfficer> CiruclarSubcommitteeOfficerEntities = await _CiruclarSubcommitteeOfficerRepository
                .Where(x => x.SubcommitteeOfficerId == UserId)
                .ToListAsync();

            List<CircularUser> CircularUserEntitites = await _CircularUserRepository
                .Where(x => x.UserRole!.UserId == UserId)
                .ToListAsync();

            List<int> AllCircularIds =
            [
                .. CircularArbitratorEntities.Select(x => x.CircularId),
                .. CircularChairmanEntities.Select(x => x.CircularId),
                .. CircularCoordinatorEntities.Select(x => x.CircularId),
                .. CiruclarSubcommitteeOfficerEntities.Select(x => x.CircularId),
                .. CircularUserEntitites.Select(x => x.CircularId)
            ];

            int TotalCount = AllCircularIds
                .Distinct()
                .Count();
            
            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                AllCircularIds = AllCircularIds
                    .Distinct()
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToList();
            }

            int NumberOfUnRead = CircularArbitratorEntities.Count(x => !x.IsRead) +
                CircularChairmanEntities.Count(x => !x.IsRead) +
                CircularCoordinatorEntities.Count(x => !x.IsRead) +
                CiruclarSubcommitteeOfficerEntities.Count(x => !x.IsRead) +
                CircularUserEntitites.Count(x => !x.IsRead);

            CircularArbitratorEntities = CircularArbitratorEntities
                .Where(x => AllCircularIds.Contains(x.CircularId))
                .ToList();

            List<CircularDto> AllCirculars = await _CircularRepository
                .Where(x => AllCircularIds.Contains(x.Id))
                .Select(x => new CircularDto()
                {
                    Id = x.Id,
                    Title = x.Title,
                    IsRead = CircularArbitratorEntities.Any(y => y.CircularId == x.Id)
                        ? CircularArbitratorEntities.FirstOrDefault(y => y.CircularId == x.Id)!.IsRead
                        : (CircularChairmanEntities.Any(y => y.CircularId == x.Id)
                            ? CircularChairmanEntities.FirstOrDefault(y => y.CircularId == x.Id)!.IsRead
                            : (CircularCoordinatorEntities.Any(y => y.CircularId == x.Id)
                                ? CircularCoordinatorEntities.FirstOrDefault(y => y.CircularId == x.Id)!.IsRead
                                : (CiruclarSubcommitteeOfficerEntities.Any(y => y.CircularId == x.Id)
                                    ? CiruclarSubcommitteeOfficerEntities.FirstOrDefault(y => y.CircularId == x.Id)!.IsRead
                                    : (CircularUserEntitites.Any(y => y.CircularId == x.Id)
                                        ? CircularUserEntitites.FirstOrDefault(y => y.CircularId == x.Id)!.IsRead
                                        : false)))),
                    CircularText = x.CircularText,
                    CreatedAt = x.CreatedAt,
                    CreatedBy = x.CreatedBy
                }).ToListAsync();

            CircularListVm Response = new CircularListVm()
            {
                Circulars = AllCirculars,
                NumberOfUnRead = NumberOfUnRead
            };

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<CircularListVm>(ResponseMessage, true, 200, Response, Pagination);
        }
    }
}
