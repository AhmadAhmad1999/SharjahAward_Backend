﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllRelatedAccounts
{
    public class GetAllRelatedAccountsQuery : IRequest<BaseResponse<List<GetAllRelatedAccountsListVM>>>
    {
        public string? token { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
