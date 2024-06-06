using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CommitteeModel;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllCommittees
{
    public class GetAllCommitteesHandler : IRequestHandler<GetAllCommitteesQuery, BaseResponse<List<GetAllCommitteesListVM>>>
    {
        private readonly IAsyncRepository<Committee> _CommitteeRepository;
        public GetAllCommitteesHandler(IAsyncRepository<Committee> CommitteeRepository)
        {
            _CommitteeRepository = CommitteeRepository;
        }

        public async Task<BaseResponse<List<GetAllCommitteesListVM>>> Handle(GetAllCommitteesQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            List<GetAllCommitteesListVM> Committees = await _CommitteeRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .Include(x => x.Chairman!)
                .Select(x => new GetAllCommitteesListVM()
                {
                    Id = x.Id,
                    ArabicName = x.ArabicName,
                    EnglishName = x.EnglishName,
                    ChairmanId = x.ChairmanId,
                    Status = x.Status,
                    CreatedAt = x.CreatedAt,
                    ChairmanName = Request.lang == "en"
                        ? x.Chairman!.EnglishName
                        : x.Chairman!.ArabicName
                }).ToListAsync();

            int TotalCount = await _CommitteeRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllCommitteesListVM>>(ResponseMessage, true, 200, Committees, PaginationParameter);
        }
    }
}
