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
            var AboutPage = await _aboutPageRepository.WhereThenInclude(a=>!a.isDeleted,a => a.OurGoals).FirstOrDefaultAsync();
            
            if(AboutPage == null)
            {
                var NoData = _mapper.Map<AboutPageDto>(AboutPage);
                return new BaseResponse<AboutPageDto>("Can't Reach This Page", true, 200, NoData);
            }
            var ourGols = _mapper.Map<List<OurGoalsDto>>(AboutPage.OurGoals);

            for (int i = 0; i < ourGols.Count(); i++)
            {
                ourGols[i].Goal = request.lang == "en"
                    ? ourGols[i].EnglishGoal
                    : ourGols[i].ArabicGoal;
            }
            
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
