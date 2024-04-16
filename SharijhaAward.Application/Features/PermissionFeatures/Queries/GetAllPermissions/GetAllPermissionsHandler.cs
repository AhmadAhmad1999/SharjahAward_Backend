using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.PermissionFeatures.Queries.GetAllPermissions
{
    public class GetAllPermissionsHandler : IRequestHandler<GetAllPermissionsQuery, BaseResponse<List<GetAllPermissionsListVM>>>
    {
        private readonly IAsyncRepository<Permission> _PermissionRepository;
        private readonly IMapper _Mapper;
        public GetAllPermissionsHandler(IAsyncRepository<Permission> PermissionRepository,
            IMapper Mapper)
        {
            _PermissionRepository = PermissionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllPermissionsListVM>>> Handle(GetAllPermissionsQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<IGrouping<PermissionHeader, Permission>> ListOfGroupOfPermissionsHeaderAndPermissions = await _PermissionRepository
                .Include(x => x.PermissionHeader!)
                .GroupBy(x => x.PermissionHeader!)
                .ToListAsync();

            List<GetAllPermissionsListVM> Response = new List<GetAllPermissionsListVM>();

            foreach (IGrouping<PermissionHeader, Permission> GroupOfPermissionsHeaderAndPermissions 
                in ListOfGroupOfPermissionsHeaderAndPermissions)
            {
                Response.Add(new GetAllPermissionsListVM()
                {
                    Name = GroupOfPermissionsHeaderAndPermissions.Key!.Name,
                    Permissions = _Mapper.Map<List<PermissionListVM>>(GroupOfPermissionsHeaderAndPermissions
                        .Where(y => y.PermissionHeaderId == GroupOfPermissionsHeaderAndPermissions.Key!.Id).ToList())
                });
            }

            return new BaseResponse<List<GetAllPermissionsListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
