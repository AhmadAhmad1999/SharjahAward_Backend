using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IAsyncRepository<NewsImage> _NewsImageRepository;
        private readonly IMapper _mapper;

        public GetAllNewsQueryHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository,
            IAsyncRepository<NewsImage> NewsImageRepository,
            IMapper mapper)
        {
            _newsRepository = newsRepository;
            _NewsImageRepository = NewsImageRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<NewsListVM>>> Handle(GetAllNewsQuery request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            List<Domain.Entities.NewsModel.News> newsList = new List<Domain.Entities.NewsModel.News>();

            if (request.Descending == false)
            {
                newsList = await _newsRepository
                    .OrderByDescending(filterObject, x => x.CreatedAt, request.page, request.perPage)
                    .ToListAsync();
            }
            else
            {
                var AllNews = await _newsRepository
                    .GetFilterThenPagedReponseAsync(filterObject, request.page, request.perPage);

                newsList = AllNews.OrderBy(x => x.CreatedAt)
                    .Skip((request.page - 1) * request.perPage).Take(request.perPage)
                    .ToList();
            }

            int count = _newsRepository.WhereThenFilter(n => !n.IsHidden, filterObject).Count();

            Pagination pagination = new Pagination(request.page, request.perPage, count);

            if (!request.query.IsNullOrEmpty())
            {
                newsList = request.Descending == true
                    ? await _newsRepository
                        .Where(n => n.EnglishTitle.ToLower().Contains(request.query!.ToLower()))
                        .OrderByDescending(x => x.CreatedAt).ToListAsync()

                    : await _newsRepository
                        .Where(n => n.EnglishTitle.ToLower().Contains(request.query!.ToLower()))
                        .OrderBy(x => x.CreatedAt).ToListAsync();

                if (newsList.Count() == 0)
                {
                    newsList = request.Descending == true
                        ? await _newsRepository
                            .Where(n => n.ArabicTitle.ToLower().Contains(request.query!.ToLower()))
                            .OrderByDescending(x => x.CreatedAt).ToListAsync()

                        : await _newsRepository
                            .Where(n => n.ArabicTitle.ToLower().Contains(request.query!.ToLower()))
                            .OrderBy(x => x.CreatedAt).ToListAsync();
                }
            }

            var data = _mapper.Map<List<NewsListVM>>(newsList);

            List<NewsImage> AllNewsImageEntities = await _NewsImageRepository
                .Where(x => data.Select(y => y.Id).Contains(x.NewsId))
                .ToListAsync();

            if (data.Count != 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    data[i].Title = request.lang == "en"
                        ? data[i].EnglishTitle
                        : data[i].ArabicTitle;

                    data[i].Description = request.lang == "en"
                        ? data[i].EnglishDescription!
                        : data[i].ArabicDescription!;

                    data[i].Images = _mapper.Map<List<NewsImagesDto>>(AllNewsImageEntities
                        .Where(x => x.NewsId == data[i].Id)
                        .ToList());
                }
            }

            if (!request.query.IsNullOrEmpty())
                return new BaseResponse<List<NewsListVM>>("", true, 200, data);

            return new BaseResponse<List<NewsListVM>>("", true, 200, data, pagination);
        }
    }
}
