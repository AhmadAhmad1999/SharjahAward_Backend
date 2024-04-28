using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, BaseResponse<GetUserByIdDto>>
    {
        private readonly IMapper _Mapper;
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public GetUserByIdHandler(IMapper Mapper,
            IUserRepository UserRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _Mapper = Mapper;
            _UserRepository = UserRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<GetUserByIdDto>> Handle(GetUserByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not Found"
                    : "المستخدم غير موجود";

                return new BaseResponse<GetUserByIdDto>(ResponseMessage, false, 404);
            }

            GetUserByIdDto GetUserByIdDto = _Mapper.Map<GetUserByIdDto>(UserEntity);

            GetUserByIdDto.RolesIds = await _UserRoleRepository
                .Where(x => x.UserId == Request.Id)
                .Select(x => x.RoleId)
                .ToListAsync();

            return new BaseResponse<GetUserByIdDto>(ResponseMessage, true, 200, GetUserByIdDto);
        }
    }
}
