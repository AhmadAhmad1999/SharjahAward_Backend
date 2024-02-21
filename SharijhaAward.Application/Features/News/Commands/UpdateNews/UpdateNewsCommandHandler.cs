using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.UpdateNews
{
    public class UpdateNewsCommandHandler
        : IRequestHandler<UpdateNewsCommand, BaseResponse<Domain.Entities.NewsModel.News>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IMapper _mapper;

        public UpdateNewsCommandHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<Domain.Entities.NewsModel.News>> Handle(UpdateNewsCommand request, CancellationToken cancellationToken)
        {
            var newsToUpdate = await _newsRepository.GetByIdAsync(request.Id);
           
            string msg = "";
            if (newsToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "The News is not Found"
                    : "الخبر غير موجود";

                return new BaseResponse<Domain.Entities.NewsModel.News>(msg,false,404);
            }
            _mapper.Map(request,newsToUpdate,typeof(UpdateNewsCommand),typeof(Domain.Entities.NewsModel.News));
            
            await _newsRepository.UpdateAsync(newsToUpdate);

            msg = request.lang == "en"
                ? "The news has been Updated"
                : "تم تعديل الخبر بنجاح";

          

            return new BaseResponse<Domain.Entities.NewsModel.News>(msg, true, 200);
        }
    }
}
