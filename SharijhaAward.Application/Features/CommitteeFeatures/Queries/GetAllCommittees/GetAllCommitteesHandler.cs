using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CommitteeModel;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllCommittees
{
    public class GetAllCommitteesHandler : IRequestHandler<GetAllCommitteesQuery, BaseResponse<List<GetAllCommitteesListVM>>>
    {
        private readonly IAsyncRepository<Committee> _CommitteeRepository;
        private readonly IMapper _Mapper;
        public GetAllCommitteesHandler(IAsyncRepository<Committee> CommitteeRepository,
            IMapper Mapper)
        {
            _CommitteeRepository = CommitteeRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllCommitteesListVM>>> Handle(GetAllCommitteesQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllCommitteesListVM> Committees = _Mapper.Map<List<GetAllCommitteesListVM>>(await _CommitteeRepository
                .OrderByDescending(x => x.CreatedAt, Request.page, Request.pageSize).ToListAsync());

            int TotalCount = await _CommitteeRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllCommitteesListVM>>(ResponseMessage, true, 200, Committees, PaginationParameter);
        }
    }
}
