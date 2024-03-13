using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllRelatedAccounts
{
    public class GetAllRelatedAccountsHandler : IRequestHandler<GetAllRelatedAccountsQuery,
        BaseResponse<List<GetAllRelatedAccountsListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        private readonly IJwtProvider _JWTProvider;
        public GetAllRelatedAccountsHandler(IMapper Mapper,
            IAsyncRepository<RelatedAccount> RelatedAccountRepository,
            IJwtProvider JWTProvider)
        {
            _Mapper = Mapper;
            _RelatedAccountRepository = RelatedAccountRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<List<GetAllRelatedAccountsListVM>>> Handle(GetAllRelatedAccountsQuery Request,
            CancellationToken cancellationToken)
        {
            Guid UserId = new Guid(_JWTProvider.GetUserIdFromToken(Request.token!));

            var ReceivedRequests = await _RelatedAccountRepository
                .Where(x => x.Subscriber1Id == UserId || x.Subscriber2Id == UserId).ToListAsync();
                    

            return new BaseResponse<List<GetAllRelatedAccountsListVM>>(string.Empty, true, 200/*, ReceivedRequests*/);
        }
    }
}
