using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.DeleteAdvancedFormBuilderSection
{
    public class DeleteAdvancedFormBuilderSectionHandler : IRequestHandler<DeleteAdvancedFormBuilderSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        public DeleteAdvancedFormBuilderSectionHandler(IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository)
        {
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteAdvancedFormBuilderSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilderSection? AdvancedFormBuilderSectionToDelete = await _AdvancedFormBuilderSectionRepository
                .GetByIdAsync(Request.Id);
            if (AdvancedFormBuilderSectionToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section Not Found"
                    : "هذا القسم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }
            using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                IQueryable<AdvancedFormBuilder> AdvancedFormBuildersInsideSection = _AdvancedFormBuilderRepository
                    .Where(x => x.AdvancedFormBuilderSectionId == Request.Id);

                await _AdvancedFormBuilderRepository.DeleteListAsync(AdvancedFormBuildersInsideSection);
                await _AdvancedFormBuilderSectionRepository.DeleteAsync(AdvancedFormBuilderSectionToDelete);

                Transaction.Complete();

                ResponseMessage = Request.lang == "en"
                    ? "Section has been Deleted successfully"
                    : "تم حذف القسم بنجاح";

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }
        }
    }
}
