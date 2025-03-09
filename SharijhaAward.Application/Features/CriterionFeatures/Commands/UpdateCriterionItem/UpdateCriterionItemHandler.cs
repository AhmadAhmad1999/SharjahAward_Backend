using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.UpdateCriterionItem
{
    public class UpdateCriterionItemHandler : IRequestHandler<UpdateCriterionItemCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository;
        public UpdateCriterionItemHandler(IMapper _Mapper,
            IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository)
        {
            this._Mapper = _Mapper;
            this._CriterionItemRepository = _CriterionItemRepository;
            this._CriterionItemAttachmentTypeRepository = _CriterionItemAttachmentTypeRepository;
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

            int OldTotalScoreForSubCategory = _CriterionItemRepository
                .Where(x => x.CriterionId == CriterionItemEntityToUpdate.CriterionId && x.Id != Request.Id)
                .Select(x => x.Score).Sum();

            if (OldTotalScoreForSubCategory + Request.Score > CriterionItemEntityToUpdate.Criterion!.Score)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"The maximum score of this sub criterion : {CriterionItemEntityToUpdate.Criterion!.EnglishTitle} cannot be exceeded"
                    : $"لا يمكن تجاوز العلامة العظمى للمعيار الفرعي: {CriterionItemEntityToUpdate.Criterion!.ArabicTitle}";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            _Mapper.Map(Request, CriterionItemEntityToUpdate, typeof(UpdateCriterionItemCommand), typeof(CriterionItem));

            List<CriterionItemAttachmentType> CriterionItemAttachmentTypeEntitiesToDelete = _CriterionItemAttachmentTypeRepository
                .Where(x => x.CriterionItemId == Request.Id)
                .ToList();

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromSeconds(30)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _CriterionItemRepository.UpdateAsync(CriterionItemEntityToUpdate);

                    await _CriterionItemAttachmentTypeRepository.DeleteListAsync(CriterionItemAttachmentTypeEntitiesToDelete);

                    List<CriterionItemAttachmentType> NewCriterionAttachmentTypeEntities = Request.AttachmentType
                        .Select(x => new CriterionItemAttachmentType()
                        {
                            CriterionItemId = Request.Id,
                            AttachmentType = x
                        }).ToList();

                    await _CriterionItemAttachmentTypeRepository.AddRangeAsync(NewCriterionAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Criterion item has been updated successfully"
                        : "تم تعديل عنصر المعيار الفرعي بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
