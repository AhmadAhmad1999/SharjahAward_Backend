using Aspose.Pdf.Drawing;
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

namespace SharijhaAward.Application.Features.Circulars.Queries.GetCircularById
{
    public class GetCircularByIdQueryHandler
        : IRequestHandler<GetCircularByIdQuery, BaseResponse<CircularDto>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IMapper _mapper;

        public GetCircularByIdQueryHandler(IAsyncRepository<Circular> circularRepository, IMapper mapper)
        {
            _circularRepository = circularRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<CircularDto>> Handle(GetCircularByIdQuery request, CancellationToken cancellationToken)
        {
            var Circular = await _circularRepository.GetByIdAsync(request.Id);
            if(Circular == null)
            {
                return new BaseResponse<CircularDto>("", false, 404);
            }

            var data = _mapper.Map<CircularDto>(Circular);

            return new BaseResponse<CircularDto>("", true, 200, data);
        }
    }
}
