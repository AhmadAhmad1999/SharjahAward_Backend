using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId
{
    public class GetAllParagraphCardsByPageIdQueryHandler
        : IRequestHandler<GetAllParagraphCardsByPageIdQuery, BaseResponse<List<ParagraphCardListVM>>>
    { 
        private readonly IAsyncRepository<ParagraphCard> _paragraphCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;
        public GetAllParagraphCardsByPageIdQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository, IAsyncRepository<ParagraphCard> paragraphCardRepository, IMapper mapper)
        {
            _paragraphCardRepository = paragraphCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<ParagraphCardListVM>>> Handle(GetAllParagraphCardsByPageIdQuery request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);
            if (page == null)
            {
                string msg = request.lang == "en"
                             ? "Page Not found"
                             : "الصفحة غير موجودة";

                return new BaseResponse<List<ParagraphCardListVM>>(msg, false, 404);
            }

            var Cards = _paragraphCardRepository
                .Where(c => c.PageId == page.Id)
                .ToList()
                .OrderBy(c=>c.orderId);

            var data = _mapper.Map<List<ParagraphCardListVM>>(Cards);

            foreach (var card in data)
            {
                card.Title = request.lang == "en" ? card.EnglishTitle : card.ArabicTitle;
                card.Content = request.lang == "en" ? card.EnglishContent : card.ArabicContent;
            }

            return new BaseResponse<List<ParagraphCardListVM>>("", true, 200, data);
        }
    }
}
