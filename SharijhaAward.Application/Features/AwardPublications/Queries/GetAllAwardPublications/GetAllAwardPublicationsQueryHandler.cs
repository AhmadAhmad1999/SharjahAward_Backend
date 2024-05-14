using AutoMapper;
using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.GetAllAwardPublications
{
    public class GetAllAwardPublicationsQueryHandler
        : IRequestHandler<GetAllAwardPublicationsQuery, BaseResponse<List<AwardPublicationListVM>>>
    {
        private readonly IAsyncRepository<AwardPublication> _awardPublicationRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public GetAllAwardPublicationsQueryHandler(IAsyncRepository<AwardPublication> awardPublicationRepository, IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _awardPublicationRepository = awardPublicationRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<AwardPublicationListVM>>> Handle(GetAllAwardPublicationsQuery request, CancellationToken cancellationToken)
        {
            var Cycle = request.CycleId == null
                ? await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active)
                : await _cycleRepository.GetByIdAsync(request.CycleId);
           
            if(Cycle == null)
            {
                return new BaseResponse<List<AwardPublicationListVM>>("", false, 404);
            }

            var AwardPublications = await _awardPublicationRepository.GetWhereThenPagedReponseAsync(a => a.CycleId == Cycle.Id,request.page,request.pageSize);

            var data = _mapper.Map<List<AwardPublicationListVM>>(AwardPublications);

            var Count = _awardPublicationRepository.GetCount(a => !a.isDeleted && a.CycleId == Cycle.Id);
            
            Pagination pagination = new Pagination(request.page, request.pageSize, Count);

            return new BaseResponse<List<AwardPublicationListVM>>("", true, 200, data, pagination);


        }
    }
}
