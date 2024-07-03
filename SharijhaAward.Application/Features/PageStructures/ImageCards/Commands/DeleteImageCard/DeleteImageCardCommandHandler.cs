using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.DeleteImageCard
{
    public class DeleteImageCardCommandHandler
        : IRequestHandler<DeleteImageCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ImageCard> _imageCardRepository;

        public DeleteImageCardCommandHandler(IAsyncRepository<ImageCard> imageCardRepository)
        {
            _imageCardRepository = imageCardRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteImageCardCommand request, CancellationToken cancellationToken)
        {
            var imageCard = await _imageCardRepository.GetByIdAsync(request.Id);
            
            if(imageCard == null)
            {
                string msg = request.lang == "en"
                    ? "Image Card not Found"
                    : "بطاقة الصور غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _imageCardRepository.DeleteAsync(imageCard);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
