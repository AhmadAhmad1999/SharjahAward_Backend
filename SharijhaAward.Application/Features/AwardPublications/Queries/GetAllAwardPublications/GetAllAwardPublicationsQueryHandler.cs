using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.GetAllAwardPublications
{
    public class GetAllAwardPublicationsQueryHandler
        : IRequestHandler<GetAllAwardPublicationsQuery, BaseResponse<List<AwardPublicationListVM>>>
    {
        private readonly IAsyncRepository<AwardPublication> _AwardPublicationRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllAwardPublicationsQueryHandler(IAsyncRepository<AwardPublication> _AwardPublicationRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AwardPublicationRepository = _AwardPublicationRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<AwardPublicationListVM>>> Handle(GetAllAwardPublicationsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<AwardPublication> AwardPublications = await _AwardPublicationRepository
                .OrderByDescending(FilterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync();

            List<AwardPublicationListVM> Response = AwardPublications
                .Select(x =>
                {
                    bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                    string WWWRootFilePath = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                    string ImageUrl = x.ImageUrl.Contains("wwwroot")
                        ? (WWWRootFilePath + x.ImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                        : x.ImageUrl.Replace("\\", "/");

                    string PublicationUrl = x.PublicationUrl.Contains("wwwroot")
                        ? (WWWRootFilePath + x.PublicationUrl.Split("wwwroot")[1]).Replace("\\", "/")
                        : x.PublicationUrl.Replace("\\", "/");

                    return new AwardPublicationListVM()
                    {
                        Id = x.Id,
                        AutherName = x.AutherName,
                        Title = x.Title,
                        ImageUrl = ImageUrl,
                        PublicationUrl = PublicationUrl
                    };
                }).ToList();

            int TotalCount = await _AwardPublicationRepository
                .WhereThenFilter(x => true, FilterObject)
                .CountAsync();
            
            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<AwardPublicationListVM>>(string.Empty, true, 200, Response, Pagination);
        }
    }
}
