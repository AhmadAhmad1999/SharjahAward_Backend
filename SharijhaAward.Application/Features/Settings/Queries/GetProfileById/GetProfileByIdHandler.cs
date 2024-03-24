using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Queries.GetProfileById
{
    public class GetProfileByIdHandler : IRequestHandler<GetProfileByIdQuery, BaseResponse<GetProfileByIdDto>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _Mapper;

        public GetProfileByIdHandler(IMapper Mapper,
            IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetProfileByIdDto>> Handle(GetProfileByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Profile is not found"
                    : "الملف الشخصي غير موجود";

                return new BaseResponse<GetProfileByIdDto>(ResponseMessage, false, 404);
            }

            GetProfileByIdDto GetProfileByIdDto = _Mapper.Map<GetProfileByIdDto>(UserEntity);

            return new BaseResponse<GetProfileByIdDto>(ResponseMessage, true, 200, GetProfileByIdDto);
        }
    }
}
