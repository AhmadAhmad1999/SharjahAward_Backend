using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
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
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };
            
            string ResponseMessage = string.Empty;

            List<GetAllRolesListVM> Roles = _Mapper.Map<List<GetAllRolesListVM>>(await _RoleRepository
                .WhereThenFilter(x => (x.EnglishName != "Arbitrator" && x.ArabicName != "محكم") ||
                    (x.EnglishName != "Coordinator" && x.ArabicName != "منسق"), filterObject)
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.perPage)
                .Take(Request.perPage)
                .ToListAsync());

            int TotalCount = await _RoleRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllRolesListVM>>(ResponseMessage, true, 200, Roles, PaginationParameter);
        }
    }
}
