using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.CreateImageCard
{
    public class CreateImageCardCommandHandler
        : IRequestHandler<CreateImageCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ImageCard> _imageCardRepository;
        private readonly IAsyncRepository<PageStructureImages> _pageStructureImagesRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateImageCardCommandHandler(IFileService fileService, IAsyncRepository<ImageCard> imageCardRepository, IAsyncRepository<PageStructureImages> pageStructureImagesRepository, IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _imageCardRepository = imageCardRepository;
            _pageStructureImagesRepository = pageStructureImagesRepository;
            _pageStructureRepository = pageStructureRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateImageCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Image Card has been Created"
                : "تم إنشاء بطاقة الصور";

            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);
           
            if(page == null)
            {
                msg = request.lang == "en"
                    ? "Page not found"
                    : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 400);
            }
  
            var imageCard = _mapper.Map<ImageCard>(request);

            var data = await _imageCardRepository.AddAsync(imageCard);
            
            foreach(var image in request.CardImages)
            {
                var pageImage = new PageStructureImages()
                {
                    ImageUrl = await _fileService.SaveFileAsync(image),
                    ImageId = data.Id
                };

                await _pageStructureImagesRepository.AddAsync(pageImage);
            }

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
