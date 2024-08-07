using Aspose.Pdf.Drawing;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
        private readonly IAsyncRepository<CircularCoordinator> _circularCoordinatorRepository;
        private readonly IAsyncRepository<CircularArbitrator> _circularArbitratorRepository;
        private readonly IAsyncRepository<CircularChairman> _circularChairman;
        private readonly IMapper _mapper;

        public GetCircularByIdQueryHandler(IAsyncRepository<Circular> circularRepository, IMapper mapper, IAsyncRepository<CircularCoordinator> circularCoordinatorRepository, IAsyncRepository<CircularArbitrator> circularArbitratorRepository, IAsyncRepository<CircularChairman> circularChairman)
        {
            _circularRepository = circularRepository;
            _mapper = mapper;
            _circularCoordinatorRepository = circularCoordinatorRepository;
            _circularArbitratorRepository = circularArbitratorRepository;
            _circularChairman = circularChairman;
        }

        public async Task<BaseResponse<CircularDto>> Handle(GetCircularByIdQuery request, CancellationToken cancellationToken)
        {
            var Circular = await _circularRepository
                .Where(c => c.Id == request.Id)
                .Include(c => c.CircularAttachments)
                .FirstOrDefaultAsync();

            if(Circular == null)
            {
                return new BaseResponse<CircularDto>("", false, 404);
            }

            var data = _mapper.Map<CircularDto>(Circular);

            data.Coordinators = await _circularCoordinatorRepository
                .Where(c => c.CircularId == Circular.Id)
                .Select(c => c.CoordinatorId)
                .ToListAsync();

            data.Arbitrators = await _circularArbitratorRepository
                .Where(c => c.CircularId == Circular.Id)
                .Select(c => c.ArbitratorId)
                .ToListAsync();

            data.Chairmans = await _circularChairman
                .Where(c=>c.CircularId == Circular.Id)
                .Select(c=>c.ChairmanId)
                .ToListAsync();

            data.CircularAttachments = _mapper.Map<List<CircularAttachmentDto>>(Circular.CircularAttachments);

            return new BaseResponse<CircularDto>("", true, 200, data);
        }
    }
}
