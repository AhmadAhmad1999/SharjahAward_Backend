using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Commands.DeleteTextCard
{
    public class DeleteTextCardCommandHandler
        : IRequestHandler<DeleteTextCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PageCard> _textCardRepository;

        public DeleteTextCardCommandHandler(IAsyncRepository<PageCard> textCardRepository)
        {
            _textCardRepository = textCardRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteTextCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Text Card has been Deleted"
                : "تم حذف بطاقة النص";

            var textCard = await _textCardRepository.GetByIdAsync(request.Id);

            if (textCard == null)
            {
                msg = request.lang == "en"
                ? "Text Card not Found"
                : " بطاقة النص غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _textCardRepository.DeleteAsync(textCard);

            return new BaseResponse<object>(msg, true, 200);
                 
        }
    }
}
