using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.DeleteNewsImage
{
    public class DeleteNewsImageCommandHandler
        : IRequestHandler<DeleteNewsImageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<NewsImage> _newsImageRepository;

        public DeleteNewsImageCommandHandler(IAsyncRepository<NewsImage> newsImageRepository)
        {
            _newsImageRepository = newsImageRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteNewsImageCommand request, CancellationToken cancellationToken)
        {
            var image = await _newsImageRepository.GetByIdAsync(request.Id);

            if(image == null)
            {
                string msg = request.lang == "en"
                    ? "Image not Found"
                    : "الصورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            
            await _newsImageRepository.DeleteAsync(image);

            return new BaseResponse<object>("", true, 200);
        }

    }
}
