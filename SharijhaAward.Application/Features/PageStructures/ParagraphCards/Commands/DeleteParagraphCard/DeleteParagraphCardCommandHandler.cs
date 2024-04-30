using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.DeleteParagraphCard
{
    public class DeleteParagraphCardCommandHandler
        : IRequestHandler<DeleteParagraphCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ParagraphCard> _paragraphCardRepository;

        public DeleteParagraphCardCommandHandler(IAsyncRepository<ParagraphCard> paragraphCardRepository)
        {
            _paragraphCardRepository = paragraphCardRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteParagraphCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                       ? "Dark Card has been Deleted"
                       : "تم حذف العنصر ";

            var ParagraphCard = await _paragraphCardRepository.GetByIdAsync(request.Id);

            if (ParagraphCard == null)
            {
                msg = request.lang == "en"
                       ? "Dark Card Not Found"
                       : "العنصر غير وجود ";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _paragraphCardRepository.DeleteAsync(ParagraphCard);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
