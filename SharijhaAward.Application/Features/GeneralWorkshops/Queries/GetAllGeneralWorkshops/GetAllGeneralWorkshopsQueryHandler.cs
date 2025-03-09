using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetAllGeneralWorkshops
{
    public class GetAllGeneralWorkshopsQueryHandler
        : IRequestHandler<GetAllGeneralWorkshopsQuery, BaseResponse<List<GeneralWorkshopsListVM>>>
    {
        private readonly IAsyncRepository<GeneralWorkshop> _GeneralWorkshopRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllGeneralWorkshopsQueryHandler(IAsyncRepository<GeneralWorkshop> _GeneralWorkshopRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._GeneralWorkshopRepository = _GeneralWorkshopRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<GeneralWorkshopsListVM>>> 
            Handle(GetAllGeneralWorkshopsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<GeneralWorkshop> GeneralWorkshopEntities = new List<GeneralWorkshop>();

            int TotalCount = 0;

            if (!string.IsNullOrEmpty(Request.query))
            {
                if (Request.page != 0 &&
                    Request.perPage != -1)
                {
                    GeneralWorkshopEntities = await _GeneralWorkshopRepository
                        .WhereThenFilter(x => x.EnglishTitle.ToLower().Contains(Request.query!.ToLower()) ||
                            x.ArabicTitle.ToLower().Contains(Request.query!.ToLower()), FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();

                    TotalCount = await _GeneralWorkshopRepository
                        .WhereThenFilter(x => x.EnglishTitle.ToLower().Contains(Request.query!.ToLower()) ||
                            x.ArabicTitle.ToLower().Contains(Request.query!.ToLower()), FilterObject)
                        .CountAsync();
                }
                else
                {
                    GeneralWorkshopEntities = await _GeneralWorkshopRepository
                        .WhereThenFilter(x => x.EnglishTitle.ToLower().Contains(Request.query!.ToLower()) ||
                            x.ArabicTitle.ToLower().Contains(Request.query!.ToLower()), FilterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .ToListAsync();

                    TotalCount = GeneralWorkshopEntities.Count();
                }
            }
            else
            {
                GeneralWorkshopEntities = await _GeneralWorkshopRepository
                    .OrderByDescending(FilterObject, x => x.CreatedAt, Request.page, Request.perPage)
                    .ToListAsync();

                TotalCount = await _GeneralWorkshopRepository
                    .WhereThenFilter(x => true, FilterObject)
                    .CountAsync();
            }

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<GeneralWorkshopsListVM> Response = GeneralWorkshopEntities
                .Select(x => new GeneralWorkshopsListVM()
                {
                    Title = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription,
                    AgendaImage = (!string.IsNullOrEmpty(x.AgendaImage)
                        ? (x.AgendaImage.Contains("wwwroot")
                            ? (WWWRootFilePath + x.AgendaImage.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.AgendaImage.Replace("\\", "/"))
                        : null),
                    ArabicDescription = x.ArabicDescription,
                    ArabicTitle = x.ArabicTitle,
                    DateOfWorkShop = x.DateOfWorkShop,
                    DayName = x.DayName,
                    EnglishDescription = x.EnglishDescription,
                    EnglishTitle = x.EnglishTitle,
                    Id = x.Id,
                    RegistrationUrl = (!string.IsNullOrEmpty(x.RegistrationUrl)
                        ? (x.RegistrationUrl.Contains("wwwroot")
                            ? (WWWRootFilePath + x.RegistrationUrl.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.RegistrationUrl.Replace("\\", "/"))
                        : null),
                    Thumbnale = (x.Thumbnale.Contains("wwwroot")
                        ? (WWWRootFilePath + x.Thumbnale.Split("wwwroot")[1]).Replace("\\", "/")
                        : x.Thumbnale.Replace("\\", "/")),
                    Time = x.Time,
                    Video = (!string.IsNullOrEmpty(x.Video)
                        ? (x.Video.Contains("wwwroot")
                            ? (WWWRootFilePath + x.Video.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.Video.Replace("\\", "/"))
                        : null)
                }).ToList();

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<GeneralWorkshopsListVM>>(string.Empty, true, 200, Response, Pagination);
        }
    }
}
