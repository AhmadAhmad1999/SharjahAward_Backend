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
            var data = _mapper.Map<NewsVM>(news);

            data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle;
            data.Description = request.lang == "en" ? data.EnglishDescription! : data.ArabicDescription!;

            return new BaseResponse<NewsVM>("", true, 200, data);
        }
    }
}
