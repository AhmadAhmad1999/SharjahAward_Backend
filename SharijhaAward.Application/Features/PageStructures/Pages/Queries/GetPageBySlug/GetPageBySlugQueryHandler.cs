using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;
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

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageBySlug
{
    public class GetPageBySlugQueryHandler
        : IRequestHandler<GetPageBySlugQuery, BaseResponse<PageDto>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IAsyncRepository<PageStructureImages> _pageStructureImagesRepository;
        private readonly IAsyncRepository<PageCard> _PageCardRepository;
        private readonly IAsyncRepository<ImageCard> _ImageCardRepository;
        private readonly IMapper _mapper;

        public GetPageBySlugQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository,
            IMapper mapper, 
            IAsyncRepository<PageStructureImages> pageStructureImagesRepository,
            IAsyncRepository<PageCard> PageCardRepository,
            IAsyncRepository<ImageCard> ImageCardRepository)
        {
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
            _pageStructureImagesRepository = pageStructureImagesRepository;
            _PageCardRepository = PageCardRepository;
            _ImageCardRepository = ImageCardRepository;
        }
        public async Task<BaseResponse<PageDto>> Handle(GetPageBySlugQuery request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository
                .FirstOrDefaultAsync(p => p.Slug == request.Slug);

            if (page == null)
            {
                return new BaseResponse<PageDto>("", false, 404);
            }

            var data = _mapper.Map<PageDto>(page);

            data.Components = new List<Component>();
           

            var DarkCardsList = _mapper.Map<List<DarkCardListVM>>(await _PageCardRepository
                .Where(x => x.PageId == page.Id && x.CardType == CardType.DarkCard)
                .ToListAsync());

            var ParagraphCardsList = _mapper.Map<List<ParagraphCardListVM>>(await _PageCardRepository
                .Where(x => x.PageId == page.Id && x.CardType == CardType.ParagraphCard)
                .ToListAsync());

            var ImageCardsList = _mapper.Map<List<ImageCardListVM>>(await _ImageCardRepository
                .Where(x => x.PageId == page.Id)
                .ToListAsync());

            var TextCardsList = _mapper.Map<List<TextCardListVM>>(await _PageCardRepository
                .Where(x => x.PageId == page.Id && x.CardType == CardType.TextCard)
                .ToListAsync());
            
            var GoalCardsList = _mapper.Map<List<GoalCardListVM>>(await _PageCardRepository
                .Where(x => x.PageId == page.Id && x.CardType == CardType.GoalCard)
                .ToListAsync());

            foreach (var Darkcard in DarkCardsList)
            {
                Darkcard.Title = request.lang == "en" ? Darkcard.EnglishTitle : Darkcard.ArabicTitle;
                Darkcard.Content = request.lang == "en" ? Darkcard.EnglishContent : Darkcard.ArabicContent;

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
                Paragraphcard.Title = request.lang == "en" ? Paragraphcard.EnglishTitle : Paragraphcard.ArabicTitle;
                Paragraphcard.Content = request.lang == "en" ? Paragraphcard.EnglishContent : Paragraphcard.ArabicContent;
               
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

                Textcard.Content = request.lang == "en" ? Textcard.EnglishContent : Textcard.ArabicContent;

                var Component = new Component()
                {
                    Card = Textcard,
                    CardType = "TextCard",
                    orderId = Textcard.orderId
                };

                data.Components!.Add(Component);
            }

            var goalComponent = new Component()
            {
                Goals = GoalCardsList,
                CardType = "GoalCard",
                orderId = 0
            };

            data.Components.Add(goalComponent);

            data.Components = data.Components.OrderBy(c => c.orderId).ToList();
            //data.Goals = data.Goals.OrderBy(c => c.orderId).ToList();

            data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle;

            data.SubTitle = request.lang == "en" ? data.EnglishSubTitle! : data.ArabicSubTitle!;

            data.Content = request.lang == "en" ? data.EnglishContent! : data.ArabicContent!;

            data.numberOfSubPages = _pageStructureRepository.GetCount(p => p.ParentId == page.Id && !p.isDeleted);

            return new BaseResponse<PageDto>("", true, 200, data);
        }
    }
}
