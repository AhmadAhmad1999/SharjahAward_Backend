using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AlbumModel;

namespace SharijhaAward.Application.Features.Albums.Galleries.Queries.GetAllGalleries
{
    public class GetAllGalleriesQueryHandler
        : IRequestHandler<GetAllGalleriesQuery, BaseResponse<List<GalleryListVm>>>
    {
        private readonly IAsyncRepository<Album> _AlbumRepository;
        private readonly IAsyncRepository<Gallery> _GalleryRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllGalleriesQueryHandler(IAsyncRepository<Album> _AlbumRepository,
            IAsyncRepository<Gallery> _GalleryRepository, 
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AlbumRepository = _AlbumRepository;
            this._GalleryRepository = _GalleryRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<GalleryListVm>>> Handle(GetAllGalleriesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Album? AlbumEntity = await _AlbumRepository
                .FirstOrDefaultAsync(x => x.Id == Request.AlbumId);
          
            if (AlbumEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Album is not found"
                    : "الألبوم غير موجود";

                return new BaseResponse<List<GalleryListVm>>(ResponseMessage, false, 404);
            }

            IReadOnlyList<Gallery> GalleriesEntities = await _GalleryRepository
                .GetWhereThenPagedReponseAsync(x => x.AlbumId == AlbumEntity.Id, Request.page, Request.perPage);

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<GalleryListVm> Response = GalleriesEntities
                .Select(x => new GalleryListVm()
                {
                    Id = x.Id,
                    AlbumId = x.AlbumId,
                    AlbumTitle = Request.lang == "en"
                        ? x.Album!.EnglishTitle
                        : x.Album!.ArabicTitle,
                    FileUrl = x.FileUrl.Contains("wwwroot")
                        ? (WWWRootFilePath + x.FileUrl.Split("wwwroot")[1]).Replace("\\", "/")
                        : x.FileUrl.Replace("\\", "/")
                }).ToList();

            int TotalCount = await _GalleryRepository.GetCountAsync(x => x.AlbumId == AlbumEntity.Id);
           
            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);
          
            return new BaseResponse<List<GalleryListVm>>(ResponseMessage, true, 200, Response, Pagination);
        }
    }
}
