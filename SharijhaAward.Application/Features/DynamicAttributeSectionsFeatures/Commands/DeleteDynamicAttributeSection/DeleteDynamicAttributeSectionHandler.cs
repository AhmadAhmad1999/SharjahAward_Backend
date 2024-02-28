using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection
{
    public class DeleteDynamicAttributeSectionHandler : IRequestHandler<DeleteDynamicAttributeSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        public DeleteDynamicAttributeSectionHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteDynamicAttributeSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttributeSection? DynamicAttributeSectionToDelete = await _DynamicAttributeSectionRepository
                .GetByIdAsync(Request.Id);
            if (DynamicAttributeSectionToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section Not Found"
                    : "هذا القسم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }
            using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                IQueryable<DynamicAttribute> DynamicAttributesInsideSection = _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSectionId == Request.Id);

                await _DynamicAttributeRepository.DeleteListAsync(DynamicAttributesInsideSection);
                await _DynamicAttributeSectionRepository.DeleteAsync(DynamicAttributeSectionToDelete);

                Transaction.Complete();

                ResponseMessage = Request.lang == "en"
                    ? "Section has been Deleted successfully"
                    : "تم حذف القسم بنجاح";

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }
        }
    }
}
