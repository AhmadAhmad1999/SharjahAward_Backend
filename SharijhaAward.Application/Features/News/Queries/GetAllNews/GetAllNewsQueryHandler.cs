using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.GetAllNews
{
    public class GetAllNewsQueryHandler
        : IRequestHandler<GetAllNewsQuery, BaseResponse<List<NewsListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IMapper _mapper;

        public GetAllNewsQueryHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<NewsListVM>>> Handle(GetAllNewsQuery request, CancellationToken cancellationToken)
        {
            var newsList = request.pageSize == -1 || request.page == 0
                ? await _newsRepository.ListAllAsync()
                : await _newsRepository.GetPagedReponseAsync(request.page, request.pageSize);
            string msg;
            var Data = _mapper.Map<List<NewsListVM>>(newsList);

            if (newsList.Count== 0)
            {
                msg = request.lang == "en"
                    ? "There is No News"
                    : "لا يوجد أخبار";

                return new BaseResponse<List<NewsListVM>>(msg, true, 200, Data);
            }
            

            for(int i = 0; i< Data.Count; i++)
            {
                Data[i].Title = request.lang == "en"
                    ? Data[i].EnglishTitle
                    : Data[i].ArabicTitle;

                Data[i].Description = request.lang == "en"
                    ? Data[i].EnglishDescription!
                    : Data[i].ArabicDescription!;
            }
            

            msg = request.lang == "en"
                ? "The News Retrieved Success"
                : "تم إسترجاع الأخبار بنجاح";

            int count =  _newsRepository.ListAllAsync().Result.Count();
            return new BaseResponse<List<NewsListVM>>(msg, false, 200, Data, count);
        }
    }
}
