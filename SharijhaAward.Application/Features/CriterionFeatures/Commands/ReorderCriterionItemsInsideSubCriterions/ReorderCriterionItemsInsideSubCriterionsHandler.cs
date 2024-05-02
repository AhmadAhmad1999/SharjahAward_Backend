using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.ReorderCriterionItemsInsideSubCriterions
{
    public class ReorderCriterionItemsInsideSubCriterionsHandler
        : IRequestHandler<ReorderCriterionItemsInsideSubCriterionsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;

        public ReorderCriterionItemsInsideSubCriterionsHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository)
        {
            _CriterionRepository = CriterionRepository;
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
                    List<CriterionItem> AllCriterionItems = await _CriterionItemRepository
                        .Include(x => x.Criterion!)
                        .Where(x => Request.MainCriterionsDtos.Select(y => y.MainCriterionId)
                            .Any(y => y == x.CriterionId || y == x.Criterion!.ParentId))
                        .ToListAsync();

                    List<Criterion> AllCriterions = AllCriterionItems
                        .Select(x => x.Criterion!)
                        .Distinct()
                        .ToList();

                    foreach (MainCriterionsDto MainCriterionsDto in Request.MainCriterionsDtos)
                    {
                        Criterion? MainCriterionEntity = AllCriterions
                            .FirstOrDefault(x => x.Id == MainCriterionsDto.MainCriterionId);

                        if (MainCriterionEntity is not null)
                        {
                            MainCriterionEntity.OrderId = MainCriterionsDto.OrderId;

                            await _CriterionRepository.UpdateAsync(MainCriterionEntity);

                            foreach (SubCriterionDto SubCriterionDto in MainCriterionsDto.SubCriterionDtos)
                            {
                                Criterion? SubCriterionEntity = AllCriterions
                                    .FirstOrDefault(x => x.Id == SubCriterionDto.SubCriterionId);

                                if (SubCriterionEntity is not null)
                                {
                                    SubCriterionEntity.OrderId = SubCriterionDto.OrderId;

                                    await _CriterionRepository.UpdateAsync(SubCriterionEntity);

                                    foreach (CriterionItemDto CriterionItemDtos in SubCriterionDto.CriterionItemDtos)
                                    {
                                        CriterionItem? CriterionItemEntity = AllCriterionItems
                                            .FirstOrDefault(x => x.Id == CriterionItemDtos.CriterionItemId);

                                        if (CriterionItemEntity is not null)
                                        {
                                            CriterionItemEntity.OrderId = CriterionItemDtos.OrderId;

                                            await _CriterionItemRepository.UpdateAsync(CriterionItemEntity);
                                        }
                                    }
                                }
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
