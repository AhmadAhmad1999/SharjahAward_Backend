using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.News.Queries.GetNewsById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.NewsModel;

namespace SharijhaAward.Application.Features.News.Queries.GetAllNews
{
    public class GetAllNewsQueryHandler
        : IRequestHandler<GetAllNewsQuery, BaseResponse<List<NewsListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _NewsRepository;
        private readonly IAsyncRepository<NewsImage> _NewsImageRepository;
        private readonly IMapper _Mapper;

        public GetAllNewsQueryHandler(IAsyncRepository<Domain.Entities.NewsModel.News> _NewsRepository,
            IAsyncRepository<NewsImage> _NewsImageRepository,
            IMapper _Mapper)
        {
            this._NewsRepository = _NewsRepository;
            this._NewsImageRepository = _NewsImageRepository;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<List<NewsListVM>>> 
            Handle(GetAllNewsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<Domain.Entities.NewsModel.News> NewsEntities = new List<Domain.Entities.NewsModel.News>();

            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                if (Request.Descending)
                {
                    NewsEntities = await _NewsRepository
                        .WhereThenFilter(x => (Request.DateOnlyFilter != null
                            ? (DateOnly.FromDateTime(x.CreatedAt) == Request.DateOnlyFilter)
                            : true) && (Request.TimeOnlyFilter != null
                                ? (TimeOnly.FromDateTime(x.CreatedAt) == Request.TimeOnlyFilter)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.query) 
                                ? (x.EnglishTitle.ToLower().Contains(Request.query.ToLower()) ||
                                    x.ArabicTitle.ToLower().Contains(Request.query.ToLower()))
                                : true), FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    NewsEntities = await _NewsRepository
                        .WhereThenFilter(x => (Request.DateOnlyFilter != null
                            ? (DateOnly.FromDateTime(x.CreatedAt) == Request.DateOnlyFilter)
                            : true) && (Request.TimeOnlyFilter != null
                                ? (TimeOnly.FromDateTime(x.CreatedAt) == Request.TimeOnlyFilter)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.query)
                                ? (x.EnglishTitle.ToLower().Contains(Request.query.ToLower()) ||
                                    x.ArabicTitle.ToLower().Contains(Request.query.ToLower()))
                                : true), FilterObject)
                        .OrderBy(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }
            }
            else
            {
                if (Request.Descending)
                {
                    NewsEntities = await _NewsRepository
                        .WhereThenFilter(x => (Request.DateOnlyFilter != null
                            ? (DateOnly.FromDateTime(x.CreatedAt) == Request.DateOnlyFilter)
                            : true) && (Request.TimeOnlyFilter != null
                                ? (TimeOnly.FromDateTime(x.CreatedAt) == Request.TimeOnlyFilter)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.query)
                                ? (x.EnglishTitle.ToLower().Contains(Request.query.ToLower()) ||
                                    x.ArabicTitle.ToLower().Contains(Request.query.ToLower()))
                                : true), FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .ToListAsync();
                }
                else
                {
                    NewsEntities = await _NewsRepository
                        .WhereThenFilter(x => (Request.DateOnlyFilter != null
                            ? (DateOnly.FromDateTime(x.CreatedAt) == Request.DateOnlyFilter)
                            : true) && (Request.TimeOnlyFilter != null
                                ? (TimeOnly.FromDateTime(x.CreatedAt) == Request.TimeOnlyFilter)
                                : true) &&
                            (!string.IsNullOrEmpty(Request.query)
                                ? (x.EnglishTitle.ToLower().Contains(Request.query.ToLower()) ||
                                    x.ArabicTitle.ToLower().Contains(Request.query.ToLower()))
                                : true), FilterObject)
                        .OrderBy(x => x.CreatedAt)
                        .ToListAsync();
                }
            }

            List<NewsImage> NewsImageEntities = await _NewsImageRepository
                .Where(x => NewsEntities.Select(y => y.Id).Contains(x.NewsId))
                .ToListAsync();

            List<NewsListVM> Response = NewsEntities
                .Select(x => new NewsListVM()
                {
                    Images = _Mapper.Map<List<NewsImagesDto>>(NewsImageEntities
                        .Where(y => y.NewsId == x.Id)
                        .ToList()),
                    Title = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    ArabicTitle = x.ArabicTitle,
                    EnglishTitle = x.EnglishTitle,
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    ArabicDescription = x.ArabicDescription,
                    CreatedAt = x.CreatedAt,
                    Id = x.Id,
                    Image = x.Image,
                    IsHidden = x.IsHidden,
                    NewsDate = x.NewsDate
                }).ToList();

            int TotalCount = await _NewsRepository
                .WhereThenFilter(x => (Request.DateOnlyFilter != null
                    ? (DateOnly.FromDateTime(x.CreatedAt) == Request.DateOnlyFilter)
                    : true) && (Request.TimeOnlyFilter != null
                        ? (TimeOnly.FromDateTime(x.CreatedAt) == Request.TimeOnlyFilter)
                        : true) &&
                    (!string.IsNullOrEmpty(Request.query)
                        ? (x.EnglishTitle.ToLower().Contains(Request.query.ToLower()) ||
                            x.ArabicTitle.ToLower().Contains(Request.query.ToLower()))
                        : true), FilterObject)
                    .CountAsync();

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<NewsListVM>>(string.Empty, true, 200, Response, Pagination);
        }
    }
}
