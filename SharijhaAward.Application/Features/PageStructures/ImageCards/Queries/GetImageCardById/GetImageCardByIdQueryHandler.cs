using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetImageCardById
{
    public class GetImageCardByIdQueryHandler
        : IRequestHandler<GetImageCardByIdQuery, BaseResponse<ImageCardDto>>
    {
        private readonly IAsyncRepository<ImageCard> _imageCardRepository;
        private readonly IAsyncRepository<PageStructureImages> _PageStructureImagesRepository;
        private readonly IMapper _mapper;

        public GetImageCardByIdQueryHandler(IAsyncRepository<ImageCard> imageCardRepository,
            IAsyncRepository<PageStructureImages> PageStructureImagesRepository,
            IMapper mapper)
        {
            _imageCardRepository = imageCardRepository;
            _PageStructureImagesRepository = PageStructureImagesRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ImageCardDto>> Handle(GetImageCardByIdQuery request, CancellationToken cancellationToken)
        {
            var imageCard = await _imageCardRepository
                .FirstOrDefaultAsync(i => i.Id == request.Id);

            if (imageCard == null)
            {
                return new BaseResponse<ImageCardDto>("Image Card Not Found", false, 404);
            }

            var data = _mapper.Map<ImageCardDto>(imageCard);

            data.CardImages = await _PageStructureImagesRepository
                .Where(x => x.ImageCardId == request.Id)
                .Select(x => new PageImageDto()
                {
                    Id = x.Id,
                    ImageId = x.ImageCardId,
                    ImageUrl = x.ImageUrl
                }).ToListAsync();

            return new BaseResponse<ImageCardDto>("", true, 200, data);
        }
    }
}
