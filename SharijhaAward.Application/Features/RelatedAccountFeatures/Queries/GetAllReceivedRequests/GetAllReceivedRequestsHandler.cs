using EnumsNET;
using MediatR;
using Microsoft.EntityFrameworkCore;
using QRCoder.Extensions;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests
{
    public class GetAllReceivedRequestsHandler : IRequestHandler<GetAllReceivedRequestsQuery, 
        BaseResponse<List<GetAllReceivedRequestsListVM>>>
    {
        private readonly IAsyncRepository<RelatedAccountRequest> _RelatedAccountRequestRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetAllReceivedRequestsHandler(IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository,
            IJwtProvider JWTProvider)
        {
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<List<GetAllReceivedRequestsListVM>>> Handle(GetAllReceivedRequestsQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            List<GetAllReceivedRequestsListVM> ReceivedRequests = (Request.perPage == -1 || Request.page == 0)
                ? await _RelatedAccountRequestRepository
                    .Where(x => x.ReceiverId == UserId && x.Status == Domain.Constants.RelatedAccountRequestStatus.Pending)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new GetAllReceivedRequestsListVM()
                    {
                        Id = x.Id,
                        Email = x.Sender!.Email,
                        Gender = x.Sender!.Gender,
                        Name = Request.lang == "en"
                            ? x.Sender!.EnglishName
                            : x.Sender!.ArabicName,
                        ImageURL = x.Sender!.ImageURL,
                        Status = x.Status.GetName()!
                    }).ToListAsync()
                : await _RelatedAccountRequestRepository
                    .Where(x => x.ReceiverId == UserId && x.Status == Domain.Constants.RelatedAccountRequestStatus.Pending)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .Select(x => new GetAllReceivedRequestsListVM()
                    {
                        Id = x.Id,
                        Email = x.Sender!.Email,
                        Gender = x.Sender!.Gender,
                        Name = Request.lang == "en"
                            ? x.Sender!.EnglishName
                            : x.Sender!.ArabicName,
                        ImageURL = x.Sender!.ImageURL,
                        Status = x.Status.GetName()!
                    }).ToListAsync();

            int TotalCount = await _RelatedAccountRequestRepository
                .GetCountAsync(x => x.ReceiverId == UserId && x.Status == Domain.Constants.RelatedAccountRequestStatus.Pending);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllReceivedRequestsListVM>>(ResponseMessage, true, 200, ReceivedRequests, PaginationParameter);
        }
    }
}
