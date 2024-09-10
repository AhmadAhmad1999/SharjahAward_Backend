using MediatR;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.DeleteGoalCard
{
    public class DeleteGoalCardCommandHandler
        : IRequestHandler<DeleteGoalCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PageCard> _pageCardRepository;

        public DeleteGoalCardCommandHandler(IAsyncRepository<PageCard> pageCardRepository)
        {
            _pageCardRepository = pageCardRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteGoalCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
            ? "Dark Card has been Deleted"
            : "تم حذف العنصر ";

            var goalCard = await _pageCardRepository.GetByIdAsync(request.Id);

            if (goalCard == null)
            {
                msg = request.lang == "en"
                       ? "Dark Card Not Found"
                       : "العنصر غير وجود ";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _pageCardRepository.DeleteAsync(goalCard);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
