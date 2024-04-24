using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.GetAwardPublicationById
{
    public class GetAwardPublicationByIdQueryHandler
        : IRequestHandler<GetAwardPublicationByIdQuery, BaseResponse<AwardPublicationDto>>
    {
        private readonly IAsyncRepository<AwardPublication> _awardPublicationRepository;
        private readonly IMapper _mapper;

        public GetAwardPublicationByIdQueryHandler(IAsyncRepository<AwardPublication> awardPublicationRepository, IMapper mapper)
        {
            _awardPublicationRepository = awardPublicationRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<AwardPublicationDto>> Handle(GetAwardPublicationByIdQuery request, CancellationToken cancellationToken)
        {
            var AwardPublication = await _awardPublicationRepository.GetByIdAsync(request.Id);
           
            if(AwardPublication == null)
            {
                return new BaseResponse<AwardPublicationDto>("", false, 404);
            }

            var data = _mapper.Map<AwardPublicationDto>(AwardPublication);

            return new BaseResponse<AwardPublicationDto>("", true, 200, data);
        }
    }
}
