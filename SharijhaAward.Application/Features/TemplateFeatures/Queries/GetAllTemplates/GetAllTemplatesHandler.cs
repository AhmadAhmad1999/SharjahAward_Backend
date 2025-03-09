using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Queries.GetAllTemplates
{
    public class GetAllTemplatesHandler : IRequestHandler<GetAllTemplatesQuery, BaseResponse<List<GetAllTemplatesListVM>>>
    {
        private readonly IAsyncRepository<Template> _TemplateRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllTemplatesHandler(IAsyncRepository<Template> _TemplateRepository,
            IMapper Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._TemplateRepository = _TemplateRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllTemplatesListVM>>> Handle(GetAllTemplatesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            if (Request.isActive is not null)
            {
                if (Request.page != 0 && Request.perPage != -1)
                {
                    List<GetAllTemplatesListVM> GetAllTemplatesListVM = _TemplateRepository
                        .WhereThenFilter(x => x.isActive == Request.isActive &&
                            (Request.TemplateType != null ? x.TemplateType == Request.TemplateType : true), FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList()
                        .Select(x =>
                        {
                            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                            string WWWRootFilePath = isHttps
                                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                            return new GetAllTemplatesListVM()
                            {
                                Id = x.Id,
                                BackgroundImageUrl = !string.IsNullOrEmpty(x.BackgroundImageUrl)
                                    ? (x.BackgroundImageUrl.Contains("wwwroot")
                                        ? (WWWRootFilePath + x.BackgroundImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                        : x.BackgroundImageUrl.Replace("\\", "/"))
                                    : string.Empty,
                                TemplateVersion = x.TemplateVersion,
                                FontColor = x.FontColor,
                                TemplateType = x.TemplateType,
                                isActive = x.isActive
                            };
                        }).ToList();

                    int TotalCount = await _TemplateRepository
                        .WhereThenFilter(x => x.isActive == Request.isActive &&
                            (Request.TemplateType != null ? x.TemplateType == Request.TemplateType : true), FilterObject)
                        .CountAsync();

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<List<GetAllTemplatesListVM>>(ResponseMessage, true, 200, GetAllTemplatesListVM, PaginationParameter);
                }
                else
                {
                    List<GetAllTemplatesListVM> GetAllTemplatesListVM = _TemplateRepository
                        .WhereThenFilter(x => x.isActive == Request.isActive &&
                            (Request.TemplateType != null ? x.TemplateType == Request.TemplateType : true), FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .ToList()
                        .Select(x =>
                        {
                            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                            string WWWRootFilePath = isHttps
                                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                            return new GetAllTemplatesListVM()
                            {
                                Id = x.Id,
                                BackgroundImageUrl = !string.IsNullOrEmpty(x.BackgroundImageUrl)
                                    ? (x.BackgroundImageUrl.Contains("wwwroot")
                                        ? (WWWRootFilePath + x.BackgroundImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                        : x.BackgroundImageUrl.Replace("\\", "/"))
                                    : string.Empty,
                                TemplateVersion = x.TemplateVersion,
                                FontColor = x.FontColor,
                                TemplateType = x.TemplateType,
                                isActive = x.isActive
                            };
                        }).ToList();

                    int TotalCount = await _TemplateRepository
                        .WhereThenFilter(x => x.isActive == Request.isActive &&
                            (Request.TemplateType != null ? x.TemplateType == Request.TemplateType : true), FilterObject)
                        .CountAsync();

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<List<GetAllTemplatesListVM>>(ResponseMessage, true, 200, GetAllTemplatesListVM, PaginationParameter);
                }
            }
            else
            {
                List<GetAllTemplatesListVM> GetAllTemplatesListVM = _TemplateRepository
                    .WhereThenFilter(x => Request.TemplateType != null ? x.TemplateType == Request.TemplateType : true, FilterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.page)
                    .Take(Request.perPage)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new GetAllTemplatesListVM()
                        {
                            Id = x.Id,
                            BackgroundImageUrl = !string.IsNullOrEmpty(x.BackgroundImageUrl)
                                ? (x.BackgroundImageUrl.Contains("wwwroot")
                                    ? (WWWRootFilePath + x.BackgroundImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                    : x.BackgroundImageUrl.Replace("\\", "/"))
                                : string.Empty,
                            TemplateVersion = x.TemplateVersion,
                            FontColor = x.FontColor,
                            TemplateType = x.TemplateType,
                            isActive = x.isActive
                        };
                    }).ToList();

                int TotalCount = await _TemplateRepository
                    .WhereThenFilter(x => Request.TemplateType != null ? x.TemplateType == Request.TemplateType : true, FilterObject)
                    .CountAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllTemplatesListVM>>(ResponseMessage, true, 200, GetAllTemplatesListVM, PaginationParameter);
            }
        }
    }
}
