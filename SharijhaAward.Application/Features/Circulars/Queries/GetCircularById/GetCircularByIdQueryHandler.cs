using Aspose.Pdf.Drawing;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
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
        private readonly IAsyncRepository<CircularAttachment> _CircularAttachmentRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetCircularByIdQueryHandler(IJwtProvider jwtProvider, 
            IAsyncRepository<Circular> circularRepository, 
            IMapper mapper, 
            IAsyncRepository<CircularCoordinator> circularCoordinatorRepository, 
            IAsyncRepository<CircularArbitrator> circularArbitratorRepository, 
            IAsyncRepository<CircularChairman> circularChairman,
            IAsyncRepository<CircularAttachment> CircularAttachmentRepository)
        {
            _circularRepository = circularRepository;
            _mapper = mapper;
            _circularCoordinatorRepository = circularCoordinatorRepository;
            _circularArbitratorRepository = circularArbitratorRepository;
            _circularChairman = circularChairman;
            _jwtProvider = jwtProvider;
            _CircularAttachmentRepository = CircularAttachmentRepository;
        }

        public async Task<BaseResponse<CircularDto>> Handle(GetCircularByIdQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token!);

            if (UserId == null)
            {
                return new BaseResponse<CircularDto>("UnAuth", false, 401);
            }

            var Circular = await _circularRepository
                .Where(c => c.Id == request.Id)
                .FirstOrDefaultAsync();

            if(Circular == null)
            {
                return new BaseResponse<CircularDto>("", false, 404);
            }

            var data = _mapper.Map<CircularDto>(Circular);

            data.Coordinators = await _circularCoordinatorRepository
                .Where(c => c.CircularId == Circular.Id)
                .Include(c=>c.Coordinator)
                .Select(c => c.CoordinatorId)
                .ToListAsync();

            data.Arbitrators = await _circularArbitratorRepository
                .Where(c => c.CircularId == Circular.Id)
                .Include(c=>c.Arbitrator)
                .Select(c => c.ArbitratorId)
                .ToListAsync();

            data.Chairmans = await _circularChairman
                .Where(c=>c.CircularId == Circular.Id)
                .Include(c=>c.Chairman)
                .Select(c=>c.ChairmanId)
                .ToListAsync();

            if (data.Coordinators.Contains(int.Parse(UserId))
                || data.Arbitrators.Contains(int.Parse(UserId))
                || data.Chairmans.Contains(int.Parse(UserId)))
            {
                Circular.IsRead = true;

                await _circularRepository.UpdateAsync(Circular);

                data.IsRead = true;
            }

            data.CircularAttachments = _mapper.Map<List<CircularAttachmentDto>>(await _CircularAttachmentRepository
                .Where(x => x.CircularId == Circular.Id)
                .ToListAsync());

            return new BaseResponse<CircularDto>("", true, 200, data);
        }
    }
}
