using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardSponsorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Queries.GetAwardSponsor
{
    public class GetAwardSponsorQueryHandler
        : IRequestHandler<GetAwardSponsorQuery, BaseResponse<AwardSponsorDto>>
    {
        private readonly IAsyncRepository<AwardSponsor> _awardSponsorRepository;
        private readonly IMapper _mapper;

        public GetAwardSponsorQueryHandler(IAsyncRepository<AwardSponsor> awardSponsorRepository, IMapper mapper)
        {
            _awardSponsorRepository = awardSponsorRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<AwardSponsorDto>> Handle(GetAwardSponsorQuery request, CancellationToken cancellationToken)
        {
            var Sponser = await _awardSponsorRepository.FirstOrDefaultAsync(a => !a.isDeleted);

            var data = _mapper.Map<AwardSponsorDto>(Sponser);

            data.Writings = request.lang == "en" ? data.EnglishWritings : data.ArabicWritings;
            data.Name = request.lang == "en" ? data.EnglishName : data.ArabicName;
            data.Description = request.lang == "en" ? data.EnglishDescription : data.ArabicDescription;
            data.HonoraryPositions = request.lang == "en" ? data.EnglishHonoraryPositions : data.ArabicHonoraryPositions;
            data.EducationalStages = request.lang == "en" ? data.EnglishEducationalStages : data.ArabicEducationalStages;
            data.UpbringingAndAiography = request.lang == "en" ? data.EnglishUpbringingAndAiography : data.ArabicUpbringingAndAiography;

            return new BaseResponse<AwardSponsorDto>("", true, 200);
        }
    }
}
