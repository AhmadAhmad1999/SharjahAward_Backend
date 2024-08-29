using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public class GetAllUsersHandler 
        : IRequestHandler<GetAllUsersQuery, BaseResponse<List<GetAllUsersListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public GetAllUsersHandler(IMapper Mapper,
            IUserRepository UserRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _Mapper = Mapper;
            _UserRepository = UserRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<List<GetAllUsersListVM>>> Handle(GetAllUsersQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            List<UserRole> UserRoleEntities = await _UserRoleRepository
                .Where(x => x.User!.isValidAccount)
                .ToListAsync();

            List<GetAllUsersListVM> Users = await _UserRepository
                .WhereThenFilter(x => x.isValidAccount && x.SubscriberId == null, filterObject)
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.perPage)
                .Take(Request.perPage)
                .Select(x => new GetAllUsersListVM()
                {
                    Id = x.Id,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    CreatedAt = x.CreatedAt
                }).ToListAsync();

            foreach (GetAllUsersListVM User in Users)
            {
                User.UserRoles = UserRoleEntities
                    .Where(x => x.UserId == User.Id)
                    .Select(x => new GetAllUserRolesDto()
                    {
                        Id = x.RoleId,
                        Name = Request.lang == "en"
                            ? x.Role!.EnglishName
                            : x.Role!.ArabicName
                    }).ToList();
            }

            int TotalCount = await _UserRepository.GetCountAsync(x => x.isValidAccount);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllUsersListVM>>(ResponseMessage, true, 200, Users, PaginationParameter);
        }
    }
}
