using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Queries.GetProfileById
{
    public class GetProfileByIdHandler : IRequestHandler<GetProfileByIdQuery, BaseResponse<GetProfileByIdDto>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetProfileByIdHandler(IMapper Mapper,
            IUserRepository UserRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            _UserRepository = UserRepository;
            _Mapper = Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
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

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            if (!string.IsNullOrEmpty(GetProfileByIdDto.ImageURL))
            {
                GetProfileByIdDto.ImageURL = GetProfileByIdDto.ImageURL.Contains("wwwroot")
                    ? (WWWRootFilePath + GetProfileByIdDto.ImageURL.Split("wwwroot")[1]).Replace("\\", "/")
                    : GetProfileByIdDto.ImageURL.Replace("\\", "/");
            }

            return new BaseResponse<GetProfileByIdDto>(ResponseMessage, true, 200, GetProfileByIdDto);
        }
    }
}
