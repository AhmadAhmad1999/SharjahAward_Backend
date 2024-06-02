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
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;

        public ReorderDynamicAttributesInsideTheSectionsHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
        }

        public async Task<BaseResponse<object>> Handle(ReorderDynamicAttributesInsideTheSectionsCommand Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<DynamicAttribute> AllDynamicAttributeEntities = await _DynamicAttributeRepository
                .Where(x => Request.DynamicAttributeSectionsDto.Select(y => y.SectionId)
                    .Any(y => y == x.DynamicAttributeSectionId))
                .Include(x => x.DynamicAttributeSection!)
                .ToListAsync();

            List<DynamicAttributeSection> AllDynamicAttributeSectionsEntities = AllDynamicAttributeEntities
                .Select(x => x.DynamicAttributeSection!)
                .Distinct()
                .ToList();

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
                        DynamicAttributeSection? DynamicAttributeSectionEntity = AllDynamicAttributeSectionsEntities
                            .FirstOrDefault(x => x.Id == DynamicAttributeSectionsDto.SectionId);

                        if (DynamicAttributeSectionEntity is not null)
                        {
                            if (DynamicAttributeSectionEntity.OrderId != DynamicAttributeSectionsDto.OrderId)
                            {
                                DynamicAttributeSectionEntity.OrderId = DynamicAttributeSectionsDto.OrderId;

                                await _DynamicAttributeSectionRepository.UpdateAsync(DynamicAttributeSectionEntity);
                            }

                            foreach (DynamicAttributesDto DynamicAttributesDto in DynamicAttributeSectionsDto.DynamicAttributesDtos)
                            {
                                DynamicAttribute? DynamicAttributeEntity = AllDynamicAttributeEntities
                                    .FirstOrDefault(x => x.Id == DynamicAttributesDto.DynamicAttributeId);
                                
                                if (DynamicAttributeEntity is not null)
                                {
                                    if (DynamicAttributeEntity.OrderId != DynamicAttributesDto.OrderId &&
                                        DynamicAttributeEntity.DynamicAttributeSectionId != DynamicAttributeSectionsDto.SectionId)
                                    {
                                        DynamicAttributeEntity.OrderId = DynamicAttributesDto.OrderId;
                                        DynamicAttributeEntity.DynamicAttributeSectionId = DynamicAttributeSectionsDto.SectionId;

                                        await _DynamicAttributeRepository.UpdateAsync(DynamicAttributeEntity);
                                    }
                                    else if (DynamicAttributeEntity.OrderId != DynamicAttributesDto.OrderId)
                                    {
                                        DynamicAttributeEntity.OrderId = DynamicAttributesDto.OrderId;

                                        await _DynamicAttributeRepository.UpdateAsync(DynamicAttributeEntity);
                                    }
                                    else if (DynamicAttributeEntity.DynamicAttributeSectionId != DynamicAttributeSectionsDto.SectionId)
                                    {
                                        DynamicAttributeEntity.DynamicAttributeSectionId = DynamicAttributeSectionsDto.SectionId;

                                        await _DynamicAttributeRepository.UpdateAsync(DynamicAttributeEntity);
                                    }
                                }
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
