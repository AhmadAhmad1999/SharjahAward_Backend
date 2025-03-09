using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.AlbumModel;

namespace SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums
{
    public class GetAllAlbumsQueryHandler
        : IRequestHandler<GetAllAlbumsQuery, BaseResponse<List<AlbumListVm>>>
    {
        private readonly IAsyncRepository<Album> _AlbumRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllAlbumsQueryHandler(IAsyncRepository<Album> _AlbumRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AlbumRepository = _AlbumRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<AlbumListVm>>> Handle(GetAllAlbumsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };
            
            IReadOnlyList<Album> AlbumEntities = await _AlbumRepository
                .GetFilterThenPagedReponseAsync(FilterObject, Request.page, Request.perPage);

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<AlbumListVm> Response = AlbumEntities
                .Select(x => new AlbumListVm()
                {
                    Id = x.Id,
                    ArabicTitle = x.ArabicTitle,
                    EnglishTitle = x.EnglishTitle,
                    Title = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    ThumbnailUrl = x.ThumbnailUrl.Contains("wwwroot")
                        ? (WWWRootFilePath + x.ThumbnailUrl.Split("wwwroot")[1]).Replace("\\", "/")
                        : x.ThumbnailUrl.Replace("\\", "/")
                }).ToList();

            int TotalCount = _AlbumRepository.WhereThenFilter(x => true, FilterObject).Count();
           
            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);
          
            return new BaseResponse<List<AlbumListVm>>(string.Empty, true, 200, Response, Pagination);
        }
    }
}
