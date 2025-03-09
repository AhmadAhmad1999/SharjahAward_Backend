using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.GetNewsByCycleId
{
    public class GetNewsForWebsiteQueryHandler
        : IRequestHandler<GetNewsForWebsiteQuery, BaseResponse<List<NewsListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IMapper _mapper;
        
        public GetNewsForWebsiteQueryHandler(IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<NewsListVM>>> Handle(GetNewsForWebsiteQuery request, CancellationToken cancellationToken)
        {
            string msg;

            var NewsList = await _newsRepository.GetWhereThenPagedReponseAsync(n=>!n.IsHidden, request.page, request.perPage);
            
            if (!string.IsNullOrEmpty(request.query))
            {
                NewsList = await _newsRepository
                    .Where(n => n.EnglishTitle.ToLower().Contains(request.query!.ToLower()) && !n.IsHidden)
                    .OrderByDescending(x => x.CreatedAt).ToListAsync();

                if (NewsList.Count() == 0)
                {
                    NewsList = await _newsRepository
                        .Where(n => n.ArabicTitle.ToLower().Contains(request.query!.ToLower()) && !n.IsHidden)
                        .OrderByDescending(x => x.CreatedAt).ToListAsync();
                }
            }

            if (NewsList == null)
            {
                msg = request.lang == "en"
                    ? "There is No News"
                    : "لا يوجد أخبار";

                return new BaseResponse<List<NewsListVM>>(msg, true, 200);
            }
            var data = _mapper.Map<List<NewsListVM>>(NewsList);

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Title = request.lang == "en"
                        ? NewsList[i].EnglishTitle
                        : NewsList[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                        ? NewsList[i].EnglishDescription!
                        : NewsList[i].ArabicDescription!;
            }
           
            int count = _newsRepository.GetCount(n => !n.IsHidden);
            
            Pagination pagination = new Pagination(request.page, request.perPage, count);

            if (!string.IsNullOrEmpty(request.query))
                return new BaseResponse<List<NewsListVM>>("", true, 200, data);

            return new BaseResponse<List<NewsListVM>>("", true, 200, data, pagination);
        }
    }
}
