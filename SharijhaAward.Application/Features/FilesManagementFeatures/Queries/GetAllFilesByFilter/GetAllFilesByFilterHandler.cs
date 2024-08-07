using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter
{
    public class GetAllFilesByFilterHandler : IRequestHandler<GetAllFilesByFilterQuery, BaseResponse<List<GetAllFilesByFilterListVM>>>
    {
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public GetAllFilesByFilterHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
        }
        public async Task<BaseResponse<List<GetAllFilesByFilterListVM>>> 
            Handle(GetAllFilesByFilterQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.FilterId == (int)FilesFilter.Criterion)
            {
                int TotalCount = await _CriterionAttachmentRepository.GetCountAsync(null);

                List<GetAllFilesByFilterListVM> FilesFromCriterionAttachmentes = await _CriterionAttachmentRepository
                    .OrderByDescending(x => x.Id, Request.page, Request.perPage)
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024),
                        FileType = Path.GetExtension(x.AttachementPath)
                    }).ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionAttachmentes, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.CriterionItem)
            {
                int TotalCount = await _CriterionItemAttachmentRepository.GetCountAsync(null);

                List<GetAllFilesByFilterListVM> FilesFromCriterionItemAttachmentes = await _CriterionItemAttachmentRepository
                    .OrderByDescending(x => x.Id, Request.page, Request.perPage)
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024),
                        FileType = Path.GetExtension(x.AttachementPath)
                    }).ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionItemAttachmentes, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.SpecialCondition)
            {
                int TotalCount = await _ConditionAttachmentRepository.GetCountAsync(null);

                List<GetAllFilesByFilterListVM> FilesFromSpecialConditions = await _ConditionAttachmentRepository
                    .OrderByDescending(x => x.Id, Request.page, Request.perPage)
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024),
                        FileType = Path.GetExtension(x.AttachementPath)
                    }).ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromSpecialConditions, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.GeneralCondition)
            {
                int TotalCount = await _CycleConditionAttachmentRepository.GetCountAsync(null);

                List<GetAllFilesByFilterListVM> FilesFromGeneralConditions = await _CycleConditionAttachmentRepository
                    .OrderByDescending(x => x.Id, Request.page, Request.perPage)
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024),
                        FileType = Path.GetExtension(x.AttachementPath)
                    }).ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromGeneralConditions, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.SubscriberPersonalAndAcademicInformation)
            {
                int TotalCount1 = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .CountAsync(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) && 
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4));

                int TotalCount2 = await _DynamicAttributeTableValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .CountAsync(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4));

                int TotalCount = TotalCount1 + TotalCount2;

                List<GetAllFilesByFilterListVM> FilesValues = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        RowId = null,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    })
                    .Union(await _DynamicAttributeTableValueRepository
                        .Include(x => x.DynamicAttribute!)
                        .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                        .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                            x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                            ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                        .Select(x => new GetAllFilesByFilterListVM()
                        {
                            Id = x.Id,
                            RowId = x.RowId,
                            Description = null,
                            FileName = new FileInfo(x.Value).Name,
                            FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                            UploadedAt = x.CreatedAt,
                            FileType = Path.GetExtension(x.Value)
                        }).ToListAsync())
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : 0)
                    .Take((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : TotalCount)
                    .ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesValues, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.CoordinatorFiles)
            {
                int TotalCount1 = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .CountAsync(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4));

                int TotalCount2 = await _DynamicAttributeTableValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .CountAsync(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4));

                int TotalCount = TotalCount1 + TotalCount2;

                List<GetAllFilesByFilterListVM> FirstFilesValues = await _DynamicAttributeTableValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        RowId = x.RowId,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<GetAllFilesByFilterListVM> SecondFilesValues = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<GetAllFilesByFilterListVM> FilesValues = FirstFilesValues
                    .Union(SecondFilesValues)
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : 0)
                    .Take((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : TotalCount)
                    .ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesValues, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.ArbitratorFiles)
            {
                int TotalCount1 = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .CountAsync(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2 &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4));

                int TotalCount2 = await _DynamicAttributeTableValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .CountAsync(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4));

                int TotalCount = TotalCount1 + TotalCount2;

                List<GetAllFilesByFilterListVM> FirstFilesValues = await _DynamicAttributeTableValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        RowId = x.RowId,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<GetAllFilesByFilterListVM> SecondFilesValues = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2 &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                        UploadedAt = x.CreatedAt,
                        FileType = Path.GetExtension(x.Value)
                    }).ToListAsync();

                List<GetAllFilesByFilterListVM> FilesValues = FirstFilesValues
                    .Union(SecondFilesValues)
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : 0)
                    .Take((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : TotalCount)
                    .ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesValues, PaginationParameter);
            }

            throw new NotImplementedException();
        }
    }
}
