using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.DeleteNews
{
    public class DeleteNewsCommandHandler
        : IRequestHandler<DeleteNewsCommand, BaseResponse<Domain.Entities.NewsModel.News>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
       

        public DeleteNewsCommandHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<BaseResponse<Domain.Entities.NewsModel.News>> Handle(DeleteNewsCommand request, CancellationToken cancellationToken)
        {
            string msg = "";

            var news = await _newsRepository.GetByIdAsync(request.Id);
            if (news == null)
            {
                
                msg = request.lang == "en" 
                    ? "The News Not Found" 
                    : "الخبر غير موجود";
                return new BaseResponse<Domain.Entities.NewsModel.News>(msg,false,404);
            }
            await _newsRepository.DeleteAsync(news);
          
            msg = request.lang == "en"
                  ? "The News has been Deleted"
                  :  "تم حذف الخبر بنجاح";

            return new BaseResponse<Domain.Entities.NewsModel.News>(msg, true, 200);
        }
    }
}
