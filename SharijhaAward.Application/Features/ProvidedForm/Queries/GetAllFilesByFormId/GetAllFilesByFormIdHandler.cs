using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFilesByFormId
{
    public class GetAllFilesByFormIdHandler : IRequestHandler<GetAllFilesByFormIdQuery, BaseResponse<List<GetAllFilesByFormIdMainResponse>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public GetAllFilesByFormIdHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository,
            IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository,
            IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository,
            IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._CycleConditionAttachmentRepository = _CycleConditionAttachmentRepository;
            this._ConditionAttachmentRepository = _ConditionAttachmentRepository;
            this._ExtraAttachmentFileRepository = _ExtraAttachmentFileRepository;
            this._CriterionAttachmentRepository = _CriterionAttachmentRepository;
            this._CriterionItemAttachmentRepository = _CriterionItemAttachmentRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public async Task<BaseResponse<List<GetAllFilesByFormIdMainResponse>>> Handle(GetAllFilesByFormIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ProvidedFormEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Form is not found"
                    : "الاستمارة غير موجودة";

                return new BaseResponse<List<GetAllFilesByFormIdMainResponse>>(ResponseMessage, false, 404);
            }

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<GetAllFilesByFormIdMainResponse> Response = new List<GetAllFilesByFormIdMainResponse>();

            List<DynamicAttributeValue> DynamicAttributeValueFilesPaths = await _DynamicAttributeValueRepository
                .Where(x => x.RecordId == Request.Id &&
                    (x.DynamicAttribute!.AttributeDataTypeId == 3 ||
                    x.DynamicAttribute!.AttributeDataTypeId == 4) &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1)
                .ToListAsync();

            Response.Add(new GetAllFilesByFormIdMainResponse()
            {
                Name = "Personal Information",
                Files = DynamicAttributeValueFilesPaths
                    .Select(x => new FilesInfoDto()
                    {
                        FilePath = x.Value.Contains("wwwroot")
                            ? (WWWRootFilePath + x.Value.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.Value.Replace("\\", "/"),
                        FileName = string.Empty
                    }).ToList(),
                SubFolders = new List<GetAllFilesByFormIdMainResponse>()
            });

            List<CycleConditionAttachment> GeneralConditionsFilesPaths = await _CycleConditionAttachmentRepository
                .Where(x => x.CycleConditionsProvidedForm!.ProvidedFormId == Request.Id &&
                    x.IsAccept != false)
                .ToListAsync();

            Response.Add(new GetAllFilesByFormIdMainResponse()
            {
                Name = "General Conditions",
                Files = GeneralConditionsFilesPaths
                    .Select(x => new FilesInfoDto()
                    {
                        FilePath = x.AttachementPath.Contains("wwwroot")
                            ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.AttachementPath.Replace("\\", "/"),
                        FileName = x.Name
                    }).ToList(),
                SubFolders = new List<GetAllFilesByFormIdMainResponse>()
            });

            List<ConditionAttachment> SpecialConditionsFilesPaths = await _ConditionAttachmentRepository
                .Where(x => x.ConditionsProvidedForms!.ProvidedFormId == Request.Id &&
                    x.IsAccept != false)
                .ToListAsync();

            Response.Add(new GetAllFilesByFormIdMainResponse()
            {
                Name = "Special Conditions",
                Files = SpecialConditionsFilesPaths
                    .Select(x => new FilesInfoDto()
                    {
                        FilePath = x.AttachementPath.Contains("wwwroot")
                            ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.AttachementPath.Replace("\\", "/"),
                        FileName = x.Name
                    }).ToList(),
                SubFolders = new List<GetAllFilesByFormIdMainResponse>()
            });

            List<ExtraAttachmentFile> ExtraAttachmentsFilesPaths = await _ExtraAttachmentFileRepository
                .Where(x => x.ExtraAttachment!.ProvidedFormId == Request.Id &&
                    x.IsAccept != false)
                .ToListAsync();

            Response.Add(new GetAllFilesByFormIdMainResponse()
            {
                Name = "Extra Attachments",
                Files = ExtraAttachmentsFilesPaths
                    .Select(x => new FilesInfoDto()
                    {
                        FilePath = x.FileUrl.Contains("wwwroot")
                            ? (WWWRootFilePath + x.FileUrl.Split("wwwroot")[1]).Replace("\\", "/")
                            : x.FileUrl.Replace("\\", "/"),
                        FileName = x.FileName
                    }).ToList(),
                SubFolders = new List<GetAllFilesByFormIdMainResponse>()
            });

            List<CriterionAttachment> CriterionAttachmentEntities = await _CriterionAttachmentRepository
                .Where(x => x.ProvidedFormId == Request.Id &&
                    x.IsAccepted != false)
                .Include(x => x.Criterion!.Parent!)
                .ToListAsync();

            List<CriterionItemAttachment> CriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                .Where(x => x.ProvidedFormId == Request.Id &&
                    x.IsAccepted != false)
                .Include(x => x.CriterionItem!.Criterion!.Parent!)
                .ToListAsync();

            List<Criterion> MainCriterions1 = CriterionAttachmentEntities
                .Select(x => x.Criterion!.Parent!)
                .ToList();

            List<Criterion> MainCriterions2 = CriterionItemAttachmentEntities
                .Select(x => x.CriterionItem!.Criterion!.Parent!)
                .ToList();

            List<Criterion> AllMainCriterions = MainCriterions1
                .Union(MainCriterions2)
                .DistinctBy(x => x.Id)
                .ToList();

            List<Criterion> SubCriterions1 = CriterionAttachmentEntities
                .Select(x => x.Criterion!)
                .ToList();

            List<Criterion> SubCriterions2 = CriterionItemAttachmentEntities
                .Select(x => x.CriterionItem!.Criterion!)
                .ToList();

            List<Criterion> AllSubCriterions = SubCriterions1
                .Union(SubCriterions2)
                .DistinctBy(x => x.Id)
                .ToList();

            List<CriterionItem> AllSubCriterionItems = CriterionItemAttachmentEntities
                .Select(x => x.CriterionItem!)
                .ToList();

            List<MainCriterionFilesDto> MainCriterionFilesDtoList = new List<MainCriterionFilesDto>();

            GetAllFilesByFormIdMainResponse Criterions = new GetAllFilesByFormIdMainResponse()
            {
                Name = "Criterions",
                Files = new List<FilesInfoDto>(),
                SubFolders = new List<GetAllFilesByFormIdMainResponse>()
            };

            foreach (Criterion MainCriterion in AllMainCriterions)
            {
                GetAllFilesByFormIdMainResponse MainCriterionGetAllFilesByFormIdMainResponse = new GetAllFilesByFormIdMainResponse()
                {
                    Name = MainCriterion.EnglishTitle,
                    Files = new List<FilesInfoDto>(),
                    SubFolders = new List<GetAllFilesByFormIdMainResponse>()
                };

                List<Criterion> SubCriterons = AllSubCriterions
                    .Where(x => x.ParentId == MainCriterion.Id)
                    .ToList();

                foreach (Criterion SubCriterion in SubCriterons)
                {
                    GetAllFilesByFormIdMainResponse SubCriterionGetAllFilesByFormIdMainResponse = new GetAllFilesByFormIdMainResponse()
                    {
                        Name = SubCriterion.EnglishTitle,
                        Files = new List<FilesInfoDto>(),
                        SubFolders = new List<GetAllFilesByFormIdMainResponse>()
                    };

                    List<CriterionItem> SubCriterionItems = AllSubCriterionItems
                        .Where(x => x.CriterionId == SubCriterion.Id)
                        .ToList();

                    if (SubCriterionItems.Any())
                    {
                        List<IGrouping<CriterionItem, CriterionItemAttachment>> CriterionItemAttachmentsFilesPaths = CriterionItemAttachmentEntities
                            .Where(x => x.CriterionItem!.CriterionId == SubCriterion.Id)
                            .GroupBy(x => x.CriterionItem!)
                            .ToList();

                        SubCriterionGetAllFilesByFormIdMainResponse.SubFolders = CriterionItemAttachmentsFilesPaths
                            .Select(x => new GetAllFilesByFormIdMainResponse()
                            {
                                Name = x.Key.EnglishName,
                                SubFolders = new List<GetAllFilesByFormIdMainResponse>(),
                                Files = x
                                    .ToList()
                                    .Select(x => new FilesInfoDto()
                                    {
                                        FilePath = x.AttachementPath.Contains("wwwroot")
                                            ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                            : x.AttachementPath.Replace("\\", "/"),
                                        FileName = x.Name
                                    }).ToList()
                            }).ToList();
                    }
                    else
                    {
                        SubCriterionGetAllFilesByFormIdMainResponse.Files = CriterionAttachmentEntities
                            .Where(x => x.CriterionId == SubCriterion.Id)
                            .Select(x => new FilesInfoDto()
                            {
                                FilePath = x.AttachementPath.Contains("wwwroot")
                                    ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                    : x.AttachementPath.Replace("\\", "/"),
                                FileName = x.Name
                            }).ToList();
                    }

                    MainCriterionGetAllFilesByFormIdMainResponse.SubFolders.Add(SubCriterionGetAllFilesByFormIdMainResponse);
                }

                Criterions.SubFolders.Add(MainCriterionGetAllFilesByFormIdMainResponse);
            }

            Response.Add(Criterions);

            return new BaseResponse<List<GetAllFilesByFormIdMainResponse>>(ResponseMessage, true, 200, Response);
        }
    }
}
