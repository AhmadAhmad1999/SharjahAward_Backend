using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.DownloadFilesByIds
{
    public class DownloadFilesByIdsHandler 
        : IRequestHandler<DownloadFilesByIdsQuery, BaseResponse<List<DownloadFilesByIdsListVM>>>
    {
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public DownloadFilesByIdsHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }

        public async Task<BaseResponse<List<DownloadFilesByIdsListVM>>> 
            Handle(DownloadFilesByIdsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.Filter == FilesFilter.Criterion)
            {
                List<DownloadFilesByIdsListVM> FilesFromCriterionAttachmentes = await _CriterionAttachmentRepository
                    .Where(x => File.Exists(x.AttachementPath) && 
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new DownloadFilesByIdsListVM()
                    {
                        FilePath = x.AttachementPath
                    }).ToListAsync();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionAttachmentes);
            }
            else if (Request.Filter == FilesFilter.CriterionItem)
            {
                List<DownloadFilesByIdsListVM> FilesFromCriterionItemAttachmentes = await _CriterionItemAttachmentRepository
                    .Where(x => File.Exists(x.AttachementPath) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new DownloadFilesByIdsListVM()
                    {
                        FilePath = x.AttachementPath
                    }).ToListAsync();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionItemAttachmentes);
            }
            else if (Request.Filter == FilesFilter.SpecialCondition)
            {
                List<DownloadFilesByIdsListVM> FilesFromSpecialConditions = await _ConditionAttachmentRepository
                    .Where(x => File.Exists(x.AttachementPath) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new DownloadFilesByIdsListVM()
                    {
                        FilePath = x.AttachementPath
                    }).ToListAsync();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200,
                    FilesFromSpecialConditions);
            }
            else if (Request.Filter == FilesFilter.GeneralCondition)
            {
                List<DownloadFilesByIdsListVM> FilesFromGeneralConditions = await _CycleConditionAttachmentRepository
                    .Where(x => File.Exists(x.AttachementPath) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new DownloadFilesByIdsListVM()
                    {
                        FilePath = x.AttachementPath
                    }).ToListAsync();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200,
                    FilesFromGeneralConditions);
            }
            else if (Request.Filter == FilesFilter.SubscriberPersonalAndAcademicInformation)
            {
                List<DownloadFilesByIdsListVM> FilesValues = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)
                            ? File.Exists(x.Value) : false) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new DownloadFilesByIdsListVM()
                    {
                        FilePath = x.Value
                    }).ToListAsync();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200, FilesValues);
            }
            else if (Request.Filter == FilesFilter.CoordinatorFiles)
            {
                List<DownloadFilesByIdsListVM> FilesValues = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)
                            ? File.Exists(x.Value) : false) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new DownloadFilesByIdsListVM()
                    {
                        FilePath = x.Value
                    }).ToListAsync();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200, FilesValues);
            }
            else if (Request.Filter == FilesFilter.ArbitratorFiles)
            {
                List<DownloadFilesByIdsListVM> FilesValues = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2 &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)
                            ? File.Exists(x.Value) : false) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .Select(x => new DownloadFilesByIdsListVM()
                    {
                        FilePath = x.Value
                    }).ToListAsync();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200, FilesValues);
            }

            throw new NotImplementedException();
        }
    }
}
