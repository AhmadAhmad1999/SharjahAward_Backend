using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.GetNewsById
{
    public class GetNewsByIdQueryHandler
        : IRequestHandler<GetNewsByIdQuery, BaseResponse<NewsVM>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IMapper _mapper;

        public GetNewsByIdQueryHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<NewsVM>> Handle(GetNewsByIdQuery request, CancellationToken cancellationToken)
        {
            var news = await _newsRepository.GetByIdAsync(request.Id);
            string msg;

            if (news == null)
            {
                msg = request.lang == "en"
                    ? "The News is Not Found"
                    : "الخبر غير موجود";

                return new BaseResponse<NewsVM>(msg, false, 404);
            }
            msg = request.lang == "en"
                    ? "The News Retrieved Success"
                    : "تم استرجاع الخبر بنجاح";

            NewsVM newsVM = new NewsVM()
            {
                Id=news.Id,
                ArabicTitle = news.ArabicTitle,
                ArabicDescription = news.ArabicDescription,
                CycleId = news.CycleId,
                EnglishTitle = news.EnglishTitle,
                EnglishDescription = news.EnglishDescription,
                Image=news.Image,
                Title = request.lang=="en" ? news.EnglishTitle : news.ArabicTitle, 
                Description = request.lang == "en" ? news.EnglishDescription : news.ArabicDescription
            };
            var Data = _mapper.Map<NewsVM>(newsVM);

            return new BaseResponse<NewsVM>(msg, true, 200, Data);

        }
    }
}
