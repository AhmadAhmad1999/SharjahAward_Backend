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
            if (Request.Id is null)
            {
                string ResponseMessage = string.Empty;

                int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

                List<GetAllRelatedAccountsListVM> ReceivedRequests = (Request.perPage == -1 || Request.page == 0)
                    ? await _RelatedAccountRepository
                        .Where(x => x.User1Id == UserId)
                        .OrderByDescending(x => x.CreatedAt)
                        .Include(x => x.User1).Include(x => x.User2)
                        .Select(x => new GetAllRelatedAccountsListVM()
                        {
                            Id = x.Id,
                            Name = Request.lang == "ar"
                            ? x.User2!.ArabicName
                            : x.User2!.EnglishName,
                            Email = x.User2!.Email,
                            Gender = x.User2!.Gender,
                            ImageURL = x.User2!.ImageURL,
                            CreatedAt = x.CreatedAt
                        }).ToListAsync()
                    : await _RelatedAccountRepository
                        .Where(x => x.User1Id == UserId)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .Include(x => x.User1).Include(x => x.User2)
                        .Select(x => new GetAllRelatedAccountsListVM()
                        {
                            Id = x.Id,
                            Name = Request.lang == "ar"
                            ? x.User2!.ArabicName
                            : x.User2!.EnglishName,
                            Email = x.User2!.Email,
                            Gender = x.User2!.Gender,
                            ImageURL = x.User2!.ImageURL,
                            CreatedAt = x.CreatedAt
                        }).ToListAsync();

                int TotalCount = await _RelatedAccountRepository
                    .GetCountAsync(x => x.User1Id == UserId);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllRelatedAccountsListVM>>(ResponseMessage, true, 200, ReceivedRequests, PaginationParameter);
            }
            else
            {
                string ResponseMessage = string.Empty;

                int UserId = Request.Id.Value;

                List<GetAllRelatedAccountsListVM> ReceivedRequests = (Request.perPage == -1 || Request.page == 0)
                    ? await _RelatedAccountRepository
                        .Where(x => x.User1Id == UserId || x.User2Id == UserId)
                        .OrderByDescending(x => x.CreatedAt)
                        .Include(x => x.User1).Include(x => x.User2)
                        .Select(x => new GetAllRelatedAccountsListVM()
                        {
                            Id = x.Id,
                            Name = Request.lang == "ar"
                            ? x.User2!.ArabicName
                            : x.User2!.EnglishName,
                            Email = x.User2!.Email,
                            Gender = x.User2!.Gender,
                            ImageURL = x.User2!.ImageURL,
                            CreatedAt = x.CreatedAt
                        }).ToListAsync()
                    : await _RelatedAccountRepository
                        .Where(x => x.User1Id == UserId || x.User2Id == UserId)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .Include(x => x.User1).Include(x => x.User2)
                        .Select(x => new GetAllRelatedAccountsListVM()
                        {
                            Id = x.Id,
                            Name = Request.lang == "ar"
                            ? x.User2!.ArabicName
                            : x.User2!.EnglishName,
                            Email = x.User2!.Email,
                            Gender = x.User2!.Gender,
                            ImageURL = x.User2!.ImageURL,
                            CreatedAt = x.CreatedAt
                        }).ToListAsync();

                int TotalCount = await _RelatedAccountRepository
                    .GetCountAsync(x => x.User1Id == UserId);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllRelatedAccountsListVM>>(ResponseMessage, true, 200, ReceivedRequests, PaginationParameter);
            }
        }
    }
}
