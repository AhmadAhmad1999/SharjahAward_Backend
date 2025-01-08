using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.NewsTickerModel;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Queries.GetAllNewsTicker
{
    public class GetAllNewsTickerHandler : IRequestHandler<GetAllNewsTickerQuery, BaseResponse<List<GetAllNewsTickerListVM>>>
    {
        private readonly IAsyncRepository<NewsTicker> _NewsTickerRepository;
        private readonly IMapper _Mapper;
        public GetAllNewsTickerHandler(IAsyncRepository<NewsTicker> _NewsTickerRepository,
            IMapper _Mapper)
        {
            this._NewsTickerRepository = _NewsTickerRepository;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<List<GetAllNewsTickerListVM>>> Handle(GetAllNewsTickerQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            if (Request.isActive is null &&
                string.IsNullOrEmpty(Request.Text))
            {
                List<GetAllNewsTickerListVM> Response = await _NewsTickerRepository
                    .OrderByDescending(FilterObject, x => x.CreatedAt, Request.page, Request.perPage)
                    .Select(x => new GetAllNewsTickerListVM()
                    {
                        Id = x.Id,
                        Text = Request.lang == "en"
                            ? x.EnglishText
                            : x.ArabicText,
                        isActive = x.isActive
                    }).ToListAsync();

                int TotalCount = _NewsTickerRepository.WhereThenFilter(x => true, FilterObject).Count();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllNewsTickerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
            else
            {
                if (Request.page != 0 && Request.perPage != -1)
                {
                    if (Request.isActive is not null &&
                        !string.IsNullOrEmpty(Request.Text))
                    {
                        List<GetAllNewsTickerListVM> Response = await _NewsTickerRepository
                            .WhereThenFilter(x => x.isActive == Request.isActive &&
                                (Request.lang == "en"
                                    ? x.EnglishText.ToLower().StartsWith(Request.Text.ToLower())
                                    : x.ArabicText.ToLower().StartsWith(Request.Text.ToLower())), FilterObject)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .Select(x => new GetAllNewsTickerListVM()
                            {
                                Id = x.Id,
                                Text = Request.lang == "en"
                                    ? x.EnglishText
                                    : x.ArabicText,
                                isActive = x.isActive
                            }).ToListAsync();

                        int TotalCount = _NewsTickerRepository.WhereThenFilter(x => x.isActive == Request.isActive, FilterObject).Count();

                        Pagination PaginationParameter = new Pagination(Request.page,
                            Request.perPage, TotalCount);

                        return new BaseResponse<List<GetAllNewsTickerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
                    }
                    else if (Request.isActive is not null)
                    {
                        List<GetAllNewsTickerListVM> Response = await _NewsTickerRepository
                            .WhereThenFilter(x => x.isActive == Request.isActive, FilterObject)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .Select(x => new GetAllNewsTickerListVM()
                            {
                                Id = x.Id,
                                Text = Request.lang == "en"
                                    ? x.EnglishText
                                    : x.ArabicText,
                                isActive = x.isActive
                            }).ToListAsync();

                        int TotalCount = _NewsTickerRepository.WhereThenFilter(x => x.isActive == Request.isActive, FilterObject).Count();

                        Pagination PaginationParameter = new Pagination(Request.page,
                            Request.perPage, TotalCount);

                        return new BaseResponse<List<GetAllNewsTickerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
                    }
                    else
                    {
                        List<GetAllNewsTickerListVM> Response = await _NewsTickerRepository
                            .WhereThenFilter(x => Request.lang == "en"
                                ? x.EnglishText.ToLower().StartsWith(Request.Text!.ToLower())
                                : x.ArabicText.ToLower().StartsWith(Request.Text!.ToLower()), FilterObject)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .Select(x => new GetAllNewsTickerListVM()
                            {
                                Id = x.Id,
                                Text = Request.lang == "en"
                                    ? x.EnglishText
                                    : x.ArabicText,
                                isActive = x.isActive
                            }).ToListAsync();

                        int TotalCount = _NewsTickerRepository.WhereThenFilter(x => x.isActive == Request.isActive, FilterObject).Count();

                        Pagination PaginationParameter = new Pagination(Request.page,
                            Request.perPage, TotalCount);

                        return new BaseResponse<List<GetAllNewsTickerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
                    }
                }
                else
                {
                    if (Request.isActive is not null &&
                        !string.IsNullOrEmpty(Request.Text))
                    {
                        List<GetAllNewsTickerListVM> Response = await _NewsTickerRepository
                            .WhereThenFilter(x => x.isActive == Request.isActive &&
                                (Request.lang == "en"
                                    ? x.EnglishText.ToLower().StartsWith(Request.Text.ToLower())
                                    : x.ArabicText.ToLower().StartsWith(Request.Text.ToLower())), FilterObject)
                            .Select(x => new GetAllNewsTickerListVM()
                            {
                                Id = x.Id,
                                Text = Request.lang == "en"
                                    ? x.EnglishText
                                    : x.ArabicText,
                                isActive = x.isActive
                            }).ToListAsync();

                        int TotalCount = _NewsTickerRepository.WhereThenFilter(x => x.isActive == Request.isActive, FilterObject).Count();

                        Pagination PaginationParameter = new Pagination(Request.page,
                            Request.perPage, TotalCount);

                        return new BaseResponse<List<GetAllNewsTickerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
                    }
                    else if (Request.isActive is not null)
                    {
                        List<GetAllNewsTickerListVM> Response = await _NewsTickerRepository
                            .WhereThenFilter(x => x.isActive == Request.isActive, FilterObject)
                            .Select(x => new GetAllNewsTickerListVM()
                            {
                                Id = x.Id,
                                Text = Request.lang == "en"
                                    ? x.EnglishText
                                    : x.ArabicText,
                                isActive = x.isActive
                            }).ToListAsync();

                        int TotalCount = _NewsTickerRepository.WhereThenFilter(x => x.isActive == Request.isActive, FilterObject).Count();

                        Pagination PaginationParameter = new Pagination(Request.page,
                            Request.perPage, TotalCount);

                        return new BaseResponse<List<GetAllNewsTickerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
                    }
                    else
                    {
                        List<GetAllNewsTickerListVM> Response = await _NewsTickerRepository
                            .WhereThenFilter(x => Request.lang == "en"
                                ? x.EnglishText.ToLower().StartsWith(Request.Text!.ToLower())
                                : x.ArabicText.ToLower().StartsWith(Request.Text!.ToLower()), FilterObject)
                            .Select(x => new GetAllNewsTickerListVM()
                            {
                                Id = x.Id,
                                Text = Request.lang == "en"
                                    ? x.EnglishText
                                    : x.ArabicText,
                                isActive = x.isActive
                            }).ToListAsync();

                        int TotalCount = _NewsTickerRepository.WhereThenFilter(x => x.isActive == Request.isActive, FilterObject).Count();

                        Pagination PaginationParameter = new Pagination(Request.page,
                            Request.perPage, TotalCount);

                        return new BaseResponse<List<GetAllNewsTickerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
                    }
                }
            }
        }
    }
}
