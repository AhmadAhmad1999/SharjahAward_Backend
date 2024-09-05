using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCardsDashboard
{
    public class GetAllImageCardsDashboardQueryHandler
        : IRequestHandler<GetAllImageCardsDashboardQuery, BaseResponse<List<ImageCardListVM>>>
    {
        private readonly IAsyncRepository<ImageCard> _imageCardsRepository;
        private readonly IAsyncRepository<PageStructureImages> _pageStructuresImagesRepository;
        private readonly IMapper _mapper;

        public GetAllImageCardsDashboardQueryHandler(IAsyncRepository<PageStructureImages> pageStructuresImagesRepository, IAsyncRepository<ImageCard> imageCardsRepository, IMapper mapper)
        {
            _imageCardsRepository = imageCardsRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<ImageCardListVM>>> Handle(GetAllImageCardsDashboardQuery request, CancellationToken cancellationToken)
        {
            var ImageCards = request.pageId == null
                ? await _imageCardsRepository.GetPagedReponseAsync(request.page, request.perPage)
                : await _imageCardsRepository.GetWhereThenPagedReponseAsync(c => c.PageId == request.pageId, request.page, request.perPage);
            
            var data = _mapper.Map<List<ImageCardListVM>>(ImageCards);
            
            foreach(var imageCard in data)
            {
                var Images = await _pageStructuresImagesRepository
                    .Where(p => p.ImageCardId == imageCard.Id)
                    .ToListAsync();
                
                imageCard.CardImages = _mapper.Map<List<PageImageDto>>(Images);
            }

            data.ToList().OrderBy(c => c.orderId);

            int count = _imageCardsRepository.GetCount(i => !i.isDeleted);

            Pagination pagination = new Pagination(request.page, request.perPage, count);

            return new BaseResponse<List<ImageCardListVM>>("", true, 200, data, pagination);
        }
    }
}
