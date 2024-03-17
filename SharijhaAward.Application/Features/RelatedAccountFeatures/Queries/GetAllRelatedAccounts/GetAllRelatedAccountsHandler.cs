using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllRelatedAccounts
{
    public class GetAllRelatedAccountsHandler : IRequestHandler<GetAllRelatedAccountsQuery,
        BaseResponse<List<GetAllRelatedAccountsListVM>>>
    {
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        private readonly IJwtProvider _JWTProvider;
        public GetAllRelatedAccountsHandler(IAsyncRepository<RelatedAccount> RelatedAccountRepository,
            IJwtProvider JWTProvider)
        {
            _RelatedAccountRepository = RelatedAccountRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<List<GetAllRelatedAccountsListVM>>> Handle(GetAllRelatedAccountsQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Guid UserId = new Guid(_JWTProvider.GetUserIdFromToken(Request.token!));

            List<RelatedAccount> ReceivedRequests = (Request.pageSize == -1 || Request.page == 0)
                ? await _RelatedAccountRepository
                    .Where(x => x.Subscriber1Id == UserId || x.Subscriber2Id == UserId)
                    .Include(x => x.Subscriber1).Include(x => x.Subscriber2).ToListAsync()
                : await _RelatedAccountRepository
                    .Where(x => x.Subscriber1Id == UserId || x.Subscriber2Id == UserId)
                    .Skip((Request.page - 1) * Request.pageSize).Take(Request.pageSize)
                    .Include(x => x.Subscriber1).Include(x => x.Subscriber2).ToListAsync();

            IEnumerable<GetAllRelatedAccountsListVM> RelatedAccountsFromSubscriber2Id = ReceivedRequests
                .Where(x => x.Subscriber1Id == UserId)
                .Select(x => new GetAllRelatedAccountsListVM()
                {
                    Id = x.Subscriber2Id,
                    Name = Request.lang == "ar"
                        ? x.Subscriber2!.ArabicName
                        : x.Subscriber2!.EnglishName,
                    Email = x.Subscriber2!.Email,
                    Gender = x.Subscriber2!.Gender
                });

            IEnumerable<GetAllRelatedAccountsListVM> RelatedAccountsFromSubscriber1Id = ReceivedRequests
                .Where(x => x.Subscriber2Id == UserId)
                .Select(x => new GetAllRelatedAccountsListVM()
                {
                    Id = x.Subscriber1Id,
                    Name = Request.lang == "ar"
                        ? x.Subscriber1!.ArabicName
                        : x.Subscriber1!.EnglishName,
                    Email = x.Subscriber1!.Email,
                    Gender = x.Subscriber1!.Gender
                });

            List<GetAllRelatedAccountsListVM> RelatedAccounts = RelatedAccountsFromSubscriber2Id
                .Concat(RelatedAccountsFromSubscriber1Id).ToList();

            int TotalCount = await _RelatedAccountRepository
                .GetCountAsync(x => x.Subscriber1Id == UserId || x.Subscriber2Id == UserId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllRelatedAccountsListVM>>(ResponseMessage, true, 200, RelatedAccounts, PaginationParameter);
        }
    }
}
