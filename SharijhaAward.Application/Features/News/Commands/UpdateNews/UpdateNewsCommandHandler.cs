using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.UpdateNews
{
    public class UpdateNewsCommandHandler
        : IRequestHandler<UpdateNewsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IAsyncRepository<NewsImage> _newsImageRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateNewsCommandHandler(IAsyncRepository<NewsImage> newsImageRepository, IFileService fileService, IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _newsImageRepository = newsImageRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateNewsCommand request, CancellationToken cancellationToken)
        {
            var newsToUpdate = await _newsRepository
                .WhereThenInclude(n => n.Id == request.Id, n => n.NewsImages!)
                .FirstOrDefaultAsync();
           
            string msg;
            if (newsToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "The News is not Found"
                    : "الخبر غير موجود";

                return new BaseResponse<object>(msg,false,404);
            }
            var Image = newsToUpdate.Image;
            var Images = newsToUpdate.NewsImages;

            _mapper.Map(request,newsToUpdate,typeof(UpdateNewsCommand),typeof(Domain.Entities.NewsModel.News));

            newsToUpdate.Image = request.EditeOnImage == true
                ? newsToUpdate.Image = await _fileService.SaveFileAsync(request.Image!)
                : newsToUpdate.Image = Image;

            if (request.AddNewImages)
            {
                if (request.Images != null)
                {
                    foreach (var image in request.Images!)
                    {
                        var NewsImage = new NewsImage()
                        {
                            NewsId = newsToUpdate.Id,
                            ImageUrl = await _fileService.SaveFileAsync(image)
                        };
                        await _newsImageRepository.AddAsync(NewsImage); 
                    }
                }
            }
            else
            {
                newsToUpdate.NewsImages = Images;
            }

            await _newsRepository.UpdateAsync(newsToUpdate);

            msg = request.lang == "en"
                ? "The news has been Updated"
                : "تم تعديل الخبر بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
