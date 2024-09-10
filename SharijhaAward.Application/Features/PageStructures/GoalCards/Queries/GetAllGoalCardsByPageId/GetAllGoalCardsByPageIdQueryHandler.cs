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

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId
{
    public class GetAllGoalCardsByPageIdQueryHandler
        : IRequestHandler<GetAllGoalCardsByPageIdQuery, BaseResponse<List<GoalCardListVM>>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IAsyncRepository<PageCard> _pageCardRepository;
        private readonly IMapper _mapper;

        public GetAllGoalCardsByPageIdQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository, IAsyncRepository<PageCard> pageCardRepository, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _pageCardRepository = pageCardRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<GoalCardListVM>>> Handle(GetAllGoalCardsByPageIdQuery request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);
            if (page == null)
            {
                string msg = request.lang == "en"
                             ? "Page Not found"
                             : "الصفحة غير موجودة";

                return new BaseResponse<List<GoalCardListVM>>(msg, false, 404);
            }

            var Cards = _pageCardRepository
                .Where(c => c.PageId == page.Id)
                .Where(c => !c.IsHide)
                .ToList()
                .OrderBy(c => c.orderId);

            var data = _mapper.Map<List<GoalCardListVM>>(Cards);

            foreach (var card in data)
            {
                card.Content = request.lang == "en" ? card.EnglishContent : card.ArabicContent;
            }

            return new BaseResponse<List<GoalCardListVM>>("", true, 200, data);
        }
    }
}
