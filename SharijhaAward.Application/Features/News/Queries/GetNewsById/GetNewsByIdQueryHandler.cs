using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsModel;

namespace SharijhaAward.Application.Features.News.Queries.GetNewsById
{
    public class GetNewsByIdQueryHandler
        : IRequestHandler<GetNewsByIdQuery, BaseResponse<NewsDto>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IAsyncRepository<NewsImage> _NewsImageRepository;
        private readonly IMapper _mapper;

        public GetNewsByIdQueryHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository,
            IAsyncRepository<NewsImage> NewsImageRepository,
            IMapper mapper)
        {
            _newsRepository = newsRepository;
            _NewsImageRepository = NewsImageRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<NewsDto>> Handle(GetNewsByIdQuery request, CancellationToken cancellationToken)
        {
            var news = await _newsRepository
                .FirstOrDefaultAsync(n => n.Id == request.Id);
                
            string msg;

            if (news == null)
            {
                msg = request.lang == "en"
                    ? "The News is Not Found"
                    : "الخبر غير موجود";

                return new BaseResponse<NewsDto>(msg, false, 404);
            }
            var data = _mapper.Map<NewsDto>(news);

            data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle;
            data.Description = request.lang == "en" ? data.EnglishDescription! : data.ArabicDescription!;
            data.Images = _mapper.Map<List<NewsImagesDto>>(await _NewsImageRepository
                .Where(x => x.Id == request.Id)
                .ToListAsync());
            
            return new BaseResponse<NewsDto>("", true, 200, data);
        }
    }
}
