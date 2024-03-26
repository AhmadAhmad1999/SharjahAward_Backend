using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterionItem
{
    public class DeleteCriterionItemHandler : IRequestHandler<DeleteCriterionItemCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        public DeleteCriterionItemHandler(IAsyncRepository<CriterionItem> CriterionItemRepository)
        {
            _CriterionItemRepository = CriterionItemRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCriterionItemCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CriterionItem? CriterionItemEntity = await _CriterionItemRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CriterionItemEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion item is not found"
                    : "عنصر المعيار الفرعي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CriterionItemRepository.DeleteAsync(CriterionItemEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}