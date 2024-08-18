using AutoMapper;
using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
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
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            var AwardPublications = await _awardPublicationRepository.OrderByDescending(filterObject, r => r.CreatedAt, request.page, request.perPage).ToListAsync();

            var data = _mapper.Map<List<AwardPublicationListVM>>(AwardPublications);

            var Count = _awardPublicationRepository.GetCount(a => !a.isDeleted);
            
            Pagination pagination = new Pagination(request.page, request.perPage, Count);

            return new BaseResponse<List<AwardPublicationListVM>>("", true, 200, data, pagination);


        }
    }
}
