using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Indexes.Queries.GetAllIndexes
{
    public class GetAllIndexesQueryHandler
        : IRequestHandler<GetAllIndexesQuery, BaseResponse<List<IndexesListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.IndexModel.Index> _indexRepository;
        private readonly IMapper _mapper;

        public GetAllIndexesQueryHandler(IAsyncRepository<Domain.Entities.IndexModel.Index> indexRepository, IMapper mapper)
        {
            _indexRepository = indexRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<IndexesListVM>>> Handle(GetAllIndexesQuery request, CancellationToken cancellationToken)
        {
            var indexes = await _indexRepository.GetPagedReponseAsync(request.page, request.perPage);

            var data = _mapper.Map<List<IndexesListVM>>(indexes);

            var count = _indexRepository.GetCount(i => !i.isDeleted);
            
            Pagination pagination = new Pagination(request.page, request.perPage, count);

            return new BaseResponse<List<IndexesListVM>>("", true, 200, data, pagination);
        }
    }
}
