using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetDarkCardById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetGoalCardById
{
    public class GetGoalCardByIdQueryHandler
        : IRequestHandler<GetGoalCardByIdQuery, BaseResponse<GoalCardDto>>
    {
        private readonly IAsyncRepository<PageCard> _pageCardRepository;
        private readonly IMapper _mapper;

        public GetGoalCardByIdQueryHandler(IAsyncRepository<PageCard> pageCardRepository, IMapper mapper)
        {
            _pageCardRepository = pageCardRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<GoalCardDto>> Handle(GetGoalCardByIdQuery request, CancellationToken cancellationToken)
        {
            var GoalCard = await _pageCardRepository.GetByIdAsync(request.Id);
            if (GoalCard == null)
            {
                string msg = request.lang == "en"
                       ? "Dark Card Not Found"
                       : "العنصر غير وجود ";

                return new BaseResponse<GoalCardDto>(msg, false, 404);
            }

            var data = _mapper.Map<GoalCardDto>(GoalCard);

            data.Content = request.lang == "en" ? data.EnglishContent : data.ArabicContent;

            return new BaseResponse<GoalCardDto>("", true, 200, data);
        }
    }
}
