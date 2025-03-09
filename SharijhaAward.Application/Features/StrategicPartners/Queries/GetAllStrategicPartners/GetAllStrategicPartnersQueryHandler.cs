using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.StrategicPartnerModel;

namespace SharijhaAward.Application.Features.StrategicPartners.Queries.GetAllStrategicPartners
{
    public class GetAllStrategicPartnersQueryHandler
        : IRequestHandler<GetAllStrategicPartnersQuery, BaseResponse<List<StrategicPartnerListVM>>>
    {
        private readonly IAsyncRepository<StrategicPartner> _StrategicPartnerRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllStrategicPartnersQueryHandler(IAsyncRepository<StrategicPartner> _StrategicPartnerRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._StrategicPartnerRepository = _StrategicPartnerRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<StrategicPartnerListVM>>> 
            Handle(GetAllStrategicPartnersQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<StrategicPartner> StrategicPartnerEntities = await _StrategicPartnerRepository
                .OrderByDescending(FilterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync();

            List<StrategicPartnerListVM> Response = StrategicPartnerEntities
                .Select(x => new StrategicPartnerListVM()
                {
                    Id = x.Id,
                    IsHide = x.IsHide,
                    LogoUrl = x.LogoUrl.Contains("wwwroot")
                        ? (WWWRootFilePath + x.LogoUrl.Split("wwwroot")[1]).Replace("\\", "/")
                        : x.LogoUrl.Replace("\\", "/"),
                    Name = x.Name,
                    orderId = x.orderId,
                    PageId = x.PageId,
                    Url = (!string.IsNullOrEmpty(x.Url)
                        ? (x.Url.Contains("wwwroot")
                            ? (WWWRootFilePath + x.Url.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.Url.Replace("\\", "/"))
                        : null)
                }).ToList();

            int Count = await _StrategicPartnerRepository
                .WhereThenFilter(x => true, FilterObject)
                .CountAsync();

            Pagination Pagination = new Pagination(Request.page, Request.perPage, Count);

            return new BaseResponse<List<StrategicPartnerListVM>>(string.Empty, true, 200, Response, Pagination);
        }
    }
}
