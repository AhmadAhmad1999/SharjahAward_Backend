using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute
{
    public class DeleteDynamicAttributeHandler : IRequestHandler<DeleteDynamicAttributeCommand, Unit>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        public DeleteDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<Unit> Handle(DeleteDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            DynamicAttribute? DynamicAttributeToDelete = await _DynamicAttributeRepository.GetByIdAsync(Request.Id);

            if (DynamicAttributeToDelete == null)
                throw new OpenQA.Selenium.NotFoundException(!string.IsNullOrEmpty(Request.lang)
                    ? (Request.lang.ToLower() == "en"
                        ? "Field not found."
                        : "هذا الحقل غير موجود.")
                    : "Field not found.");

            await _DynamicAttributeRepository.DeleteAsync(DynamicAttributeToDelete);

            return Unit.Value;
        }
    }
}
