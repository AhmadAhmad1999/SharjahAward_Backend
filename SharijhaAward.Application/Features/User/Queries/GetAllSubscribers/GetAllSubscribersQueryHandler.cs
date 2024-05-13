using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.User.Queries.GetAllSubscribers
{
    public class GetAllSubscribersQueryHandler
        : IRequestHandler<GetAllSubscribersQuery, BaseResponse<List<UserListVm>>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public GetAllSubscribersQueryHandler(IRoleRepository roleRepository, IMapper mapper,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<List<UserListVm>>> Handle(GetAllSubscribersQuery request, CancellationToken cancellationToken)
        {
            var SubscriberRole = await _roleRepository.GetByName("Subscriber");

            if(SubscriberRole == null)
            {
                return new BaseResponse<List<UserListVm>>("faild in roles", false,  400);
            }
            List<Domain.Entities.IdentityModels.User> Subscribers = new List<Domain.Entities.IdentityModels.User>();

            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            if (request.page != 0 && request.pageSize != -1)
                Subscribers = await _UserRoleRepository
                    .Include(x => x.User!, filterObject)
                    .Where(x => x.RoleId == SubscriberRole.Id &&
                        (request.isValidAccount != null 
                            ? x.User!.isValidAccount == request.isValidAccount
                            : true))
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => x.User!)
                    .Skip((request.page - 1) * request.pageSize)
                    .Take(request.pageSize)
                    .ToListAsync();

            else
                Subscribers = await _UserRoleRepository
                    .Include(x => x.User!, filterObject)
                    .Where(x => x.RoleId == SubscriberRole.Id &&
                        (request.isValidAccount != null
                            ? x.User!.isValidAccount == request.isValidAccount
                            : true))
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => x.User!)
                    .ToListAsync();

            var data = _mapper.Map<List<UserListVm>>(Subscribers);

            int Count = await _UserRoleRepository
                .Include(x => x.User!)
                .CountAsync(u => u.RoleId == SubscriberRole.Id && 
                    (request.isValidAccount != null
                        ? u.User!.isValidAccount == request.isValidAccount
                        : true));
            Pagination pagination = new Pagination(request.page, request.pageSize, Count);
            return new BaseResponse<List<UserListVm>>("", true, 200, data, pagination);
        }
    }
}
