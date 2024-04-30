using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.ReorderDynamicAttributesInsideTheSections
{
    public class ReorderDynamicAttributesInsideTheSectionsHandler 
        : IRequestHandler<ReorderDynamicAttributesInsideTheSectionsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;

        public ReorderDynamicAttributesInsideTheSectionsHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }

        public async Task<BaseResponse<object>> Handle(ReorderDynamicAttributesInsideTheSectionsCommand Request, 
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
                    foreach (DynamicAttributeSectionsDto DynamicAttributeSectionsDto in Request.DynamicAttributeSectionsDto)
                    {
                        List<DynamicAttribute> DynamicAttributesInsideSection = await _DynamicAttributeRepository
                            .Where(x => DynamicAttributeSectionsDto.DynamicAttributesIds.Any(y => y == x.Id))
                            .ToListAsync();

                        foreach (DynamicAttribute DynamicAttribute in DynamicAttributesInsideSection)
                        {
                            if (DynamicAttribute.DynamicAttributeSectionId != DynamicAttributeSectionsDto.SectionId)
                            {
                                DynamicAttribute.DynamicAttributeSectionId = DynamicAttributeSectionsDto.SectionId;
                                await _DynamicAttributeRepository.UpdateAsync(DynamicAttribute);
                            }
                        }
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Updated successfully"
                        : "تم تعديل ترتيب الحقول بنجاح";

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
