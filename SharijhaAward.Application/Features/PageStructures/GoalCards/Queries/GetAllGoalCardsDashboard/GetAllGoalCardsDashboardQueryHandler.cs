using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsDashboard;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsDashboard
{
    public class GetAllGoalCardsDashboardQueryHandler
        : IRequestHandler<GetAllGoalCardsDashboardQuery, BaseResponse<List<GoalCardListVM>>>
    {
        private readonly IAsyncRepository<PageCard> _GoalCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public GetAllGoalCardsDashboardQueryHandler(IAsyncRepository<PageCard> GoalCardRepository, IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _GoalCardRepository = GoalCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<GoalCardListVM>>> Handle(GetAllGoalCardsDashboardQuery request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);
            if (page == null)
            {
                string msg = request.lang == "en"
                             ? "Page Not found"
                             : "الصفحة غير موجودة";

                return new BaseResponse<List<GoalCardListVM>>(msg, false, 404);
            }

            var Cards = _GoalCardRepository
                .Where(c => c.PageId == page.Id)
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
