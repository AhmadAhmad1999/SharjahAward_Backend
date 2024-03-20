using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
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
    public class GetNewsByCycleIdQueryHandler
        : IRequestHandler<GetNewsByCycleIdQuery, BaseResponse<List<NewsListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;
        
        public GetNewsByCycleIdQueryHandler(IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _newsRepository = newsRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<NewsListVM>>> Handle(GetNewsByCycleIdQuery request, CancellationToken cancellationToken)
        {
            var Cycle = await _cycleRepository.OrderBy(c=>c.CreatedAt).LastOrDefaultAsync();
            var NewsListByCycle = _newsRepository.Where(n => n.CycleId == Cycle!.Id).ToList();
            string msg;

            if (NewsListByCycle.Count == 0)
            {
                msg = request.lang == "en"
                    ? "There is No News"
                    : "لا يوجد أخبار";

                return new BaseResponse<List<NewsListVM>>(msg, true, 200);
            }
            var data = _mapper.Map<List<NewsListVM>>(NewsListByCycle);

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Title = request.lang == "en"
                        ? NewsListByCycle[i].EnglishTitle
                        : NewsListByCycle[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                        ? NewsListByCycle[i].EnglishDescription!
                        : NewsListByCycle[i].ArabicDescription!;
            }

            msg = request.lang == "en"
                ? "The News Retrieved Success"
                : "تم إسترجاع الاأخبار بنجاح";

            return new BaseResponse<List<NewsListVM>>(msg, true, 200, data);
        }
    }
}
