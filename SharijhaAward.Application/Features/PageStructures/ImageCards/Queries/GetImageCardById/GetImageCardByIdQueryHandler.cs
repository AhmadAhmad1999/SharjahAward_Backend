using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetImageCardById
{
    public class GetImageCardByIdQueryHandler
        : IRequestHandler<GetImageCardByIdQuery, BaseResponse<ImageCardDto>>
    {
        private readonly IAsyncRepository<ImageCard> _imageCardRepository;
        private readonly IMapper _mapper;

        public GetImageCardByIdQueryHandler(IAsyncRepository<ImageCard> imageCardRepository, IMapper mapper)
        {
            _imageCardRepository = imageCardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ImageCardDto>> Handle(GetImageCardByIdQuery request, CancellationToken cancellationToken)
        {
            var imageCard = await _imageCardRepository
                .WhereThenInclude(i => i.Id == request.Id, i => i.Images)
                .FirstOrDefaultAsync();
            
            if(imageCard == null)
            {
                return new BaseResponse<ImageCardDto>("Image Card Not Found", false, 404);
            }

            var data = _mapper.Map<ImageCardDto>(imageCard);

            return new BaseResponse<ImageCardDto>("", true, 200, data);
        }
    }
}
