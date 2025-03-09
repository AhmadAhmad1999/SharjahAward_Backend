using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.CustomPageConstants;
using SharijhaAward.Domain.Entities.PageStructureModel;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages
{
    public class GetMainPagesWithSubPagesQueryHandler
        : IRequestHandler<GetMainPagesWithSubPagesQuery, BaseResponse<GetMainPagesWithSubPagesResponse>>
    {
        private readonly IAsyncRepository<PageStructure> _PageStructureRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetMainPagesWithSubPagesQueryHandler(IAsyncRepository<PageStructure> _PageStructureRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._PageStructureRepository = _PageStructureRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<GetMainPagesWithSubPagesResponse>> Handle(GetMainPagesWithSubPagesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<PageStructure> AllMainPages = await _PageStructureRepository
                .Where(x => x.ParentId == null &&
                    (Request.intoWebsite!.Value
                        ? !x.IsHide
                        : true))
                .ToListAsync();

            IEnumerable<PageStructure> SubPages = await _PageStructureRepository
                .Where(x => x.ParentId != null &&
                    (Request.intoWebsite!.Value
                        ? !x.IsHide
                        : true))
                .OrderBy(x => x.orderId)
                .ToListAsync();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            GetMainPagesWithSubPagesResponse Response = new GetMainPagesWithSubPagesResponse()
            {
                InsideCells = AllMainPages
                    .Where(x => x.PagePostion == PagePostion.InCells)
                    .Select(x => new MainPageWithSubPageListVM()
                    {
                        Id = x.Id,
                        IconUrl = (!string.IsNullOrEmpty(x.IconUrl)
                            ? (x.IconUrl.Contains("wwwroot")
                                ? (WWWRootFilePath + x.IconUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.IconUrl.Replace("\\", "/"))
                            : null),
                        Title = Request.lang == "en"
                            ? x.EnglishTitle
                            : x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle,
                        ArabicTitle = x.ArabicTitle,
                        IsHide = x.IsHide,
                        Slug = x.Slug,
                        RefUrl = x.RefUrl,
                        PageType = x.PageType,
                        PagePostion = x.PagePostion,
                        orderId = x.orderId,
                        Deletable = x.Deletable,
                        SubPages = new List<SubPageListVM>()
                    })
                    .OrderBy(x => x.orderId)
                    .ToList(),
                OutsideCells = AllMainPages
                    .Where(x => x.PagePostion == PagePostion.InMenu)
                    .Select(x => new MainPageWithSubPageListVM()
                    {
                        Id = x.Id,
                        IconUrl = (!string.IsNullOrEmpty(x.IconUrl)
                            ? (x.IconUrl.Contains("wwwroot")
                                ? (WWWRootFilePath + x.IconUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.IconUrl.Replace("\\", "/"))
                            : null),
                        Title = Request.lang == "en"
                            ? x.EnglishTitle
                            : x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle,
                        ArabicTitle = x.ArabicTitle,
                        IsHide = x.IsHide,
                        Slug = x.Slug,
                        RefUrl = x.RefUrl,
                        PageType = x.PageType,
                        PagePostion = x.PagePostion,
                        orderId = x.orderId,
                        Deletable = x.Deletable,
                        SubPages = SubPages
                            .Where(y => y.ParentId == x.Id)
                            .Select(y => new SubPageListVM()
                            {
                                Id = y.Id,
                                Title = Request.lang == "en"
                                    ? y.EnglishTitle
                                    : y.ArabicTitle,
                                EnglishTitle = y.EnglishTitle,
                                ArabicTitle = y.ArabicTitle,
                                ParentId = y.ParentId!.Value,
                                Slug = y.Slug,
                                RefUrl = y.RefUrl,
                                IsHide = y.IsHide,
                                PageType = y.PageType,
                                PagePostion = y.PagePostion,
                                orderId = y.orderId,
                                Deletable = y.Deletable
                            })
                            .OrderBy(x => x.orderId)
                            .ToList()
                    })
                    .OrderBy(x => x.orderId)
                    .ToList()
            };

            return new BaseResponse<GetMainPagesWithSubPagesResponse>(ResponseMessage, true, 200, Response);
        }
    }
}
