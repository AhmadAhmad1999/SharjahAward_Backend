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
        : IRequestHandler<DeleteNewsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
       

        public DeleteNewsCommandHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteNewsCommand request, CancellationToken cancellationToken)
        {
            var news = await _newsRepository.GetByIdAsync(request.Id);
            string msg;

            if (news == null)
            {
                msg = request.lang == "en" 
                    ? "The News Not Found" 
                    : "الخبر غير موجود";
                return new BaseResponse<object>(msg, false, 404);
            }
            await _newsRepository.DeleteAsync(news);
          
            msg = request.lang == "en"
                  ? "The News has been Deleted"
                  :  "تم حذف الخبر بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
