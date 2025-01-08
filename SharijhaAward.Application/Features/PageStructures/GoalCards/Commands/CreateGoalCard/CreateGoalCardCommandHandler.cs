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

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.CreateGoalCard
{
    public class CreateGoalCardCommandHandler
        : IRequestHandler<CreateGoalCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IAsyncRepository<PageCard> _pageCardRepository;
        private readonly IMapper _mapper;

        public CreateGoalCardCommandHandler(IAsyncRepository<PageStructure> pageStructureRepository, IAsyncRepository<PageCard> pageCardRepository, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _pageCardRepository = pageCardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateGoalCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                 ? "Goal Card has been Created"
                 : "تم إنشاء العنصر ";

            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);

            if (page == null)
            {
                msg = request.lang == "en"
                ? "Page Not found"
                : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var GoalCards = new List<PageCard>();

            foreach (var card in request.SubGoals)
            {
                var GoalCard = new PageCard()
                {
                    ArabicContent = card.ArabicContent,
                    orderId = card.orderId,
                    EnglishContent = card.EnglishContent,
                    IsHide = card.IsHide,
                    PageId = request.PageId,
                    CardType = card.CardType,
                };

                GoalCards.Add(GoalCard);
            }

            await _pageCardRepository.AddRangeAsync(GoalCards);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
