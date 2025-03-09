using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;

namespace SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage
{
    public class GetAboutPageQueryHandler
        : IRequestHandler<GetAboutPageQuery, BaseResponse<AboutPageDto>>
    {
        private readonly IAsyncRepository<AboutAwardPage> _AboutAwardPageRepository;
        private readonly IAsyncRepository<OurGoal> _OurGoalRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAboutPageQueryHandler(IAsyncRepository<AboutAwardPage> _AboutAwardPageRepository,
            IAsyncRepository<OurGoal> _OurGoalRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AboutAwardPageRepository = _AboutAwardPageRepository;
            this._OurGoalRepository = _OurGoalRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<AboutPageDto>> Handle(GetAboutPageQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AboutAwardPage? AboutAwardPageEntity = await _AboutAwardPageRepository.FirstOrDefaultAsync(x => true);
            
            if(AboutAwardPageEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Can't Reach This Page"
                    : "لا يمكن الوصول لهذه الصفحة في الوقت الحالي";

                return new BaseResponse<AboutPageDto>(ResponseMessage, true, 200, new AboutPageDto());
            }

            if (Request.lang == "en")
            {
                List<OurGoalsDto> OurGoalsDto = await _OurGoalRepository
                    .Where(x => x.AboutAwardPageId == AboutAwardPageEntity.Id)
                    .Select(x => new OurGoalsDto()
                    {
                        Id = x.Id,
                        IsHidden = x.IsHidden,
                        ArabicGoal = x.ArabicGoal,
                        EnglishGoal = x.EnglishGoal,
                        Goal = x.EnglishGoal
                    }).ToListAsync();

                AboutPageDto AboutPageDto = _Mapper.Map<AboutPageDto>(AboutAwardPageEntity);

                AboutPageDto.AboutTitle = AboutAwardPageEntity.EnglishAboutTitle;
                AboutPageDto.AboutDescription = AboutAwardPageEntity.EnglishAboutDescription;
                AboutPageDto.OurVisionTitle = AboutAwardPageEntity.EnglishOurVisionTitle;
                AboutPageDto.OurVisionDescription = AboutAwardPageEntity.EnglishOurVisionDescription;
                AboutPageDto.OurGoalTitle = AboutAwardPageEntity.EnglishOurGoalTitle;
                AboutPageDto.OurGoals = OurGoalsDto;

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

                return new BaseResponse<AboutPageDto>(ResponseMessage, true, 200, AboutPageDto);
            }
            else
            {
                List<OurGoalsDto> OurGoalsDto = await _OurGoalRepository
                    .Where(x => x.AboutAwardPageId == AboutAwardPageEntity.Id)
                    .Select(x => new OurGoalsDto()
                    {
                        Id = x.Id,
                        IsHidden = x.IsHidden,
                        ArabicGoal = x.ArabicGoal,
                        EnglishGoal = x.EnglishGoal,
                        Goal = x.ArabicGoal
                    }).ToListAsync();

                AboutPageDto AboutPageDto = _Mapper.Map<AboutPageDto>(AboutAwardPageEntity);

                AboutPageDto.AboutTitle = AboutAwardPageEntity.ArabicAboutTitle;
                AboutPageDto.AboutDescription = AboutAwardPageEntity.ArabicAboutDescription;
                AboutPageDto.OurVisionTitle = AboutAwardPageEntity.ArabicOurVisionTitle;
                AboutPageDto.OurVisionDescription = AboutAwardPageEntity.ArabicOurVisionDescription;
                AboutPageDto.OurGoalTitle = AboutAwardPageEntity.ArabicOurGoalTitle;
                AboutPageDto.OurGoals = OurGoalsDto;

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

                return new BaseResponse<AboutPageDto>(ResponseMessage, true, 200, AboutPageDto);
            }
        }
    }
}
