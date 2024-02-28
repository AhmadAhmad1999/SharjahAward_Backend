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
            if(newsList.Count== 0)
            {
                msg = request.lang == "en"
                    ? "There is No News"
                    : "لا يوجد أخبار";

                return new BaseResponse<List<NewsListVM>>(msg, true, 200);
            }
            List<NewsListVM> newsListVm = new List<NewsListVM>();

            for(int i = 0; i< newsList.Count; i++)
            {
                NewsListVM newsVM = new NewsListVM();
                newsVM.Id = newsList[i].Id;
                newsVM.ArabicTitle = newsList[i].ArabicTitle;
                newsVM.ArabicDescription = newsList[i].ArabicDescription;
                newsVM.EnglishTitle = newsList[i].EnglishTitle;
                newsVM.EnglishDescription = newsList[i].EnglishDescription;
                newsVM.CycleId = newsList[i].CycleId;
                newsVM.Image = newsList[i].Image;
                newsVM.Title = request.lang == "en"
                    ? newsList[i].EnglishTitle
                    : newsList[i].ArabicTitle;

                newsVM.Description = request.lang == "en"
                    ? newsList[i].EnglishDescription!
                    : newsList[i].ArabicDescription!;
                newsListVm.Add(newsVM);
            }
            var Data = _mapper.Map<List<NewsListVM>>(newsListVm);

            msg = request.lang == "en"
                ? "The News Retrieved Success"
                : "تم إسترجاع الأخبار بنجاح";

            int count =  _newsRepository.ListAllAsync().Result.Count();
            return new BaseResponse<List<NewsListVM>>(msg, false, 200, Data, count);
        }
    }
}
