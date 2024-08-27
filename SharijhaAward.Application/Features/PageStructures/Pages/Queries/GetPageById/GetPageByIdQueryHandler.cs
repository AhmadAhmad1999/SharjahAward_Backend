using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetAllTextCard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById
{
    public class GetPageByIdQueryHandler
        : IRequestHandler<GetPageByIdQuery, BaseResponse<PageDto>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IAsyncRepository<PageStructureImages> _pageStructureImagesRepository;
        private readonly IAsyncRepository<DarkCard> _DarkCardRepository;
        private readonly IAsyncRepository<ParagraphCard> _ParagraphCardRepository;
        private readonly IAsyncRepository<TextCard> _TextCardRepository;
        private readonly IAsyncRepository<ImageCard> _ImageCardRepository;
        private readonly IMapper _mapper;

        public GetPageByIdQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository,
            IAsyncRepository<PageStructureImages> pageStructureImagesRepository,
            IAsyncRepository<DarkCard> DarkCardRepository,
            IAsyncRepository<ParagraphCard> ParagraphCardRepository,
            IAsyncRepository<TextCard> TextCardRepository,
            IAsyncRepository<ImageCard> ImageCardRepository,
            IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _pageStructureImagesRepository = pageStructureImagesRepository;
            _DarkCardRepository = DarkCardRepository;
            _ParagraphCardRepository = ParagraphCardRepository;
            _TextCardRepository = TextCardRepository;
            _ImageCardRepository = ImageCardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<PageDto>> Handle(GetPageByIdQuery request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository
                .FirstOrDefaultAsync(p => p.Id == request.Id);
           
            if (page == null)
            {
                return new BaseResponse<PageDto>("", false, 404);
            }

            var data = _mapper.Map<PageDto>(page);

            data.Components = new List<Component>();

            var DarkCardsList = _mapper.Map<List<DarkCardListVM>>(await _DarkCardRepository
                .Where(x => x.PageId == request.Id)
                .ToListAsync());

            var ParagraphCardsList = _mapper.Map<List<ParagraphCardListVM>>(await _ParagraphCardRepository
                .Where(x => x.PageId == request.Id)
                .ToListAsync());

            var ImageCardsList = _mapper.Map<List<ImageCardListVM>>(await _ImageCardRepository
                .Where(x => x.PageId == request.Id)
                .ToListAsync());

            var TextCardsList = _mapper.Map<List<TextCardListVM>>(await _TextCardRepository
                .Where(x => x.PageStructureId == request.Id)
                .ToListAsync());

            foreach(var Darkcard in DarkCardsList)
            {
                var Component = new Component()
                {
                    Card = Darkcard,
                    CardType = "DarkCard",
                    orderId = Darkcard.orderId
                };

                data.Components!.Add(Component);
            }

            foreach (var Paragraphcard in ParagraphCardsList)
            {
                var Component = new Component()
                {
                    Card = Paragraphcard,
                    CardType = "ParagraphCard",
                    orderId = Paragraphcard.orderId
                };

                data.Components!.Add(Component);
            }

            foreach (var Imagecard in ImageCardsList)
            {
                var Images = _pageStructureImagesRepository.Where(i => i.ImageCardId == Imagecard.Id).ToList();
                
                Imagecard.CardImages = _mapper.Map<List<PageImageDto>>(Images);
                
                var Component = new Component()
                {
                    Card = Imagecard,
                    CardType = "ImageCard",
                    orderId = Imagecard.orderId
                };

                data.Components!.Add(Component);
            }

            foreach (var Textcard in TextCardsList)
            {
                var Component = new Component()
                {
                    Card = Textcard,
                    CardType = "TextCard",
                    orderId = Textcard.orderId
                };

                data.Components!.Add(Component);
            }

            data.Components = data.Components.OrderBy(c => c.orderId).ToList();

            data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle;

            data.SubTitle = request.lang == "en" ? data.EnglishSubTitle! : data.ArabicSubTitle!;

            data.Content = request.lang == "en" ? data.EnglishContent! : data.ArabicContent!;
           
            data.numberOfSubPages = _pageStructureRepository.GetCount(p => p.ParentId == page.Id && !p.isDeleted);
            
            return new BaseResponse<PageDto>("", true, 200, data);
        }

    }
}
