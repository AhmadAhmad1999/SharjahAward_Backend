using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.DeleteDarkCard
{
    public class DeleteDarkCardCommandHandler
        : IRequestHandler<DeleteDarkCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DarkCard> _darkCardRepository;

        public DeleteDarkCardCommandHandler(IAsyncRepository<DarkCard> darkCardRepository)
        {
            _darkCardRepository = darkCardRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteDarkCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                       ? "Dark Card has been Deleted"
                       : "تم حذف العنصر ";

            var darkCard = await _darkCardRepository.GetByIdAsync(request.Id);

            if(darkCard == null)
            {
                msg = request.lang == "en"
                       ? "Dark Card Not Found"
                       : "العنصر غير وجود ";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _darkCardRepository.DeleteAsync(darkCard);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
