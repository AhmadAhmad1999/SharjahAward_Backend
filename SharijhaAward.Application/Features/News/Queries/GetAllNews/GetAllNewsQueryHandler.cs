using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.News.Queries.GetNewsById;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var newsList = await _newsRepository
                .OrderByDescending(x => x.CreatedAt, request.page, request.perPage)
                .Include(n=>n.NewsImages)
                .ToListAsync();
           
            int count = _newsRepository.GetCount(n => n.isDeleted == false);
            
            Pagination pagination = new Pagination(request.page, request.perPage, count);
            
            if (!request.query.IsNullOrEmpty())
            {
                newsList = await _newsRepository
                    .Where(n => n.EnglishTitle.ToLower().Contains(request.query!.ToLower()))
                    .OrderByDescending(x => x.CreatedAt).ToListAsync();

                if (newsList.Count() == 0)
                {
                    newsList = await _newsRepository
                        .Where(n => n.ArabicTitle.ToLower().Contains(request.query.ToLower()))
                        .OrderByDescending(x => x.CreatedAt).ToListAsync();
                }
            }
            var data = _mapper.Map<List<NewsListVM>>(newsList);

            if (data.Count != 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    data[i].Title = request.lang == "en"
                        ? data[i].EnglishTitle
                        : data[i].ArabicTitle;

                    data[i].Description = request.lang == "en"
                        ? data[i].EnglishDescription!
                        : data[i].ArabicDescription!;

                    data[i].Images = _mapper.Map<List<NewsImagesDto>>(newsList[i].NewsImages);
                }

            }
            if (!request.query.IsNullOrEmpty())
                return new BaseResponse<List<NewsListVM>>("", true, 200, data);
            
            return new BaseResponse<List<NewsListVM>>("", true, 200, data, pagination);
           
        }
    }
}
