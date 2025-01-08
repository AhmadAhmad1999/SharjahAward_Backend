using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
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
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;

        public GetAllFilesByFilterHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<Coordinator> _CoordinatorRepository,
            IAsyncRepository<Arbitrator> _ArbitratorRepository)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
            this._CoordinatorRepository = _CoordinatorRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
        }
        public async Task<BaseResponse<List<GetAllFilesByFilterListVM>>> 
            Handle(GetAllFilesByFilterQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.FilterId == (int)FilesFilter.Criterion)
            {
                int TotalCount = await _CriterionAttachmentRepository.GetCountAsync(null);
                
                List<CriterionAttachment> CriterionAttachmentEntities = new List<CriterionAttachment>();

                if (Request.FormId is null &&
                    Request.SubscriberId is null &&
                    Request.CycleId is null &&
                    Request.CategoryId is null)
                {
                    CriterionAttachmentEntities = await _CriterionAttachmentRepository
                        .OrderByDescending(x => x.Id, Request.page, Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    if (Request.page != 0 && Request.perPage != -1)
                    {
                        CriterionAttachmentEntities = await _CriterionAttachmentRepository
                            .Where(x => (Request.FormId != null ? x.ProvidedFormId == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.ProvidedForm!.User!.SubscriberId)
                                        ? x.ProvidedForm!.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null 
                                    ? x.ProvidedForm!.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.ProvidedForm!.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();
                    }
                    else
                    {
                        CriterionAttachmentEntities = await _CriterionAttachmentRepository
                            .Where(x => (Request.FormId != null ? x.ProvidedFormId == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.ProvidedForm!.User!.SubscriberId)
                                        ? x.ProvidedForm!.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.ProvidedForm!.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.ProvidedForm!.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .ToListAsync();
                    }
                }

                foreach (CriterionAttachment CriterionAttachmentEntity in CriterionAttachmentEntities)
                {
                    List<string> FilePath = CriterionAttachmentEntity.AttachementPath.Split("wwwroot").ToList();

                    CriterionAttachmentEntity.AttachementPath = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> FilesFromCriterionAttachmentes = CriterionAttachmentEntities
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024),
                        FileType = Path.GetExtension(x.AttachementPath),
                        CategoryName = Request.lang == "en"
                            ? x.Criterion!.Category!.EnglishName
                            : x.Criterion!.Category!.ArabicName,
                        CycleNumber = x.Criterion!.Category!.Cycle!.CycleNumber,
                        FormId = x.ProvidedFormId,
                        SubscriberId = x.ProvidedForm!.User!.SubscriberId,
                        UserId = x.ProvidedForm!.userId
                    }).ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionAttachmentes, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.CriterionItem)
            {
                int TotalCount = await _CriterionItemAttachmentRepository.GetCountAsync(null);

                List<CriterionItemAttachment> CriterionItemAttachmentEntities = new List<CriterionItemAttachment>();

                if (Request.FormId is null &&
                    Request.SubscriberId is null &&
                    Request.CycleId is null &&
                    Request.CategoryId is null)
                {
                    CriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                        .OrderByDescending(x => x.Id, Request.page, Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    if (Request.page != 0 && Request.perPage != -1)
                    {
                        CriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                            .Where(x => (Request.FormId != null ? x.ProvidedFormId == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.ProvidedForm!.User!.SubscriberId)
                                        ? x.ProvidedForm!.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.ProvidedForm!.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.ProvidedForm!.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();
                    }
                    else
                    {
                        CriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                            .Where(x => (Request.FormId != null ? x.ProvidedFormId == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.ProvidedForm!.User!.SubscriberId)
                                        ? x.ProvidedForm!.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.ProvidedForm!.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.ProvidedForm!.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .ToListAsync();
                    }
                }

                foreach (CriterionItemAttachment CriterionItemAttachmentEntity in CriterionItemAttachmentEntities)
                {
                    List<string> FilePath = CriterionItemAttachmentEntity.AttachementPath.Split("wwwroot").ToList();

                    CriterionItemAttachmentEntity.AttachementPath = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> FilesFromCriterionItemAttachmentes = CriterionItemAttachmentEntities
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024),
                        FileType = Path.GetExtension(x.AttachementPath),
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        CycleNumber = x.ProvidedForm!.Category!.Cycle!.CycleNumber,
                        FormId = x.ProvidedFormId,
                        SubscriberId = x.ProvidedForm!.User!.SubscriberId,
                        UserId = x.ProvidedForm!.userId
                    }).ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionItemAttachmentes, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.SpecialCondition)
            {
                int TotalCount = await _ConditionAttachmentRepository.GetCountAsync(null);

                List<ConditionAttachment> ConditionAttachmentEntities = new List<ConditionAttachment>();

                if (Request.FormId is null &&
                    Request.SubscriberId is null &&
                    Request.CycleId is null &&
                    Request.CategoryId is null)
                {
                    ConditionAttachmentEntities = await _ConditionAttachmentRepository
                        .OrderByDescending(x => x.Id, Request.page, Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    if (Request.page != 0 && Request.perPage != -1)
                    {
                        ConditionAttachmentEntities = await _ConditionAttachmentRepository
                            .Where(x => (Request.FormId != null ? x.ConditionsProvidedForms!.ProvidedFormId == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.ConditionsProvidedForms!.ProvidedForm!.User!.SubscriberId)
                                        ? x.ConditionsProvidedForms!.ProvidedForm!.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.ConditionsProvidedForms!.ProvidedForm!.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.ConditionsProvidedForms!.ProvidedForm!.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();
                    }
                    else
                    {
                        ConditionAttachmentEntities = await _ConditionAttachmentRepository
                            .Where(x => (Request.FormId != null ? x.ConditionsProvidedForms!.ProvidedFormId == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.ConditionsProvidedForms!.ProvidedForm!.User!.SubscriberId)
                                        ? x.ConditionsProvidedForms!.ProvidedForm!.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.ConditionsProvidedForms!.ProvidedForm!.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.ConditionsProvidedForms!.ProvidedForm!.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .ToListAsync();
                    }
                }

                foreach (ConditionAttachment ConditionAttachmentEntity in ConditionAttachmentEntities)
                {
                    List<string> FilePath = ConditionAttachmentEntity.AttachementPath.Split("wwwroot").ToList();

                    ConditionAttachmentEntity.AttachementPath = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> FilesFromSpecialConditions = ConditionAttachmentEntities
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024),
                        FileType = Path.GetExtension(x.AttachementPath),
                        CategoryName = Request.lang == "en"
                            ? x.ConditionsProvidedForms!.ProvidedForm!.Category!.EnglishName
                            : x.ConditionsProvidedForms!.ProvidedForm!.Category!.ArabicName,
                        CycleNumber = x.ConditionsProvidedForms!.ProvidedForm!.Category!.Cycle!.CycleNumber,
                        FormId = x.ConditionsProvidedForms!.ProvidedFormId,
                        SubscriberId = x.ConditionsProvidedForms!.ProvidedForm!.User!.SubscriberId,
                        UserId = x.ConditionsProvidedForms.ProvidedForm!.userId
                    }).ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromSpecialConditions, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.GeneralCondition)
            {
                int TotalCount = await _CycleConditionAttachmentRepository.GetCountAsync(null);

                List<CycleConditionAttachment> CycleConditionAttachmentEntities = new List<CycleConditionAttachment>();

                if (Request.FormId is null &&
                    Request.SubscriberId is null &&
                    Request.CycleId is null &&
                    Request.CategoryId is null)
                {
                    CycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                        .OrderByDescending(x => x.Id, Request.page, Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    if (Request.page != 0 && Request.perPage != -1)
                    {
                        CycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                            .Where(x => (Request.FormId != null ? x.CycleConditionsProvidedForm!.ProvidedFormId == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.CycleConditionsProvidedForm!.ProvidedForm!.User!.SubscriberId)
                                        ? x.CycleConditionsProvidedForm!.ProvidedForm!.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.CycleConditionsProvidedForm!.ProvidedForm!.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.CycleConditionsProvidedForm!.ProvidedForm!.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();
                    }
                    else
                    {
                        CycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                            .Where(x => (Request.FormId != null ? x.CycleConditionsProvidedForm!.ProvidedFormId == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.CycleConditionsProvidedForm!.ProvidedForm!.User!.SubscriberId)
                                        ? x.CycleConditionsProvidedForm!.ProvidedForm!.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.CycleConditionsProvidedForm!.ProvidedForm!.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.CycleConditionsProvidedForm!.ProvidedForm!.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .ToListAsync();
                    }
                }

                foreach (CycleConditionAttachment CycleConditionAttachmentEntity in CycleConditionAttachmentEntities)
                {
                    List<string> FilePath = CycleConditionAttachmentEntity.AttachementPath.Split("wwwroot").ToList();

                    CycleConditionAttachmentEntity.AttachementPath = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> FilesFromGeneralConditions = CycleConditionAttachmentEntities
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024),
                        FileType = Path.GetExtension(x.AttachementPath),
                        CategoryName = Request.lang == "en"
                            ? x.CycleConditionsProvidedForm!.ProvidedForm!.Category!.EnglishName
                            : x.CycleConditionsProvidedForm!.ProvidedForm!.Category!.ArabicName,
                        CycleNumber = x.CycleConditionsProvidedForm!.ProvidedForm!.Category!.Cycle!.CycleNumber,
                        FormId = x.CycleConditionsProvidedForm!.ProvidedFormId,
                        SubscriberId = x.CycleConditionsProvidedForm!.ProvidedForm!.User!.SubscriberId,
                        UserId = x.CycleConditionsProvidedForm!.ProvidedForm!.userId
                    }).ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromGeneralConditions, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.SubscriberPersonalAndAcademicInformation)
            {
                List<DynamicAttributeTableValue> DynamicAttributeTableValueList1 = await _DynamicAttributeTableValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .ToListAsync();

                List<DynamicAttributeValue> DynamicAttributeValueList2 = await _DynamicAttributeValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)))
                    .ToListAsync();

                List<Domain.Entities.ProvidedFormModel.ProvidedForm> AllProvidedFormEntities = await _ProvidedFormRepository
                    .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                        DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id))
                    .ToListAsync();

                int TotalCount1 = 0;
                int TotalCount2 = 0;

                if (Request.FormId is null &&
                    Request.SubscriberId is null &&
                    Request.CycleId is null &&
                    Request.CategoryId is null)
                {
                    TotalCount1 = DynamicAttributeTableValueList1.Count();
                    TotalCount2 = DynamicAttributeTableValueList1.Count();
                }
                else
                {
                    if (Request.page != 0 && Request.perPage != -1)
                    {
                        AllProvidedFormEntities = AllProvidedFormEntities
                            .Where(x => (Request.FormId != null ? x.Id == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.User!.SubscriberId)
                                        ? x.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToList();
                    }
                    else
                    {
                        AllProvidedFormEntities = AllProvidedFormEntities
                            .Where(x => (Request.FormId != null ? x.Id == Request.FormId : true) &&
                                (!string.IsNullOrEmpty(Request.SubscriberId)
                                    ? (!string.IsNullOrEmpty(x.User!.SubscriberId)
                                        ? x.User!.SubscriberId.ToLower().StartsWith(Request.SubscriberId.ToLower())
                                        : false)
                                    : true) &&
                                (Request.CycleId != null
                                    ? x.Category!.CycleId == Request.CycleId
                                    : true) &&
                                (Request.CategoryId != null
                                    ? x.categoryId == Request.CategoryId
                                    : true))
                            .OrderByDescending(x => x.Id)
                            .ToList();
                    }

                    DynamicAttributeTableValueList1 = DynamicAttributeTableValueList1
                        .Where(x => AllProvidedFormEntities.Select(y => y.Id).Contains(x.RecordId))
                        .ToList();

                    DynamicAttributeValueList2 = DynamicAttributeValueList2
                        .Where(x => AllProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId))
                        .ToList();

                    TotalCount1 = DynamicAttributeTableValueList1.Count();
                    TotalCount2 = DynamicAttributeTableValueList1.Count();
                }
                
                int TotalCount = TotalCount1 + TotalCount2;

                foreach (DynamicAttributeTableValue DynamicAttributeTableValue1 in DynamicAttributeTableValueList1)
                {
                    List<string> FilePath = DynamicAttributeTableValue1.Value.Split("wwwroot").ToList();

                    DynamicAttributeTableValue1.Value = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> FilesValues1 = DynamicAttributeTableValueList1
                    .Select(x =>
                    {
                        Domain.Entities.ProvidedFormModel.ProvidedForm? CopyProvidedFormEntity = AllProvidedFormEntities
                            .FirstOrDefault(y => y.Id == x.RecordId);

                        if (CopyProvidedFormEntity is null)
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                RowId = x.RowId,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value)
                            };
                        else
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                RowId = x.RowId,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value),
                                CategoryName = Request.lang == "en"
                                ? CopyProvidedFormEntity!.Category!.EnglishName
                                : CopyProvidedFormEntity!.Category!.ArabicName,
                                CycleNumber = CopyProvidedFormEntity.Category!.Cycle!.CycleNumber,
                                FormId = CopyProvidedFormEntity.Id,
                                SubscriberId = CopyProvidedFormEntity!.User!.SubscriberId,
                                UserId = CopyProvidedFormEntity.userId
                            };
                    }).ToList();

                foreach (DynamicAttributeValue DynamicAttributeValue2 in DynamicAttributeValueList2)
                {
                    List<string> FilePath = DynamicAttributeValue2.Value.Split("wwwroot").ToList();

                    DynamicAttributeValue2.Value = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> FilesValues2 = DynamicAttributeValueList2
                    .Select(x =>
                    {
                        Domain.Entities.ProvidedFormModel.ProvidedForm? CopyProvidedFormEntity = AllProvidedFormEntities
                            .FirstOrDefault(y => y.Id == x.RecordId);

                        if (CopyProvidedFormEntity is null)
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value)
                            };
                        else
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value),
                                CategoryName = Request.lang == "en"
                                ? CopyProvidedFormEntity!.Category!.EnglishName
                                : CopyProvidedFormEntity!.Category!.ArabicName,
                                CycleNumber = CopyProvidedFormEntity.Category!.Cycle!.CycleNumber,
                                FormId = CopyProvidedFormEntity.Id,
                                SubscriberId = CopyProvidedFormEntity!.User!.SubscriberId,
                                UserId = CopyProvidedFormEntity.userId
                            };
                    }).ToList();

                List<GetAllFilesByFilterListVM> FilesValues = FilesValues1
                    .Union(FilesValues2)
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : 0)
                    .Take((Request.page != 0 || Request.perPage != -1)
                        ? Request.perPage : TotalCount)
                    .ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesValues, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.CoordinatorFiles)
            {
                List<DynamicAttributeTableValue> DynamicAttributeTableValueList1 = await _DynamicAttributeTableValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == -2 &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4))
                    .ToListAsync();

                List<DynamicAttributeValue> DynamicAttributeValueList2 = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == -2 &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4))
                    .ToListAsync();

                int TotalCount1 = 0;
                int TotalCount2 = 0;

                List<Coordinator> AllCoordinatorEntities = new List<Coordinator>();

                if (string.IsNullOrEmpty(Request.CoordinatorName) &&
                    Request.UserId is null)
                {
                    AllCoordinatorEntities = await _CoordinatorRepository
                        .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                            DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id))
                        .ToListAsync();
                }
                else
                {
                    if (!string.IsNullOrEmpty(Request.CoordinatorName) &&
                        Request.UserId is null)
                    {
                        AllCoordinatorEntities = await _CoordinatorRepository
                            .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                                DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id) &&
                                (Request.lang == "en"
                                    ? x.EnglishName.ToLower().StartsWith(Request.CoordinatorName.ToLower())
                                    : x.ArabicName.ToLower().StartsWith(Request.CoordinatorName.ToLower())))
                            .ToListAsync();
                    }
                    else if (string.IsNullOrEmpty(Request.CoordinatorName) &&
                        Request.UserId is not null)
                    {
                        AllCoordinatorEntities = await _CoordinatorRepository
                            .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                                DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id) &&
                                x.Id == Request.UserId)
                            .ToListAsync();
                    }
                    else
                    {
                        AllCoordinatorEntities = await _CoordinatorRepository
                            .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                                DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id) &&
                                (Request.lang == "en"
                                    ? x.EnglishName.ToLower().StartsWith(Request.CoordinatorName!.ToLower())
                                    : x.ArabicName.ToLower().StartsWith(Request.CoordinatorName!.ToLower())) &&
                                x.Id == Request.UserId)
                            .ToListAsync();
                    }

                    DynamicAttributeTableValueList1 = DynamicAttributeTableValueList1
                        .Where(x => AllCoordinatorEntities.Select(y => y.Id).Contains(x.RecordId))
                        .ToList();

                    DynamicAttributeValueList2 = DynamicAttributeValueList2
                        .Where(x => AllCoordinatorEntities.Select(y => y.Id).Any(y => y == x.RecordId))
                        .ToList();

                    TotalCount1 = DynamicAttributeTableValueList1.Count();
                    TotalCount2 = DynamicAttributeTableValueList1.Count();
                }

                int TotalCount = TotalCount1 + TotalCount2;

                foreach (DynamicAttributeTableValue DynamicAttributeTableValue1 in DynamicAttributeTableValueList1)
                {
                    List<string> FilePath = DynamicAttributeTableValue1.Value.Split("wwwroot").ToList();

                    DynamicAttributeTableValue1.Value = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }
                
                List<GetAllFilesByFilterListVM> FirstFilesValues = DynamicAttributeTableValueList1
                    .Select(x =>
                    {
                        Coordinator? CopyCoordinatorEntity = AllCoordinatorEntities
                            .FirstOrDefault(y => y.Id == x.RecordId);

                        if (CopyCoordinatorEntity is null)
                        {
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                RowId = x.RowId,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value)
                            };
                        }
                        else
                        {
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                RowId = x.RowId,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value),
                                UserId = CopyCoordinatorEntity.Id,
                                CoordinatorName = Request.lang == "en"
                                    ? CopyCoordinatorEntity.EnglishName
                                    : CopyCoordinatorEntity.ArabicName
                            };
                        }
                    }).ToList();
                
                foreach (DynamicAttributeValue DynamicAttributeValue2 in DynamicAttributeValueList2)
                {
                    List<string> FilePath = DynamicAttributeValue2.Value.Split("wwwroot").ToList();

                    DynamicAttributeValue2.Value = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> SecondFilesValues = DynamicAttributeValueList2
                    .Select(x =>
                    {
                        Coordinator? CopyCoordinatorEntity = AllCoordinatorEntities
                            .FirstOrDefault(y => y.Id == x.RecordId);

                        if (CopyCoordinatorEntity is null)
                        {
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value)
                            };
                        }
                        else
                        {
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value),
                                UserId = CopyCoordinatorEntity.Id,
                                CoordinatorName = Request.lang == "en"
                                    ? CopyCoordinatorEntity.EnglishName
                                    : CopyCoordinatorEntity.ArabicName
                            };
                        }
                    }).ToList();

                List<GetAllFilesByFilterListVM> FilesValues = FirstFilesValues
                    .Union(SecondFilesValues)
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : 0)
                    .Take((Request.page != 0 || Request.perPage != -1)
                        ? Request.perPage : TotalCount)
                    .ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesValues, PaginationParameter);
            }
            else if (Request.FilterId == (int)FilesFilter.ArbitratorFiles)
            {
                List<DynamicAttributeTableValue> DynamicAttributeTableValueList1 = await _DynamicAttributeTableValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == -1 &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4))
                    .ToListAsync();

                List<DynamicAttributeValue> DynamicAttributeValueList2 = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == -1 &&
                        (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4))
                    .ToListAsync();

                int TotalCount1 = 0;
                int TotalCount2 = 0;

                List<Arbitrator> AllArbitratorEntities = new List<Arbitrator>();

                if (string.IsNullOrEmpty(Request.ArbitratorName) &&
                    Request.UserId is null)
                {
                    AllArbitratorEntities = await _ArbitratorRepository
                        .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                            DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id))
                        .ToListAsync();
                }
                else
                {
                    if (!string.IsNullOrEmpty(Request.ArbitratorName) &&
                        Request.UserId is null)
                    {
                        AllArbitratorEntities = await _ArbitratorRepository
                            .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                                DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id) &&
                                (Request.lang == "en"
                                    ? x.EnglishName.ToLower().StartsWith(Request.ArbitratorName.ToLower())
                                    : x.ArabicName.ToLower().StartsWith(Request.ArbitratorName.ToLower())))
                            .ToListAsync();
                    }
                    else if (string.IsNullOrEmpty(Request.ArbitratorName) &&
                        Request.UserId is not null)
                    {
                        AllArbitratorEntities = await _ArbitratorRepository
                            .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                                DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id) &&
                                x.Id == Request.UserId)
                            .ToListAsync();
                    }
                    else
                    {
                        AllArbitratorEntities = await _ArbitratorRepository
                            .Where(x => DynamicAttributeTableValueList1.Select(y => y.RecordId).Contains(x.Id) ||
                                DynamicAttributeValueList2.Select(y => y.RecordId).Contains(x.Id) &&
                                (Request.lang == "en"
                                    ? x.EnglishName.ToLower().StartsWith(Request.ArbitratorName!.ToLower())
                                    : x.ArabicName.ToLower().StartsWith(Request.ArbitratorName!.ToLower())) &&
                                x.Id == Request.UserId)
                            .ToListAsync();
                    }

                    DynamicAttributeTableValueList1 = DynamicAttributeTableValueList1
                        .Where(x => AllArbitratorEntities.Select(y => y.Id).Contains(x.RecordId))
                        .ToList();

                    DynamicAttributeValueList2 = DynamicAttributeValueList2
                        .Where(x => AllArbitratorEntities.Select(y => y.Id).Any(y => y == x.RecordId))
                        .ToList();

                    TotalCount1 = DynamicAttributeTableValueList1.Count();
                    TotalCount2 = DynamicAttributeTableValueList1.Count();
                }

                int TotalCount = TotalCount1 + TotalCount2;

                foreach (DynamicAttributeTableValue DynamicAttributeTableValue1 in DynamicAttributeTableValueList1)
                {
                    List<string> FilePath = DynamicAttributeTableValue1.Value.Split("wwwroot").ToList();

                    DynamicAttributeTableValue1.Value = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> FirstFilesValues = DynamicAttributeTableValueList1
                    .Select(x =>
                    {
                        Arbitrator? CopyArbitratorEntity = AllArbitratorEntities
                            .FirstOrDefault(y => y.Id == x.RecordId);

                        if (CopyArbitratorEntity is null)
                        {
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                RowId = x.RowId,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value)
                            };
                        }
                        else
                        {
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                RowId = x.RowId,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value),
                                UserId = CopyArbitratorEntity.Id,
                                ArbitratorName = Request.lang == "en"
                                    ? CopyArbitratorEntity.EnglishName
                                    : CopyArbitratorEntity.ArabicName
                            };
                        }
                    }).ToList();
                
                foreach (DynamicAttributeValue DynamicAttributeValue2 in DynamicAttributeValueList2)
                {
                    List<string> FilePath = DynamicAttributeValue2.Value.Split("wwwroot").ToList();

                    DynamicAttributeValue2.Value = Request.wwwRootFilePath!.Replace("\\", "/") +
                        FilePath[1];
                }

                List<GetAllFilesByFilterListVM> SecondFilesValues = DynamicAttributeValueList2
                    .Select(x =>
                    {
                        Arbitrator? CopyArbitratorEntity = AllArbitratorEntities
                            .FirstOrDefault(y => y.Id == x.RecordId);

                        if (CopyArbitratorEntity is null)
                        {
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value),
                            };
                        }
                        else
                        {
                            return new GetAllFilesByFilterListVM()
                            {
                                Id = x.Id,
                                Description = null,
                                FileName = new FileInfo(x.Value).Name,
                                FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                                UploadedAt = x.CreatedAt,
                                FileType = Path.GetExtension(x.Value),
                                UserId = CopyArbitratorEntity.Id,
                                ArbitratorName = Request.lang == "en"
                                    ? CopyArbitratorEntity.EnglishName
                                    : CopyArbitratorEntity.ArabicName
                            };
                        }
                    }).ToList();

                List<GetAllFilesByFilterListVM> FilesValues = FirstFilesValues
                    .Union(SecondFilesValues)
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.perPage != -1)
                        ? (Request.page - 1) * Request.perPage : 0)
                    .Take((Request.page != 0 || Request.perPage != -1)
                        ? Request.perPage : TotalCount)
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
