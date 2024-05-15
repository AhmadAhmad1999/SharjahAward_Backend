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

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Queries.GetAwardSponsorById
{
    public class GetAwardSponsorByIdQueryHandler
        : IRequestHandler<GetAwardSponsorByIdQuery, BaseResponse<AwardSponsorDto>>
    {
        private readonly IAsyncRepository<AwardSponsor> _awardSponsorRepository;
        private readonly IMapper _mapper;

        public GetAwardSponsorByIdQueryHandler(IAsyncRepository<AwardSponsor> awardSponsorRepository, IMapper mapper)
        {
            _awardSponsorRepository = awardSponsorRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<AwardSponsorDto>> Handle(GetAwardSponsorByIdQuery request, CancellationToken cancellationToken)
        {
            var Sponsor = await _awardSponsorRepository.GetByIdAsync(request.Id);
           
            if(Sponsor == null)
            {
                return new BaseResponse<AwardSponsorDto>("", false, 404);
            }

            var data = _mapper.Map<AwardSponsorDto>(Sponsor);

            data.Writings = request.lang == "en" ? data.EnglishWritings : data.ArabicWritings;
            data.Name = request.lang == "en" ? data.EnglishName : data.ArabicName;
            data.Description = request.lang == "en" ? data.EnglishDescription : data.ArabicDescription;
            data.HonoraryPositions = request.lang == "en" ? data.EnglishHonoraryPositions : data.ArabicHonoraryPositions;
            data.EducationalStages = request.lang == "en" ? data.EnglishEducationalStages : data.ArabicEducationalStages;
            data.UpbringingAndAiography = request.lang == "en" ? data.EnglishUpbringingAndAiographyFirst : data.ArabicUpbringingAndAiographyFirst;
            data.UpbringingAndAiographySecound = request.lang == "en" ? data.EnglishUpbringingAndAiographySecound : data.ArabicUpbringingAndAiographySecound;

            return new BaseResponse<AwardSponsorDto>("", true, 200, data);
        }
    }
}
