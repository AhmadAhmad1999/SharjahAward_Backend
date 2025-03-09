using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;

namespace SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPageWebSite
{
    public class GetAboutPageWebSiteQueryHandler
        : IRequestHandler<GetAboutPageWebSiteQuery, BaseResponse<AboutPageDto>>
    {
        private readonly IAsyncRepository<AboutAwardPage> _AboutAwardPageRepository;
        private readonly IAsyncRepository<OurGoal> _OurGoalRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAboutPageWebSiteQueryHandler(IAsyncRepository<AboutAwardPage> _AboutAwardPageRepository, 
            IAsyncRepository<OurGoal> _OurGoalRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AboutAwardPageRepository = _AboutAwardPageRepository;
            this._OurGoalRepository = _OurGoalRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<AboutPageDto>> Handle(GetAboutPageWebSiteQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AboutAwardPage? AboutAwardPageEntity = await _AboutAwardPageRepository.FirstOrDefaultAsync(x => true);

            if (AboutAwardPageEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Can't Reach This Page"
                    : "لا يمكن الوصول لهذه الصفحة في الوقت الحالي";

                return new BaseResponse<AboutPageDto>(ResponseMessage, true, 200, new AboutPageDto());
            }

            List<OurGoalsDto> OurGoalsDto = await _OurGoalRepository
                .Where(g => !g.IsHidden && g.AboutAwardPageId == AboutAwardPageEntity.Id)
                .Select(x => new OurGoalsDto()
                {
                    Id = x.Id,
                    IsHidden = x.IsHidden,
                    ArabicGoal = x.ArabicGoal,
                    EnglishGoal = x.EnglishGoal,
                    Goal = Request.lang == "en"
                        ? x.EnglishGoal
                        : x.ArabicGoal
                }).ToListAsync();

            AboutPageDto AboutPageDto = _Mapper.Map<AboutPageDto>(AboutAwardPageEntity);

            if (Request.lang == "en")
            {
                AboutPageDto.OurGoalTitle = AboutPageDto.EnglishOurGoalTitle;

                if (!AboutAwardPageEntity.IsAboutHidden)
                {
                    AboutPageDto.AboutTitle = AboutPageDto.EnglishAboutTitle;
                    AboutPageDto.AboutDescription = AboutPageDto.EnglishAboutDescription;
                }

                if (!AboutAwardPageEntity.IsOurVisionHidden)
                {
                    AboutPageDto.OurVisionTitle = AboutPageDto.EnglishOurVisionTitle;
                    AboutPageDto.OurVisionDescription = AboutPageDto.EnglishOurVisionDescription;
                }

                if (AboutAwardPageEntity.IsGoalsHidden)
                {
                    AboutPageDto.OurGoals = await _OurGoalRepository
                        .Where(g => !g.IsHidden && g.AboutAwardPageId == AboutAwardPageEntity.Id)
                        .Select(x => new OurGoalsDto()
                        {
                            Id = x.Id,
                            IsHidden = x.IsHidden,
                            ArabicGoal = x.ArabicGoal,
                            EnglishGoal = x.EnglishGoal,
                            Goal = x.EnglishGoal
                        }).ToListAsync();
                }

                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                string WWWRootFilePath = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                AboutPageDto.AboutImage = AboutAwardPageEntity.AboutImage.Contains("wwwroot")
                    ? AboutAwardPageEntity.AboutImage
                    : AboutAwardPageEntity.AboutImage;

                AboutPageDto.OurVisionImage = AboutAwardPageEntity.AboutImage.Contains("wwwroot")
                    ? AboutAwardPageEntity.OurVisionImage
                    : AboutAwardPageEntity.OurVisionImage;
            }
            else
            {
                AboutPageDto.OurGoalTitle = AboutPageDto.ArabicOurGoalTitle;

                if (!AboutAwardPageEntity.IsAboutHidden)
                {
                    AboutPageDto.AboutTitle = AboutPageDto.ArabicAboutTitle;
                    AboutPageDto.AboutDescription = AboutPageDto.ArabicAboutDescription;
                }

                if (!AboutAwardPageEntity.IsOurVisionHidden)
                {
                    AboutPageDto.OurVisionTitle = AboutPageDto.ArabicOurVisionTitle;
                    AboutPageDto.OurVisionDescription = AboutPageDto.ArabicOurVisionDescription;
                }

                if (AboutAwardPageEntity.IsGoalsHidden)
                {
                    AboutPageDto.OurGoals = await _OurGoalRepository
                        .Where(g => !g.IsHidden && g.AboutAwardPageId == AboutAwardPageEntity.Id)
                        .Select(x => new OurGoalsDto()
                        {
                            Id = x.Id,
                            IsHidden = x.IsHidden,
                            ArabicGoal = x.ArabicGoal,
                            EnglishGoal = x.EnglishGoal,
                            Goal = x.ArabicGoal
                        }).ToListAsync();
                }

                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                string WWWRootFilePath = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                AboutPageDto.AboutImage = AboutAwardPageEntity.AboutImage.Contains("wwwroot")
                    ? AboutAwardPageEntity.AboutImage
                    : AboutAwardPageEntity.AboutImage;

                AboutPageDto.OurVisionImage = AboutAwardPageEntity.AboutImage.Contains("wwwroot")
                    ? AboutAwardPageEntity.OurVisionImage
                    : AboutAwardPageEntity.OurVisionImage;
            }
            
            return new BaseResponse<AboutPageDto>(ResponseMessage, true, 200, AboutPageDto);
        }
    }
}
