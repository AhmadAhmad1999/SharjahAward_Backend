﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
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
                .FirstOrDefaultAsync(n => n.Id == request.Id);
           
            string msg;
            if (newsToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "The Home Page Slider Item is not Found"
                    : "سلايدر الصور غير موجود";

                return new BaseResponse<object>(msg,false,404);
            }
            var Image = newsToUpdate.Image;

            _mapper.Map(request,newsToUpdate,typeof(UpdateNewsCommand),typeof(Domain.Entities.NewsModel.News));

            newsToUpdate.Image = request.EditeOnImage == true
                ? newsToUpdate.Image = await _fileService.SaveFileAsync(request.Image!, SystemFileType.Images)
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
                            ImageUrl = await _fileService.SaveFileAsync(image, SystemFileType.Images)
                        };
                        await _newsImageRepository.AddAsync(NewsImage); 
                    }
                }
            }

            await _newsRepository.UpdateAsync(newsToUpdate);

            msg = request.lang == "en"
                ? "The Home Page Slider Item has been Updated"
                : "تم تعديل سلايدر الصور بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
