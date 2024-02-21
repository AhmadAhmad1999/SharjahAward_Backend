using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

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
            DynamicAttributeSection? DynamicAttributeSectionToDelete = await _DynamicAttributeSectionRepository.GetByIdAsync(Request.Id);
            
            if (DynamicAttributeSectionToDelete == null)
                throw new OpenQA.Selenium.NotFoundException("Section Not Found");


            await _DynamicAttributeSectionRepository.DeleteAsync(DynamicAttributeSectionToDelete);

            return Unit.Value;
        }
    }
}
