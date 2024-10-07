using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.DeleteEducationalEntity
{
    public class DeleteEducationalEntityHandler : IRequestHandler<DeleteEducationalEntityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        public DeleteEducationalEntityHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteEducationalEntityCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalEntity? EducationalEntityToDelete = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational entity is not found"
                    : "الجهة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<DynamicAttributeListValue> DynamicAttributeListValueEntititesToDelete = await _DynamicAttributeListValueRepository
                .Where(x => x.ArabicValue == EducationalEntityToDelete.ArabicName &&
                    x.EnglishValue == EducationalEntityToDelete.EnglishName)
                .ToListAsync();

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
                    await _EducationalEntityRepository.DeleteAsync(EducationalEntityToDelete);
                    await _DynamicAttributeListValueRepository.DeleteListAsync(DynamicAttributeListValueEntititesToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Educational entity has been deleted successfully"
                        : "تم حذف الجهة التعليمية بنجاح";

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
