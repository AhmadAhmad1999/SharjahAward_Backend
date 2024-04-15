using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetAllRoles
{
    public class GetAllRolesHandler : IRequestHandler<GetAllRolesQuery, BaseResponse<List<GetAllRolesListVM>>>
    {
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IMapper _Mapper;
        public GetAllRolesHandler(IAsyncRepository<Role> RoleRepository,
            IMapper Mapper)
        {
            _RoleRepository = RoleRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllRolesListVM>>> Handle(GetAllRolesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllRolesListVM> Roles = _Mapper.Map<List<GetAllRolesListVM>>(await _RoleRepository
                .GetPagedReponseAsync(Request.page, Request.pageSize));

            int TotalCount = await _RoleRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllRolesListVM>>(ResponseMessage, true, 200, Roles, PaginationParameter);
        }
    }
}
