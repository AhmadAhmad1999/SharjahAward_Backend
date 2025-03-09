using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.ExportToExcel
{
    public class ExportToExcelQueryHandler
        : IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IExcelHelper<TermExportDto> _TermExportDtoHelper;
        private readonly IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository;

        public ExportToExcelQueryHandler(IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IExcelHelper<TermExportDto> _TermExportDtoHelper,
            IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository)
        {
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._TermExportDtoHelper = _TermExportDtoHelper;
            this._TermAndConditionAttachmentTypeRepository = _TermAndConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportToExcelQuery request, CancellationToken cancellationToken)
        {
            IReadOnlyList<TermAndCondition> TermAndConditionEntities = await _TermAndConditionRepository
                .ListAllAsync();

            List<TermAndConditionAttachmentType> TermAndConditionAttachmentTypeEntities = _TermAndConditionAttachmentTypeRepository
                .Where(x => TermAndConditionEntities.Select(y => y.Id).Contains(x.TermAndConditionId) &&
                    x.AttachmentType != null)
                .ToList();

            List<TermExportDto> Response = TermAndConditionEntities
                .Select(x => new TermExportDto()
                {
                    Id = x.Id,
                    ArabicDescription = x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    IsSpecial = true,
                    NeedAttachment = x.NeedAttachment,
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                    Type = TermAndConditionAttachmentTypeEntities
                        .Where(y => y.TermAndConditionId == x.Id)
                        .Select(y => y.AttachmentType!.Value)
                        .ToList()
                }).ToList();

            byte[]? ExportedFile = _TermExportDtoHelper.ExportToExcel(Response);

            return new BaseResponse<byte[]>(string.Empty, true, 200, ExportedFile);
        }
    }
}
