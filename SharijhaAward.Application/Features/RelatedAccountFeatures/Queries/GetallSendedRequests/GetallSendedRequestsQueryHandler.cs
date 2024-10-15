using EnumsNET;
using MediatR;
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

        public GetallSendedRequestsQueryHandler(IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository,
            IJwtProvider JWTProvider)
        {
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<List<GetAllReceivedRequestsListVM>>> Handle(GetallSendedRequestsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            List<GetAllReceivedRequestsListVM> ReceivedRequests = (Request.perPage == -1 || Request.page == 0)
                ? await _RelatedAccountRequestRepository
                    .Where(x => x.ReceiverId == UserId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new GetAllReceivedRequestsListVM()
                    {
                        Id = x.Id,
                        Email = x.Receiver!.Email,
                        Gender = x.Receiver!.Gender,
                        Name = Request.lang == "en"
                            ? x.Receiver!.EnglishName
                            : x.Receiver!.ArabicName,
                        ImageURL = x.Receiver!.ImageURL,
                        Status = x.Status.GetName()!
                    }).ToListAsync()
                : await _RelatedAccountRequestRepository
                    .Where(x => x.ReceiverId == UserId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .Select(x => new GetAllReceivedRequestsListVM()
                    {
                        Id = x.Id,
                        Email = x.Receiver!.Email,
                        Gender = x.Receiver!.Gender,
                        Name = Request.lang == "en"
                            ? x.Receiver!.EnglishName
                            : x.Receiver!.ArabicName,
                        ImageURL = x.Receiver!.ImageURL,
                        Status = x.Status.GetName()!
                    }).ToListAsync();

            int TotalCount = await _RelatedAccountRequestRepository
                .GetCountAsync(x => x.ReceiverId == UserId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllReceivedRequestsListVM>>(ResponseMessage, true, 200, ReceivedRequests, PaginationParameter);
        }
    }
}
