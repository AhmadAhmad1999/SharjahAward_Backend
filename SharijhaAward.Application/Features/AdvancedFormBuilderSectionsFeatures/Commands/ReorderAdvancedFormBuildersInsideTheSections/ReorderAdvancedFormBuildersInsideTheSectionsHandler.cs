using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.ReorderAdvancedFormBuildersInsideTheSections
{
    public class ReorderAdvancedFormBuildersInsideTheSectionsHandler
        : IRequestHandler<ReorderAdvancedFormBuildersInsideTheSectionsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;

        public ReorderAdvancedFormBuildersInsideTheSectionsHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
        }

        public async Task<BaseResponse<object>> Handle(ReorderAdvancedFormBuildersInsideTheSectionsCommand Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<AdvancedFormBuilder> AllAdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                .Where(x => Request.AdvancedFormBuilderSectionDto.Select(y => y.SectionId)
                    .Any(y => y == x.AdvancedFormBuilderSectionId))
                .ToListAsync();

            List<AdvancedFormBuilderSection> AllAdvancedFormBuilderSectionsEntities = AllAdvancedFormBuilderEntities
                .Select(x => x.AdvancedFormBuilderSection!)
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
                    foreach (AdvancedFormBuilderSectionDto AdvancedFormBuilderSectionsDto in Request.AdvancedFormBuilderSectionDto)
                    {
                        AdvancedFormBuilderSection? AdvancedFormBuilderSectionEntity = AllAdvancedFormBuilderSectionsEntities
                            .FirstOrDefault(x => x.Id == AdvancedFormBuilderSectionsDto.SectionId);

                        if (AdvancedFormBuilderSectionEntity is not null)
                        {
                            if (AdvancedFormBuilderSectionEntity.OrderId != AdvancedFormBuilderSectionsDto.OrderId)
                            {
                                AdvancedFormBuilderSectionEntity.OrderId = AdvancedFormBuilderSectionsDto.OrderId;

                                await _AdvancedFormBuilderSectionRepository.UpdateAsync(AdvancedFormBuilderSectionEntity);
                            }

                            foreach (AdvancedFormBuilderDto AdvancedFormBuildersDto in AdvancedFormBuilderSectionsDto.AdvancedFormBuilderDtos)
                            {
                                AdvancedFormBuilder? AdvancedFormBuilderEntity = AllAdvancedFormBuilderEntities
                                    .FirstOrDefault(x => x.Id == AdvancedFormBuildersDto.AdvancedFormBuilderId);

                                if (AdvancedFormBuilderEntity is not null)
                                {
                                    if (AdvancedFormBuilderEntity.OrderId != AdvancedFormBuildersDto.OrderId &&
                                        AdvancedFormBuilderEntity.AdvancedFormBuilderSectionId != AdvancedFormBuilderSectionsDto.SectionId)
                                    {
                                        AdvancedFormBuilderEntity.OrderId = AdvancedFormBuildersDto.OrderId;
                                        AdvancedFormBuilderEntity.AdvancedFormBuilderSectionId = AdvancedFormBuilderSectionsDto.SectionId;

                                        await _AdvancedFormBuilderRepository.UpdateAsync(AdvancedFormBuilderEntity);
                                    }
                                    else if (AdvancedFormBuilderEntity.OrderId != AdvancedFormBuildersDto.OrderId)
                                    {
                                        AdvancedFormBuilderEntity.OrderId = AdvancedFormBuildersDto.OrderId;
                                        
                                        await _AdvancedFormBuilderRepository.UpdateAsync(AdvancedFormBuilderEntity);
                                    }
                                    else if (AdvancedFormBuilderEntity.AdvancedFormBuilderSectionId != AdvancedFormBuilderSectionsDto.SectionId)
                                    {
                                        AdvancedFormBuilderEntity.AdvancedFormBuilderSectionId = AdvancedFormBuilderSectionsDto.SectionId;

                                        await _AdvancedFormBuilderRepository.UpdateAsync(AdvancedFormBuilderEntity);
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
