using EnumsNET;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetallSendedRequests
{
    public class GetallSendedRequestsQueryHandler
        : IRequestHandler<GetallSendedRequestsQuery, BaseResponse<List<GetAllReceivedRequestsListVM>>>
    {
        private readonly IAsyncRepository<RelatedAccountRequest> _RelatedAccountRequestRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetallSendedRequestsQueryHandler(IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository,
            IJwtProvider JWTProvider,
            IHttpContextAccessor _HttpContextAccessor)
        {
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
            _JWTProvider = JWTProvider;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public async Task<BaseResponse<List<GetAllReceivedRequestsListVM>>> Handle(GetallSendedRequestsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<GetAllReceivedRequestsListVM> ReceivedRequests = (Request.perPage == -1 || Request.page == 0)
                ? _RelatedAccountRequestRepository
                    .Where(x => x.SenderId == UserId)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToList()
                    .Select(x => new GetAllReceivedRequestsListVM()
                    {
                        Id = x.Id,
                        Email = x.Receiver!.Email,
                        Gender = x.Receiver!.Gender,
                        Name = Request.lang == "en"
                            ? x.Receiver!.EnglishName
                            : x.Receiver!.ArabicName,
                        ImageURL = !string.IsNullOrEmpty(x.Receiver!.ImageURL)
                            ? (x.Receiver!.ImageURL.Contains("wwwroot")
                                ? (WWWRootFilePath + x.Receiver!.ImageURL!.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.Receiver!.ImageURL.Replace("\\", "/"))
                            : null,
                        Status = x.Status.GetName()!
                    }).ToList()
                : _RelatedAccountRequestRepository
                    .Where(x => x.SenderId == UserId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToList()
                    .Select(x => new GetAllReceivedRequestsListVM()
                    {
                        Id = x.Id,
                        Email = x.Receiver!.Email,
                        Gender = x.Receiver!.Gender,
                        Name = Request.lang == "en"
                            ? x.Receiver!.EnglishName
                            : x.Receiver!.ArabicName,
                        ImageURL = !string.IsNullOrEmpty(x.Receiver!.ImageURL)
                            ? (x.Receiver!.ImageURL.Contains("wwwroot")
                                ? (WWWRootFilePath + x.Receiver!.ImageURL!.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.Receiver!.ImageURL.Replace("\\", "/"))
                            : null,
                        Status = x.Status.GetName()!
                    }).ToList();

            int TotalCount = await _RelatedAccountRequestRepository
                .GetCountAsync(x => x.ReceiverId == UserId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllReceivedRequestsListVM>>(ResponseMessage, true, 200, ReceivedRequests, PaginationParameter);
        }
    }
}
