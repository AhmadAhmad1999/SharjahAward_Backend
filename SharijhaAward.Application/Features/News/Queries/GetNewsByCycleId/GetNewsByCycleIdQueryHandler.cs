using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.GetNewsByCycleId
{
    public class GetNewsByCycleIdQueryHandler
        : IRequestHandler<GetNewsByCycleIdQuery, BaseResponse<List<NewsListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IMapper _mapper;
        
        public GetNewsByCycleIdQueryHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<NewsListVM>>> Handle(GetNewsByCycleIdQuery request, CancellationToken cancellationToken)
        {
            var NewsListByCycle = request.pageSize == -1 || request.page == 0
                ? await _newsRepository.ListAllAsync()
                : await _newsRepository.GetPagedReponseAsync(request.page, request.pageSize);
            string msg;

            if (NewsListByCycle.Count == 0)
            {
                msg = request.lang == "en"
                    ? "There is No News"
                    : "لا يوجد أخبار";

                return new BaseResponse<List<NewsListVM>>(msg, false, 404);
            }
            List<NewsListVM> newsListVm = new List<NewsListVM>();

            for (int i = 0; i < NewsListByCycle.Count; i++)
            {
                NewsListVM newsVM = new NewsListVM();
                if (NewsListByCycle[i].CycleId == request.CycleId)
                {
                    newsVM.Id = NewsListByCycle[i].Id;
                    newsVM.ArabicTitle = NewsListByCycle[i].ArabicTitle;
                    newsVM.ArabicDescription = NewsListByCycle[i].ArabicDescription;
                    newsVM.EnglishTitle = NewsListByCycle[i].EnglishTitle;
                    newsVM.EnglishDescription = NewsListByCycle[i].EnglishDescription;
                    newsVM.CycleId = NewsListByCycle[i].CycleId;
                    newsVM.Image = NewsListByCycle[i].Image;
                    newsVM.Title = request.lang == "en"
                        ? NewsListByCycle[i].EnglishTitle
                        : NewsListByCycle[i].ArabicTitle;

                    newsVM.Description = request.lang == "en"
                        ? NewsListByCycle[i].EnglishDescription!
                        : NewsListByCycle[i].ArabicDescription!;

                    newsListVm.Add(newsVM);
                }
            }
            var Data = _mapper.Map<List<NewsListVM>>(newsListVm);

            msg = request.lang == "en"
                ? "The News Retrieved Success"
                : "تم إسترجاع الاأخبار بنجاح";


            return new BaseResponse<List<NewsListVM>>(msg, false, 200, Data);
        }
    }
}
