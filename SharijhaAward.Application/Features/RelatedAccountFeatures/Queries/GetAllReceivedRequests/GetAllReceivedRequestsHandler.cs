using MediatR;
using Microsoft.EntityFrameworkCore;
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

            Guid UserId = new Guid(_JWTProvider.GetUserIdFromToken(Request.token!));

            List<GetAllReceivedRequestsListVM> ReceivedRequests = (Request.pageSize == -1 || Request.page == 0)
                ? await _RelatedAccountRequestRepository
                    .Where(x => x.ReceiverId == UserId)
                    .Include(x => x.Sender)
                    .Select(x => new GetAllReceivedRequestsListVM()
                    {
                        Id = x.Id,
                        Email = x.Sender!.Email,
                        Gender = x.Sender!.Gender,
                        Name = Request.lang == "en"
                            ? x.Sender!.EnglishName
                            : x.Sender!.ArabicName,
                        ImageURL = x.Sender!.ImageURL
                    })
                    .ToListAsync()
                : await _RelatedAccountRequestRepository
                    .Where(x => x.ReceiverId == UserId)
                    .Include(x => x.Sender)
                    .Select(x => new GetAllReceivedRequestsListVM()
                    {
                        Id = x.Id,
                        Email = x.Sender!.Email,
                        Gender = x.Sender!.Gender,
                        Name = Request.lang == "en"
                            ? x.Sender!.EnglishName
                            : x.Sender!.ArabicName,
                        ImageURL = x.Sender!.ImageURL
                    })
                    .Skip((Request.page - 1) * Request.pageSize).Take(Request.pageSize).ToListAsync();

            int TotalCount = await _RelatedAccountRequestRepository
                .GetCountAsync(x => x.ReceiverId == UserId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllReceivedRequestsListVM>>(ResponseMessage, true, 200, ReceivedRequests, PaginationParameter);
        }
    }
}
