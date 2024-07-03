using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId;
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
        private readonly IAsyncRepository<DarkCard> _darkCardRepository;
        private readonly IAsyncRepository<ParagraphCard> _paragraphCardRepository;
        private readonly IMapper _mapper;

        public GetPageByIdQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository, IAsyncRepository<DarkCard> darkCardRepository, IAsyncRepository<ParagraphCard> paragraphCardRepository, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _darkCardRepository = darkCardRepository;
            _paragraphCardRepository = paragraphCardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<PageDto>> Handle(GetPageByIdQuery request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository
                .WhereThenInclude(p => p.Id == request.Id, p => p.DarkCards!)
                .Include(p => p.ParagraphCards)
                .FirstOrDefaultAsync();
           
            if (page == null)
            {
                return new BaseResponse<PageDto>("", false, 404);
            }

            //var DarkCards = _darkCardRepository.Where(d => d.PageId == page!.Id).ToList();
           
            //var ParagraphCards = _paragraphCardRepository.Where(p => p.PageId == page!.Id).ToList();

            var data = _mapper.Map<PageDto>(page);

            data.Components = new List<Component>();

            var DarkCardsList = _mapper.Map<List<DarkCardListVM>>(page.DarkCards);

            var ParagraphCardsList = _mapper.Map<List<ParagraphCardListVM>>(page.ParagraphCards);

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

            data.Components.OrderBy(c => c.orderId);

            data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle;

            data.SubTitle = request.lang == "en" ? data.EnglishSubTitle! : data.ArabicSubTitle!;

            data.Content = request.lang == "en" ? data.EnglishContent! : data.ArabicContent!;

            return new BaseResponse<PageDto>("", true, 200, data);
        }

    }
}
