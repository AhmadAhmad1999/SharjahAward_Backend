using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CircularModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars
{
    public class GetAllCircularsQueryHandler
        : IRequestHandler<GetAllCircularsQuery, BaseResponse<List<CircularListVm>>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IMapper _mapper;

        public GetAllCircularsQueryHandler(IAsyncRepository<Circular> circularRepository, IMapper mapper)
        {
            _circularRepository = circularRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CircularListVm>>> Handle(GetAllCircularsQuery request, CancellationToken cancellationToken)
        {
            var allCircular = await _circularRepository.GetPagedReponseAsync(request.page, request.pageSize);
            
            var data = _mapper.Map<List<CircularListVm>>(allCircular);

            int Count = _circularRepository.GetCount(c => !c.isDeleted);
           
            Pagination pagination = new Pagination(request.page, request.pageSize, Count);
          
            return new BaseResponse<List<CircularListVm>>("", true, 200, data, pagination);
        }
    }
}
