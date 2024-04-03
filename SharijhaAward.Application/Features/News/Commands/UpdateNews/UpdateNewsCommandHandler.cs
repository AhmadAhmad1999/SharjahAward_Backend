using AutoMapper;
using MediatR;
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
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateNewsCommandHandler(IFileService fileService, IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateNewsCommand request, CancellationToken cancellationToken)
        {
            var newsToUpdate = await _newsRepository.GetByIdAsync(request.Id);
           
            string msg;
            if (newsToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "The News is not Found"
                    : "الخبر غير موجود";

                return new BaseResponse<object>(msg,false,404);
            }
            var news = newsToUpdate;
            _mapper.Map(request,newsToUpdate,typeof(UpdateNewsCommand),typeof(Domain.Entities.NewsModel.News));
           
            if (request.EditeOnImage)
                newsToUpdate.Image = await _fileService.SaveFileAsync(request.Image!);
            else
                newsToUpdate.Image = news.Image;

            await _newsRepository.UpdateAsync(newsToUpdate);

            msg = request.lang == "en"
                ? "The news has been Updated"
                : "تم تعديل الخبر بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
