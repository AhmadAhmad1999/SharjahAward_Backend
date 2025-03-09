using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetAllDigitalSignaturesForUser
{
    public class GetAllDigitalSignaturesForUserHandler : IRequestHandler<GetAllDigitalSignaturesForUserQuery, BaseResponse<List<GetAllDigitalSignaturesForUserListVM>>>
    {
        private readonly IAsyncRepository<DigitalSignature> _DigitalSignatureRepository;
        private readonly IMapper _Mapper;
        private readonly IJwtProvider _JwtProvider;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllDigitalSignaturesForUserHandler(IAsyncRepository<DigitalSignature> _DigitalSignatureRepository,
            IMapper _Mapper,
            IJwtProvider _JwtProvider,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._DigitalSignatureRepository = _DigitalSignatureRepository;
            this._Mapper = _Mapper;
            this._JwtProvider = _JwtProvider;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<GetAllDigitalSignaturesForUserListVM>>> 
            Handle(GetAllDigitalSignaturesForUserQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            if (Request.perPage == -1 ||
                Request.page == 0)
            {
                List<GetAllDigitalSignaturesForUserListVM> GetAllDigitalSignaturesForUserListVM = _DigitalSignatureRepository
                    .WhereThenFilter(x => x.UserId == UserId, FilterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new GetAllDigitalSignaturesForUserListVM()
                        {
                            Id = x.Id,
                            FullName = Request.lang == "en"
                                ? x.EnglishFullName
                                : x.ArabicFullName,
                            ImageUrl = x.ImageUrl.Contains("wwwroot")
                                ? (WWWRootFilePath + x.ImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.ImageUrl.Replace("\\", "/"),
                            Occupation = Request.lang == "en"
                                ? x.EnglishOccupation
                                : x.ArabicOccupation,
                            UserName = x.UserName
                        };
                    }).ToList();

                int TotalCount = await _DigitalSignatureRepository
                    .WhereThenFilter(x => x.UserId == UserId, FilterObject)
                    .CountAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllDigitalSignaturesForUserListVM>>(ResponseMessage, true, 200,
                    GetAllDigitalSignaturesForUserListVM, PaginationParameter);
            }
            else
            {
                List<GetAllDigitalSignaturesForUserListVM> GetAllDigitalSignaturesForUserListVM = _DigitalSignatureRepository
                    .WhereThenFilter(x => x.UserId == UserId, FilterObject)
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

                        return new GetAllDigitalSignaturesForUserListVM()
                        {
                            Id = x.Id,
                            FullName = Request.lang == "en"
                                ? x.EnglishFullName
                                : x.ArabicFullName,
                            ImageUrl = x.ImageUrl.Contains("wwwroot")
                                ? (WWWRootFilePath + x.ImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.ImageUrl.Replace("\\", "/"),
                            Occupation = Request.lang == "en"
                                ? x.EnglishOccupation
                                : x.ArabicOccupation,
                            UserName = x.UserName
                        };
                    }).ToList();

                int TotalCount = await _DigitalSignatureRepository
                    .WhereThenFilter(x => x.UserId == UserId, FilterObject)
                    .CountAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllDigitalSignaturesForUserListVM>>(ResponseMessage, true, 200,
                    GetAllDigitalSignaturesForUserListVM, PaginationParameter);
            }
        }
    }
}
