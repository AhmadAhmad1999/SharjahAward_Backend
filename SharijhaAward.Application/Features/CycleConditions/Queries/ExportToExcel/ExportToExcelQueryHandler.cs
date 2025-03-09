using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.ExportToExcel
{
    public class ExportToExcelQueryHandler
        : IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<CycleCondition> _CycleConditionRepository;
        private readonly IExcelHelper<CycleConditionExportDto> _CycleConditionExportDtoHelper;
        private readonly IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository;

        public ExportToExcelQueryHandler(IAsyncRepository<CycleCondition> _CycleConditionRepository,
            IExcelHelper<CycleConditionExportDto> _CycleConditionExportDtoHelper, 
            IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository)
        {
            this._CycleConditionRepository = _CycleConditionRepository;
            this._CycleConditionExportDtoHelper = _CycleConditionExportDtoHelper;
            this._CycleConditionAttachmentTypeRepository = _CycleConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportToExcelQuery request, CancellationToken cancellationToken)
        {
            IReadOnlyList<CycleCondition> CycleConditionEntities = await _CycleConditionRepository
                .ListAllAsync();

            List<CycleConditionAttachmentType> CycleConditionAttachmentTypeEntities = _CycleConditionAttachmentTypeRepository
                .Where(x => CycleConditionEntities.Select(y => y.Id).Contains(x.CycleConditionId) &&
                    x.AttachmentType != null)
                .ToList();

            List<CycleConditionExportDto> Response = CycleConditionEntities
                .Select(x => new CycleConditionExportDto()
                {
                    ArabicDescription = x.ArabicDescription,
                    AttachmentType = CycleConditionAttachmentTypeEntities
                        .Where(y => y.CycleConditionId == x.Id)
                        .Select(y => y.AttachmentType!.Value)
                        .ToList(),
                    Id = x.Id,
                    EnglishDescription = x.EnglishDescription,
                    NeedAttachment = x.NeedAttachment,
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB
                }).ToList();

            byte[]? ExportedFile = _CycleConditionExportDtoHelper.ExportToExcel(Response);

            return new BaseResponse<byte[]>(string.Empty, true, 200, ExportedFile);
        }
    }
}
