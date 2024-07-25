
using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Indexes.Queries.GetIndexById
{
    public class GetIndexByIdQueryHandler
        : IRequestHandler<GetIndexByIdQuery, BaseResponse<IndexDto>>
    {
        private readonly IAsyncRepository<Domain.Entities.IndexModel.Index> _indexRepository;
        private readonly IMapper _mapper;

        public GetIndexByIdQueryHandler(IAsyncRepository<Domain.Entities.IndexModel.Index> indexRepository, IMapper mapper)
        {
            _indexRepository = indexRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<IndexDto>> Handle(GetIndexByIdQuery request, CancellationToken cancellationToken)
        {
            string msg = "";

            var index = await _indexRepository.GetByIdAsync(request.Id);
            
            if (index == null)
            {
                msg = request.lang == "en"
                    ? "Index not Found"
                    : "الفهرس غير موجود";

                return new BaseResponse<IndexDto>(msg, false, 404);
            }

            var data = _mapper.Map<IndexDto>(index);

            return new BaseResponse<IndexDto>("", true, 200, data);
        }
    }
}
