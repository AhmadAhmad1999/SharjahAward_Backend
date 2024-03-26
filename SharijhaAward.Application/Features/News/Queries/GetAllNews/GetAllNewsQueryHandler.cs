using AutoMapper;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Persistence;
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
            if (request.query.IsNullOrEmpty())
            {

                var newsList = await _newsRepository.GetPagedReponseAsync(request.page, request.pageSize);

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
                    }

                }

                int count = _newsRepository.GetCount(n => n.isDeleted == false);
                Pagination pagination = new Pagination(request.page, request.pageSize, count);
                return new BaseResponse<List<NewsListVM>>("", true, 200, data, pagination);
            }
            return new BaseResponse<List<NewsListVM>>("", true, 200);
        }
    }
}
