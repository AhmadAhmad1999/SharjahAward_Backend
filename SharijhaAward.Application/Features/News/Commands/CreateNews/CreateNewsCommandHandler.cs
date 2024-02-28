using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.CreateNews
{
    public class CreateNewsCommandHandler
        : IRequestHandler<CreateNewsCommand , BaseResponse<NewsDto>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public CreateNewsCommandHandler(IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<NewsDto>> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            var cycle = await _cycleRepository.GetByIdAsync(request.CycleId);
            string msg = "";

            if (cycle == null)
            {
                 msg = request.lang == "en"
                  ?  "Cycle is not Found"
                  :  "الدورة غير موجودة";

                return new BaseResponse<NewsDto>(msg, false, 404);
            }
            var news = _mapper.Map<Domain.Entities.NewsModel.News>(request);

            await _newsRepository.AddAsync(news);


            var newsDto = new NewsDto()
            {
                Id = news.Id,
                ArabicTitle = news.ArabicTitle,
                ArabicDescription = news.ArabicDescription,
                EnglishTitle = news.EnglishTitle,
                EnglishDescription = news.EnglishDescription,
                CycleId = news.CycleId,
                Image = news.Image,
                Title = request.lang == "en" ? news.EnglishTitle : news.ArabicTitle,
                Description = request.lang == "en" ? news.ArabicDescription :news.EnglishDescription
            };
             NewsDto dto = newsDto;
             msg = request.lang == "en"
                ? "Created Succsess"
                : "تم إنشاء الخبر بنجاح";

             return new BaseResponse<NewsDto>(msg, true, 200 ,dto);
        }
    }
}
