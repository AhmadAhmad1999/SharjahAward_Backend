using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.ReorderCriterionItemsInsideSubCriterions
{
    public class ReorderCriterionItemsInsideSubCriterionsHandler
        : IRequestHandler<ReorderCriterionItemsInsideSubCriterionsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;

        public ReorderCriterionItemsInsideSubCriterionsHandler(IAsyncRepository<CriterionItem> CriterionItemRepository)
        {
            _CriterionItemRepository = CriterionItemRepository;
        }
        public async Task<BaseResponse<object>> Handle(ReorderCriterionItemsInsideSubCriterionsCommand Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    foreach (SubCriterionItemsDto SubCriterionItemsDto in Request.SubCriterionItemsDto)
                    {
                        List<CriterionItem> CriterionItemInsideSubCriterion = await _CriterionItemRepository
                            .Where(x => SubCriterionItemsDto.CriterionItemsIds.Any(y => y == x.Id))
                            .ToListAsync();

                        foreach (CriterionItem CriterionItem in CriterionItemInsideSubCriterion)
                        {
                            if (CriterionItem.CriterionId != SubCriterionItemsDto.SubCriterionId)
                            {
                                CriterionItem.CriterionId = SubCriterionItemsDto.SubCriterionId;
                                await _CriterionItemRepository.UpdateAsync(CriterionItem);
                            }
                        }
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Updated successfully"
                        : "تم تعديل ترتيب عناصر المعايير بنجاح";

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
