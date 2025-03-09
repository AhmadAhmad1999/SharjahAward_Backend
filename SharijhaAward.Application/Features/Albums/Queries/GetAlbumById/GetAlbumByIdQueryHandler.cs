using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AlbumModel;

namespace SharijhaAward.Application.Features.Albums.Queries.GetAlbumById
{
    public class GetAlbumByIdQueryHandler
        : IRequestHandler<GetAlbumByIdQuery, BaseResponse<AlbumDto>>
    {
        private readonly IAsyncRepository<Album> _AlbumRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAlbumByIdQueryHandler(IAsyncRepository<Album> _AlbumRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AlbumRepository = _AlbumRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<AlbumDto>> Handle(GetAlbumByIdQuery request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Album? AlbumEntity = await _AlbumRepository.GetByIdAsync(request.Id);

            if (AlbumEntity is null)
            {
                ResponseMessage = request.lang == "en"
                    ? "Album is not found"
                    : "الألبوم غير موجود";

                return new BaseResponse<AlbumDto>(ResponseMessage, false, 404);
            }

            AlbumDto Response = _Mapper.Map<AlbumDto>(AlbumEntity);

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            Response.Title = request.lang == "en"
                ? Response.EnglishTitle
                : Response.ArabicTitle;

            if (Response.ThumbnailUrl.Contains("wwwroot"))
                Response.ThumbnailUrl = (WWWRootFilePath + Response.ThumbnailUrl.Split("wwwroot")[1]).Replace("\\", "/");

            return new BaseResponse<AlbumDto>(ResponseMessage, true, 200, Response);
        }
    }
}
