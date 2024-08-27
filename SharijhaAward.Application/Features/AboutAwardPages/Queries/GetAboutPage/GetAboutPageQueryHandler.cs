using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage
{
    public class GetAboutPageQueryHandler
        : IRequestHandler<GetAboutPageQuery, BaseResponse<AboutPageDto>>
    {
        private readonly IAsyncRepository<AboutAwardPage> _aboutPageRepository;
        private readonly IAsyncRepository<OurGoal> _goalRepository;
        private readonly IMapper _mapper;

        public GetAboutPageQueryHandler(IAsyncRepository<AboutAwardPage> aboutPageRepository, IAsyncRepository<OurGoal> goalRepository, IMapper mapper)
        {
            _aboutPageRepository = aboutPageRepository;
            _goalRepository = goalRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<AboutPageDto>> Handle(GetAboutPageQuery request, CancellationToken cancellationToken)
        {
            var AboutPage = await _aboutPageRepository.FirstOrDefaultAsync(x => true);
            
            if(AboutPage == null)
            {
                var NoData = _mapper.Map<AboutPageDto>(AboutPage);
                return new BaseResponse<AboutPageDto>("Can't Reach This Page", true, 200, NoData);
            }

            var ourGols = await _goalRepository
                .Where(x => x.AboutAwardPageId == AboutPage.Id)
                .Select(x => new OurGoalsDto()
                {
                    Id = x.Id,
                    IsHidden = x.IsHidden,
                    ArabicGoal = x.ArabicGoal,
                    EnglishGoal = x.EnglishGoal,
                    Goal = request.lang == "en"
                        ? x.EnglishGoal
                        : x.ArabicGoal
                }).ToListAsync();

            var data = _mapper.Map<AboutPageDto>(AboutPage);

            data.OurGoals = ourGols;
            
            data.AboutTitle = request.lang == "en"
                ? data.EnglishAboutTitle
                : data.ArabicAboutTitle;

            data.AboutDescription = request.lang == "en"
                ? data.EnglishAboutDescription
                : data.ArabicAboutDescription;
       
            data.OurVisionTitle = request.lang == "en"
                ? data.EnglishOurVisionTitle
                : data.ArabicOurVisionTitle;

            data.OurVisionDescription = request.lang == "en"
                ? data.EnglishOurVisionDescription
                : data.ArabicOurVisionDescription;

            data.OurGoalTitle = request.lang == "en"
                ? data.EnglishOurGoalTitle
                : data.ArabicOurGoalTitle;

            return new BaseResponse<AboutPageDto>("", true, 200, data);
        }
    }
}
