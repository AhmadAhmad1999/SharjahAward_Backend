using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId;
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
        private readonly IAsyncRepository<DarkCard> _darkCardRepository;
        private readonly IAsyncRepository<ParagraphCard> _paragraphCardRepository;
        private readonly IMapper _mapper;

        public GetPageBySlugQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository, IAsyncRepository<DarkCard> darkCardRepository, IAsyncRepository<ParagraphCard> paragraphCardRepository, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _darkCardRepository = darkCardRepository;
            _paragraphCardRepository = paragraphCardRepository;
            _mapper = mapper;   
        }
        public async Task<BaseResponse<PageDto>> Handle(GetPageBySlugQuery request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository.FirstOrDefaultAsync(p=>p.Slug == request.Slug);

            if (page == null)
            {
                return new BaseResponse<PageDto>("", false, 404);
            }

            var DarkCards = _darkCardRepository.Where(d => d.PageId == page!.Id).ToList();

            var ParagraphCards = _paragraphCardRepository.Where(p => p.PageId == page!.Id).ToList();

            var data = _mapper.Map<PageDto>(page);

            var DarkCardsList = DarkCards
                .Select(x => new DarkCardListVM()
                {
                    Id = x.Id,
                    Title = request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    Content = request.lang == "en"
                        ? x.EnglishContent
                        : x.ArabicContent,
                    EnglishTitle = x.EnglishTitle,
                    ArabicTitle = x.ArabicTitle,
                    EnglishContent = x.EnglishContent,
                    ArabicContent = x.ArabicContent
                }).ToList();

            //data.DarkCards = _mapper.Map<List<DarkCardListVM>>(DarkCards);

            var ParagraphCardsList = ParagraphCards
                .Select(x => new ParagraphCardListVM()
                {
                    Id = x.Id,
                    Title = request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    Content = request.lang == "en"
                        ? x.EnglishContent
                        : x.ArabicContent,
                    EnglishTitle = x.EnglishTitle,
                    ArabicTitle = x.ArabicTitle,
                    EnglishContent = x.EnglishContent,
                    ArabicContent = x.ArabicContent,
                    ImageInStart = x.ImageInStart,
                    ImageUrl = x.ImageUrl,
                    PageId = x.PageId
                }).ToList();

            foreach (var Darkcard in DarkCardsList)
            {
                var Component = new Component()
                {
                    Card = Darkcard,
                    CardType = "Darkcard"
                };

                data.Components!.Add(Component);
            }

            foreach (var Paragraphcard in ParagraphCardsList)
            {
                var Component = new Component()
                {
                    Card = Paragraphcard,
                    CardType = "Paragraphcard"
                };

                data.Components!.Add(Component);
            }

            //data.ParagraphCards = _mapper.Map<List<ParagraphCardListVM>>(ParagraphCards);

            data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle;

            data.SubTitle = request.lang == "en" ? data.EnglishSubTitle! : data.ArabicSubTitle!;

            data.Content = request.lang == "en" ? data.EnglishContent! : data.ArabicContent!;

            return new BaseResponse<PageDto>("", true, 200, data);
        }
    }
}
