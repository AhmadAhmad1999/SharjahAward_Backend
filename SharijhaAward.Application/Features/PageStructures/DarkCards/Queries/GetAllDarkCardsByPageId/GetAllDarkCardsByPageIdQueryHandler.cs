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

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId
{
    public class GetAllDarkCardsByPageIdQueryHandler
        : IRequestHandler<GetAllDarkCardsByPageIdQuery, BaseResponse<List<DarkCardListVM>>>
    {
        private readonly IAsyncRepository<DarkCard> _darkCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public GetAllDarkCardsByPageIdQueryHandler(IAsyncRepository<DarkCard> darkCardRepository, IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _darkCardRepository = darkCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<DarkCardListVM>>> Handle(GetAllDarkCardsByPageIdQuery request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);
            if (page == null)
            {
               string msg = request.lang == "en"
                            ? "Page Not found"
                            : "الصفحة غير موجودة";

                return new BaseResponse<List<DarkCardListVM>>(msg, false, 404);
            }

            var Cards = _darkCardRepository
                .Where(c => c.PageId == page.Id)
                .Where(c => !c.IsHide)
                .ToList()
                .OrderBy(c=>c.orderId);

            var data = _mapper.Map<List<DarkCardListVM>>(Cards);
           
            foreach(var card in data)
            {
                card.Title = request.lang == "en" ? card.EnglishTitle : card.ArabicTitle;
                card.Content = request.lang =="en"? card.EnglishContent : card.ArabicContent;
            }
            
            return new BaseResponse<List<DarkCardListVM>>("", true, 200, data);
        }
    }
}
