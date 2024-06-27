using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
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
        : IRequestHandler<CreateNewsCommand , BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IAsyncRepository<NewsImage> _newsImageRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateNewsCommandHandler(IFileService fileService, IAsyncRepository<NewsImage> newsImageRepository, IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _newsImageRepository = newsImageRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {   
            string msg;

            var news = _mapper.Map<Domain.Entities.NewsModel.News>(request);
            
            news.Image = request.Image != null
                ? await _fileService.SaveFileAsync(request.Image!)
                : null;

            var data = await _newsRepository.AddAsync(news);

            if(request.Images != null)
            {
                foreach(var image in request.Images)
                {
                    var newsImage = new NewsImage()
                    {
                        ImageUrl = await _fileService.SaveFileAsync(image),
                        NewsId = data.Id
                    };
                    await _newsImageRepository.AddAsync(newsImage);
                }
            }

             msg = request.lang == "en"
                ? "Created Succsess"
                : "تم إنشاء الخبر بنجاح";

             return new BaseResponse<object>(msg, true, 200);
        }
    }
}
