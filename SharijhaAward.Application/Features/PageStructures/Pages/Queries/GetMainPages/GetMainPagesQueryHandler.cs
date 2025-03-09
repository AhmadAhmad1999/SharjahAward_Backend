using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPages
{
    public class GetMainPagesQueryHandler
        : IRequestHandler<GetMainPagesQuery, BaseResponse<List<MainPageListVM>>>
    {
        private readonly IAsyncRepository<PageStructure> _PageStructureRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetMainPagesQueryHandler(IAsyncRepository<PageStructure> _PageStructureRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._PageStructureRepository = _PageStructureRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<MainPageListVM>>> Handle(GetMainPagesQuery Request, CancellationToken cancellationToken)
        {
            List<PageStructure> PageStructureEntities = new List<PageStructure>();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            if (Request.page != 0 &&
                Request.perPage != -1)
                PageStructureEntities = await _PageStructureRepository
                    .Where(x => x.ParentId == null && !x.IsHide &&
                        x.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InMenu)
                    .OrderBy(x => x.orderId)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToListAsync();
            else
                PageStructureEntities = await _PageStructureRepository
                    .Where(x => x.ParentId == null && !x.IsHide &&
                        x.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InMenu)
                    .OrderBy(x => x.orderId)
                    .ToListAsync();

            List<PageStructure> Childs = await _PageStructureRepository
                .Where(x => x.ParentId != null &&
                    PageStructureEntities.Select(y => y.Id).Any(y => y == x.ParentId))
                .ToListAsync();

            List<MainPageListVM> Response = PageStructureEntities
                .Select(x => new MainPageListVM()
                {
                    Id = x.Id,
                    ArabicTitle = x.ArabicTitle,
                    Deletable = x.Deletable,
                    EnglishTitle = x.EnglishTitle,
                    IconUrl = (!string.IsNullOrEmpty(x.IconUrl)
                        ? (x.IconUrl.Contains("wwwroot")
                            ? (WWWRootFilePath + x.IconUrl.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.IconUrl.Replace("\\", "/"))
                        : null),
                    IsHide = x.IsHide,
                    numberOfSubPages = Childs.Count(y => y.ParentId == x.Id),
                    orderId = x.orderId,
                    PagePostion = x.PagePostion,
                    PageType = x.PageType,
                    RefUrl = x.RefUrl,
                    Slug = x.Slug,
                    Title = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle
                }).ToList();

            int TotalCount = await _PageStructureRepository
                .GetCountAsync(x => x.ParentId == null);

            Pagination pagination = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<MainPageListVM>>(string.Empty, true, 200, Response, pagination);
        }
    }
}
