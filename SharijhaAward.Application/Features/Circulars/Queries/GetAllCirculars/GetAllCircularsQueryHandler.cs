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
            IMapper Mapper)
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
        }

        public async Task<BaseResponse<CircularListVm>> Handle(GetAllCircularsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token!));

            List<UserRole> UserRoleEntities = await _UserRoleRepository
                .Where(x => x.UserId == UserId)
                .ToListAsync();

            List<CircularDto> AllCirculars = new List<CircularDto>();

            int TotalCount = 0;
            int NumberOfUnRead = 0;

            if (UserRoleEntities.Any(x => x.Role!.HaveFullAccess))
            {
                AllCirculars = _Mapper.Map<List<CircularDto>>(await _CircularRepository
                    .OrderByDescending(FilterObject, x => x.Id, Request.page, Request.perPage)
                    .ToListAsync());

                List<bool> AllCircularsEntities = await _CircularRepository
                    .WhereThenFilter(x => true, FilterObject)
                    .Select(x => x.IsRead)
                    .ToListAsync();

                TotalCount = AllCircularsEntities.Count();
                NumberOfUnRead = AllCircularsEntities.Count(x => !x);
            }
            else if (UserRoleEntities.Any(x => x.Role!.EnglishName == "Coordinator" && x.Role!.ArabicName == "منسق"))
            {
                AllCirculars = _Mapper.Map<List<CircularDto>>(await _CircularCoordinatorRepository
                    .WhereThenFilter(c => c.CoordinatorId == UserId, FilterObject)
                    .Select(x => x.Circular)
                    .ToListAsync());

                TotalCount = AllCirculars.Count();
                NumberOfUnRead = AllCirculars.Where(x => !x.IsRead).Count();

                AllCirculars = AllCirculars
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToList();
            }
            else if (UserRoleEntities.Any(x => x.Role!.EnglishName == "Arbitrator" && x.Role!.ArabicName == "محكم"))
            {
                Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id ==  UserId);

                if (ArbitratorEntity is not null)
                {
                    if (ArbitratorEntity.isChairman)
                    {
                        List<Circular> CircularArbitratorEntities = await _CircularArbitratorRepository
                            .WhereThenFilter(c => c.ArbitratorId == UserId, FilterObject)
                            .Select(x => x.Circular)
                            .ToListAsync();

                        List<Circular> CircularChairmanEntities = await _CircularChairmanRepository
                            .WhereThenFilter(c => c.ChairmanId == UserId, FilterObject)
                            .Select(x => x.Circular)
                            .ToListAsync();

                        AllCirculars = _Mapper.Map<List<CircularDto>>(CircularArbitratorEntities
                            .Concat(CircularChairmanEntities));

                        TotalCount = AllCirculars.Count();
                        NumberOfUnRead = AllCirculars.Where(x => !x.IsRead).Count();

                        AllCirculars = AllCirculars
                            .OrderByDescending(x => x.Id)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToList();
                    }
                    else
                    {
                        AllCirculars = _Mapper.Map<List<CircularDto>>(await _CircularArbitratorRepository
                            .WhereThenFilter(c => c.ArbitratorId == UserId, FilterObject)
                            .Select(x => x.Circular)
                            .ToListAsync());

                        TotalCount = AllCirculars.Count();
                        NumberOfUnRead = AllCirculars.Where(x => !x.IsRead).Count();

                        AllCirculars = AllCirculars
                            .OrderByDescending(x => x.Id)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToList();
                    }
                }
            }

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
