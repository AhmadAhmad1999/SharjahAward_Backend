using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.UpdateImageCard
{
    public class UpdateImageCardCommandHandler
        : IRequestHandler<UpdateImageCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ImageCard> _imageCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public UpdateImageCardCommandHandler(IAsyncRepository<ImageCard> imageCardRepository, IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _imageCardRepository = imageCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateImageCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                    ? "Image Card has been Updated"
                    : "تم تعديل بطاقة الصور";

            var imageCard = await _imageCardRepository.GetByIdAsync(request.Id);
           
            if (imageCard == null)
            {
                msg = request.lang == "en"
                    ? "Image Card not Found"
                    : "بطاقة الصور غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var page = await _pageStructureRepository.GetByIdAsync(request.Id);
            
            if(page == null)
            {
                msg = request.lang == "en"
                    ? "Page not found"
                    : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 400);
            }

            _mapper.Map(request, imageCard, typeof(UpdateImageCardCommand), typeof(ImageCard));

            await _imageCardRepository.UpdateAsync(imageCard);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
