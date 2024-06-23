using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.HideNews
{
    public class HideNewsQueryHandler
        : IRequestHandler<HideNewsQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;

        public HideNewsQueryHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<BaseResponse<object>> Handle(HideNewsQuery request, CancellationToken cancellationToken)
        {
            var news = await _newsRepository.GetByIdAsync(request.Id);
            if(news == null)
            {
                return new BaseResponse<object>("الخبر غير موجود", false, 404);
            }
            news.IsHidden = request.IsHidden;

            await _newsRepository.UpdateAsync(news);

            return new BaseResponse<object>("تم تعديل حالة الخبر", true, 200);
        }
    }
}
