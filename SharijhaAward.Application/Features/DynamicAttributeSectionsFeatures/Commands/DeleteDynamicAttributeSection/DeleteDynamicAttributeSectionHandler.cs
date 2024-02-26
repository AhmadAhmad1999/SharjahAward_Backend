using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection
{
    public class DeleteDynamicAttributeSectionHandler : IRequestHandler<DeleteDynamicAttributeSectionCommand, Unit>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        public DeleteDynamicAttributeSectionHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<Unit> Handle(DeleteDynamicAttributeSectionCommand Request, CancellationToken cancellationToken)
        {
            using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                DynamicAttributeSection? DynamicAttributeSectionToDelete = await _DynamicAttributeSectionRepository.GetByIdAsync(Request.Id);

                if (DynamicAttributeSectionToDelete == null)
                {
                    Transaction.Dispose();

                    throw new OpenQA.Selenium.NotFoundException(!string.IsNullOrEmpty(Request.lang)
                        ? (Request.lang.ToLower() == "en"
                            ? "Section Not Found."
                            : "هذا القسم غير موجود.")
                        : "Section Not Found.");
                }

                IQueryable<DynamicAttribute> DynamicAttributesInsideSection = _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSectionId == Request.Id);

                await _DynamicAttributeRepository.DeleteListAsync(DynamicAttributesInsideSection);
                await _DynamicAttributeSectionRepository.DeleteAsync(DynamicAttributeSectionToDelete);

                Transaction.Complete();
                return Unit.Value;
            }
        }
    }
}
