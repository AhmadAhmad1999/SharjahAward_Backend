using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.ExportToExcel
{
    public class FilesExportToExcelHandler 
        : IRequestHandler<FilesExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IExcelHelper<FilesExportToExcelListVM> _ExcelHelper;

        public FilesExportToExcelHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IExcelHelper<FilesExportToExcelListVM> ExcelHelper)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
            _ExcelHelper = ExcelHelper;
        }
        public async Task<BaseResponse<byte[]>>
            Handle(FilesExportToExcelQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.FilterId == (int)FilesFilter.Criterion)
            {
                List<FilesExportToExcelListVM> FilesFromCriterionAttachmentes = await _CriterionAttachmentRepository
                    .OrderByDescending(x => x.Id, 0, -1)
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.AttachementPath)
                    }).ToListAsync();

                byte[] Data = _ExcelHelper.ExportToExcel(FilesFromCriterionAttachmentes);

                return new BaseResponse<byte[]>(ResponseMessage, true, 200, Data);
            }
            else if (Request.FilterId == (int)FilesFilter.CriterionItem)
            {
                List<FilesExportToExcelListVM> FilesFromCriterionItemAttachmentes = await _CriterionItemAttachmentRepository
                    .OrderByDescending(x => x.Id, 0, -1)
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.AttachementPath)
                    }).ToListAsync();

                byte[] Data = _ExcelHelper.ExportToExcel(FilesFromCriterionItemAttachmentes);

                return new BaseResponse<byte[]>(ResponseMessage, true, 200, Data);
            }
            else if (Request.FilterId == (int)FilesFilter.SpecialCondition)
            {
                List<FilesExportToExcelListVM> FilesFromSpecialConditions = await _ConditionAttachmentRepository
                    .OrderByDescending(x => x.Id, 0, -1)
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.AttachementPath)
                    }).ToListAsync();

                byte[] Data = _ExcelHelper.ExportToExcel(FilesFromSpecialConditions);

                return new BaseResponse<byte[]>(ResponseMessage, true, 200, Data);
            }
            else if (Request.FilterId == (int)FilesFilter.GeneralCondition)
            {
                List<FilesExportToExcelListVM> FilesFromGeneralConditions = await _CycleConditionAttachmentRepository
                    .OrderByDescending(x => x.Id, 0, -1)
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.AttachementPath)
                    }).ToListAsync();

                byte[] Data = _ExcelHelper.ExportToExcel(FilesFromGeneralConditions);

                return new BaseResponse<byte[]>(ResponseMessage, true, 200, Data);
            }
            else if (Request.FilterId == (int)FilesFilter.SubscriberPersonalAndAcademicInformation)
            {
                List<FilesExportToExcelListVM> FilesValues1 = await _DynamicAttributeTableValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        RowId = x.RowId,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<FilesExportToExcelListVM> FilesValues2 = await _DynamicAttributeValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        RowId = null,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<FilesExportToExcelListVM> FilesValues = FilesValues1.Union(FilesValues2)
                    .OrderByDescending(x => x.Id)
                    .ToList();

                byte[] Data = _ExcelHelper.ExportToExcel(FilesValues);

                return new BaseResponse<byte[]>(ResponseMessage, true, 200, Data);
            }
            else if (Request.FilterId == (int)FilesFilter.CoordinatorFiles)
            {
                List<FilesExportToExcelListVM> FirstFilesValues = await _DynamicAttributeTableValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        RowId = x.RowId,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<FilesExportToExcelListVM> SecondFilesValues = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<FilesExportToExcelListVM> FilesValues = FirstFilesValues
                    .Union(SecondFilesValues)
                    .OrderByDescending(x => x.Id)
                    .ToList();

                byte[] Data = _ExcelHelper.ExportToExcel(FilesValues);

                return new BaseResponse<byte[]>(ResponseMessage, true, 200, Data);
            }
            else if (Request.FilterId == (int)FilesFilter.ArbitratorFiles)
            {
                List<FilesExportToExcelListVM> FirstFilesValues = await _DynamicAttributeTableValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        RowId = x.RowId,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<FilesExportToExcelListVM> SecondFilesValues = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2 &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new FilesExportToExcelListVM()
                    {
                        Id = x.Id,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<FilesExportToExcelListVM> FilesValues = FirstFilesValues
                    .Union(SecondFilesValues)
                    .OrderByDescending(x => x.Id)
                    .ToList();

                byte[] Data = _ExcelHelper.ExportToExcel(FilesValues);

                return new BaseResponse<byte[]>(ResponseMessage, true, 200, Data);
            }

            throw new NotImplementedException();
        }
    }
}
