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
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public GetAllFilesByFilterHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
        }
        public async Task<BaseResponse<List<GetAllFilesByFilterListVM>>> 
            Handle(GetAllFilesByFilterQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.Filter == FilesFilter.Criterion)
            {
                int TotalCount = await _CriterionAttachmentRepository.GetCountAsync(x => File.Exists(x.AttachementPath));

                List<GetAllFilesByFilterListVM> FilesFromCriterionAttachmentes = await _CriterionAttachmentRepository
                    .Where(x => File.Exists(x.AttachementPath))
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : 0)
                    .Take((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : TotalCount)
                    .Include(x => x.Criterion!)
                    .Include(x => x.Criterion!.Category!)
                    .Include(x => x.Criterion!.Category!.Cycle!)
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        CycleId = x.Criterion!.Category!.CycleId,
                        CycleName = Request.lang == "en"
                            ? x.Criterion!.Category!.Cycle!.EnglishName
                            : x.Criterion!.Category!.Cycle!.ArabicName,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024)
                    }).ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionAttachmentes, PaginationParameter);
            }
            else if (Request.Filter == FilesFilter.CriterionItem)
            {
                int TotalCount = await _CriterionItemAttachmentRepository.GetCountAsync(x => File.Exists(x.AttachementPath));

                List<GetAllFilesByFilterListVM> FilesFromCriterionItemAttachmentes = await _CriterionItemAttachmentRepository
                    .Where(x => File.Exists(x.AttachementPath))
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : 0)
                    .Take((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : TotalCount)
                    .Include(x => x.CriterionItem!)
                    .Include(x => x.CriterionItem!.Criterion!)
                    .Include(x => x.CriterionItem!.Criterion!.Category!)
                    .Include(x => x.CriterionItem!.Criterion!.Category!.Cycle!)
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        CycleId = x.CriterionItem!.Criterion!.Category!.CycleId,
                        CycleName = Request.lang == "en"
                            ? x.CriterionItem!.Criterion!.Category!.Cycle!.EnglishName
                            : x.CriterionItem!.Criterion!.Category!.Cycle!.ArabicName,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024)
                    }).ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionItemAttachmentes, PaginationParameter);
            }
            else if (Request.Filter == FilesFilter.SpecialCondition)
            {
                int TotalCount = await _ConditionAttachmentRepository.GetCountAsync(x => File.Exists(x.AttachementPath));

                List<GetAllFilesByFilterListVM> FilesFromSpecialConditions = await _ConditionAttachmentRepository
                    .Where(x => File.Exists(x.AttachementPath))
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : 0)
                    .Take((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : TotalCount)
                    .Include(x => x.ConditionsProvidedForms!)
                    .Include(x => x.ConditionsProvidedForms!.TermAndCondition!)
                    .Include(x => x.ConditionsProvidedForms!.TermAndCondition!.Category!)
                    .Include(x => x.ConditionsProvidedForms!.TermAndCondition!.Category!.Cycle!)
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        CycleId = x.ConditionsProvidedForms!.TermAndCondition!.Category!.CycleId,
                        CycleName = Request.lang == "en"
                            ? x.ConditionsProvidedForms!.TermAndCondition!.Category!.Cycle!.EnglishName
                            : x.ConditionsProvidedForms!.TermAndCondition!.Category!.Cycle!.ArabicName,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024)
                    }).ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromSpecialConditions, PaginationParameter);
            }
            else if (Request.Filter == FilesFilter.GeneralCondition)
            {
                int TotalCount = await _CycleConditionAttachmentRepository.GetCountAsync(x => File.Exists(x.AttachementPath));

                List<GetAllFilesByFilterListVM> FilesFromGeneralConditions = await _CycleConditionAttachmentRepository
                    .Where(x => File.Exists(x.AttachementPath))
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : 0)
                    .Take((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : TotalCount)
                    .Include(x => x.CycleConditionsProvidedForm!)
                    .Include(x => x.CycleConditionsProvidedForm!.CycleCondition!)
                    .Include(x => x.CycleConditionsProvidedForm!.CycleCondition!.Cycle!)
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        CycleId = x.CycleConditionsProvidedForm!.CycleCondition!.CycleId,
                        CycleName = Request.lang == "en"
                            ? x.CycleConditionsProvidedForm!.CycleCondition!.Cycle!.EnglishName
                            : x.CycleConditionsProvidedForm!.CycleCondition!.Cycle!.ArabicName,
                        Description = x.Description,
                        FileName = x.Name,
                        UploadedAt = x.CreatedAt,
                        FileSizeInKB = (int)(new FileInfo(x.AttachementPath).Length / 1024)
                    }).ToListAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromGeneralConditions, PaginationParameter);
            }
            else if (Request.Filter == FilesFilter.PersonalAndAcademicInformation)
            {
                int TotalCount = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .CountAsync(x => (x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)
                        ? File.Exists(x.Value)
                        : false);

                List<DynamicAttributeValue> FilesValues = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)
                            ? File.Exists(x.Value)
                            : false))
                    .OrderByDescending(x => x.Id)
                    .Skip((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : 0)
                    .Take((Request.page != 0 || Request.pageSize != -1)
                        ? (Request.page - 1) * Request.pageSize : TotalCount)
                    .ToListAsync();

                List<Domain.Entities.ProvidedFormModel.ProvidedForm> Forms = await _ProvidedFormRepository
                    .Where(x => FilesValues.Select(y => y.RecordId).Any(y => y == x.Id))
                    .Include(x => x.Category!)
                    .Include(x => x.Category!.Cycle!)
                    .ToListAsync();

                List<GetAllFilesByFilterListVM> FilesFromPersonalAndAcademicInformations = FilesValues
                    .Select(x => new GetAllFilesByFilterListVM()
                    {
                        Id = x.Id,
                        CycleId = Forms.FirstOrDefault(y => y.Id == x.RecordId)!.Category!.CycleId,
                        CycleName = Request.lang == "en"
                            ? Forms.FirstOrDefault(y => y.Id == x.RecordId)!.Category!.Cycle!.EnglishName
                            : Forms.FirstOrDefault(y => y.Id == x.RecordId)!.Category!.Cycle!.ArabicName,
                        Description = null,
                        FileName = new FileInfo(x.Value).Name,
                        FileSizeInKB = (int)(new FileInfo(x.Value).Length / 1024),
                        UploadedAt = x.CreatedAt
                    }).ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllFilesByFilterListVM>>(ResponseMessage, true, 200,
                    FilesFromPersonalAndAcademicInformations, PaginationParameter);
            }

            throw new NotImplementedException();
        }
    }
}
