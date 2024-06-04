using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
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
            string ResponseMessage = string.Empty;

            List<UserRole> UserRoleEntities = await _UserRoleRepository
                .Include(x => x.User!)
                .Include(x => x.Role!)
                .Where(x => x.User!.isValidAccount)
                .ToListAsync();

            List<GetAllUsersListVM> Users = await _UserRepository
                .Where(x => x.isValidAccount)
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.pageSize)
                .Take(Request.pageSize)
                .Select(x => new GetAllUsersListVM()
                {
                    Id = x.Id,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    CreatedAt = x.CreatedAt,
                    UserRoles = UserRoleEntities
                        .Where(y => y.UserId == x.Id)
                        .Select(y => new GetAllUserRolesDto()
                        {
                            Id = y.RoleId,
                            Name = Request.lang == "en"
                                ? y.Role!.EnglishName
                                : y.Role!.ArabicName
                        }).ToList()
                }).ToListAsync();

            int TotalCount = await _UserRepository.GetCountAsync(x => x.isValidAccount);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllUsersListVM>>(ResponseMessage, true, 200, Users, PaginationParameter);
        }
    }
}
