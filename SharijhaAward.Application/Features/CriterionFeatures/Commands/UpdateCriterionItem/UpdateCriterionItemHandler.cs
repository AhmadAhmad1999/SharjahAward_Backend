using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.UpdateCriterionItem
{
    public class UpdateCriterionItemHandler : IRequestHandler<UpdateCriterionItemCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IMapper _Mapper;
        public UpdateCriterionItemHandler(IMapper Mapper,
            IAsyncRepository<CriterionItem> CriterionItemRepository)
        {
            _CriterionItemRepository = CriterionItemRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCriterionItemCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CriterionItem? CriterionItemEntityToUpdate = await _CriterionItemRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CriterionItemEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion item is not found"
                    : "عنصر المعيار الفرعي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, CriterionItemEntityToUpdate, typeof(UpdateCriterionItemCommand), typeof(CriterionItem));

            await _CriterionItemRepository.UpdateAsync(CriterionItemEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Criterion item has been updated successfully"
                : "تم تعديل عنصر المعيار الفرعي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
