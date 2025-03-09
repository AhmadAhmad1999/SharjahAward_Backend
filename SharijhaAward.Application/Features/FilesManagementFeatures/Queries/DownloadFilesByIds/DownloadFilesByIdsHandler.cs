using MediatR;
using Microsoft.AspNetCore.Http;
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
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public DownloadFilesByIdsHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<DownloadFilesByIdsListVM>>> 
            Handle(DownloadFilesByIdsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.FilterId == (int)FilesFilter.Criterion)
            {
                List<DownloadFilesByIdsListVM> FilesFromCriterionAttachmentes = _CriterionAttachmentRepository
                    .Where(x => (!Request.DownloadAllFiles
                        ? Request.Ids.Any(y => y == x.Id)
                        : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + x.AttachementPath.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.AttachementPath.Replace("\\", "/"),
                            FileName = x.Name
                        };
                    }).ToList();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionAttachmentes);
            }
            else if (Request.FilterId == (int)FilesFilter.CriterionItem)
            {
                List<DownloadFilesByIdsListVM> FilesFromCriterionItemAttachmentes = _CriterionItemAttachmentRepository
                    .Where(x => (!Request.DownloadAllFiles
                        ? Request.Ids.Any(y => y == x.Id)
                        : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + x.AttachementPath.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.AttachementPath.Replace("\\", "/"),
                            FileName = x.Name
                        };
                    }).ToList();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200,
                    FilesFromCriterionItemAttachmentes);
            }
            else if (Request.FilterId == (int)FilesFilter.SpecialCondition)
            {
                List<DownloadFilesByIdsListVM> FilesFromSpecialConditions = _ConditionAttachmentRepository
                    .Where(x => (!Request.DownloadAllFiles
                        ? Request.Ids.Any(y => y == x.Id)
                        : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + x.AttachementPath.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.AttachementPath.Replace("\\", "/"),
                            FileName = x.Name
                        };
                    }).ToList();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200,
                    FilesFromSpecialConditions);
            }
            else if (Request.FilterId == (int)FilesFilter.GeneralCondition)
            {
                List<DownloadFilesByIdsListVM> FilesFromGeneralConditions = _CycleConditionAttachmentRepository
                    .Where(x => (!Request.DownloadAllFiles
                        ? Request.Ids.Any(y => y == x.Id)
                        : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + x.AttachementPath.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.AttachementPath.Replace("\\", "/"),
                            FileName = x.Name
                        };
                    }).ToList();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200,
                    FilesFromGeneralConditions);
            }
            else if (Request.FilterId == (int)FilesFilter.SubscriberPersonalAndAcademicInformation)
            {
                List<DownloadFilesByIdsListVM> FilesValues1 = _DynamicAttributeValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.Value.Contains("wwwroot")
                                ? (WWWRootFilePath + x.Value.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.Value.Replace("\\", "/"),
                            FileName = string.Empty,
                            isDynamic = true
                        };
                    }).ToList();

                List<DownloadFilesByIdsListVM> FilesValues2 = _DynamicAttributeTableValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)) &&
                        (!Request.DownloadAllFiles
                            ? Request.TableAttributeIds.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.Value.Contains("wwwroot")
                                ? (WWWRootFilePath + x.Value.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.Value.Replace("\\", "/"),
                            FileName = string.Empty,
                            isDynamic = true
                        };
                    }).ToList();

                List<DownloadFilesByIdsListVM> FilesValues = FilesValues1
                    .Union(FilesValues2)
                    .ToList();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200, FilesValues);
            }
            else if (Request.FilterId == (int)FilesFilter.CoordinatorFiles)
            {
                List<DownloadFilesByIdsListVM> FilesValues1 = _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.Value.Contains("wwwroot")
                                ? (WWWRootFilePath + x.Value.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.Value.Replace("\\", "/"),
                            FileName = string.Empty,
                            isDynamic = true
                        };
                    }).ToList();
                
                List<DownloadFilesByIdsListVM> FilesValues2 = _DynamicAttributeTableValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)) &&
                        (!Request.DownloadAllFiles
                            ? Request.TableAttributeIds.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.Value.Contains("wwwroot")
                                ? (WWWRootFilePath + x.Value.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.Value.Replace("\\", "/"),
                            FileName = string.Empty,
                            isDynamic = true
                        };
                    }).ToList();

                List<DownloadFilesByIdsListVM> FilesValues = FilesValues1.Union(FilesValues2).ToList();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200, FilesValues);
            }
            else if (Request.FilterId == (int)FilesFilter.ArbitratorFiles)
            {
                List<DownloadFilesByIdsListVM> FilesValues1 = _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2 &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)) &&
                        (!Request.DownloadAllFiles
                            ? Request.Ids.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.Value.Contains("wwwroot")
                                ? (WWWRootFilePath + x.Value.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.Value.Replace("\\", "/"),
                            FileName = string.Empty,
                            isDynamic = true
                        };
                    }).ToList();

                List<DownloadFilesByIdsListVM> FilesValues2 = _DynamicAttributeTableValueRepository
                    .Where(x => (x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -1 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != -2) &&
                        ((x.DynamicAttribute!.AttributeDataTypeId == 3 || x.DynamicAttribute!.AttributeDataTypeId == 4)) &&
                        (!Request.DownloadAllFiles
                            ? Request.TableAttributeIds.Any(y => y == x.Id)
                            : true))
                    .OrderByDescending(x => x.Id)
                    .ToList()
                    .Select(x =>
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string WWWRootFilePath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                        return new DownloadFilesByIdsListVM()
                        {
                            FilePath = x.Value.Contains("wwwroot")
                                ? (WWWRootFilePath + x.Value.Replace("\\", "/").Split("wwwroot")[1]).Replace("\\", "/")
                                : x.Value.Replace("\\", "/"),
                            FileName = string.Empty,
                            isDynamic = true
                        };
                    }).ToList();

                List<DownloadFilesByIdsListVM> FilesValues = FilesValues1
                    .Union(FilesValues2)
                    .ToList();

                return new BaseResponse<List<DownloadFilesByIdsListVM>>(ResponseMessage, true, 200, FilesValues);
            }

            throw new NotImplementedException();
        }
    }
}
