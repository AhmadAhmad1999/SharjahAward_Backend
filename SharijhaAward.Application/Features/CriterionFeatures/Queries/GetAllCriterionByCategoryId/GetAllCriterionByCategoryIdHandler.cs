using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class GetAllCriterionByCategoryIdHandler : IRequestHandler<GetAllCriterionByCategoryIdQuery,
        BaseResponse<List<MainCriterionListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository;
        private readonly IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository;

        public GetAllCriterionByCategoryIdHandler(IMapper _Mapper,
            IAsyncRepository<Category> _CategoryRepository,
            IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository,
            IHttpContextAccessor _HttpContextAccessor,
            IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository,
            IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository)
        {
            this._Mapper = _Mapper;
            this._CategoryRepository = _CategoryRepository;
            this._CriterionRepository = _CriterionRepository;
            this._CriterionItemRepository = _CriterionItemRepository;
            this._CriterionAttachmentRepository = _CriterionAttachmentRepository;
            this._CriterionItemAttachmentRepository = _CriterionItemAttachmentRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._CriterionAttachmentTypeRepository = _CriterionAttachmentTypeRepository;
            this._CriterionItemAttachmentTypeRepository = _CriterionItemAttachmentTypeRepository;
        }
        public async Task<BaseResponse<List<MainCriterionListVM>>> Handle(GetAllCriterionByCategoryIdQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            Category? CheckIfCategoryIdIsExist = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CheckIfCategoryIdIsExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجود";

                return new BaseResponse<List<MainCriterionListVM>>(ResponseMessage, false, 404);
            }

            List<MainCriterionListVM> FullObjectResponse = new List<MainCriterionListVM>();

            List<Criterion> AllCriterionsEntities = await _CriterionRepository
                .Where(x => x.CategoryId == Request.CategoryId)
                .Include(x => x.Parent!).ToListAsync();

            List<MainCriterionListVM> MainCriterionObjects = AllCriterionsEntities
                .Where(x => x.ParentId == null)
                .OrderBy(x => x.OrderId)
                .Select(x => new MainCriterionListVM()
                {
                    Id = x.Id,
                    Title = Language == "ar"
                        ? x.ArabicTitle
                        : x.EnglishTitle
                }).ToList();

            List<CriterionAttachmentType> CriterionAttachmentTypeEntities = _CriterionAttachmentTypeRepository
                .Where(x => AllCriterionsEntities
                    .Select(y => y.Id).Contains(x.CriterionId) && x.AttachmentType != null)
                .ToList();

            List<CriterionItemAttachmentType> CriterionItemAttachmentTypeEntities = _CriterionItemAttachmentTypeRepository
                .Where(x => AllCriterionsEntities
                    .Select(y => y.Id).Contains(x.CriterionItem!.CriterionId))
                .ToList();

            foreach (MainCriterionListVM MainCriterionObject in MainCriterionObjects)
            {
                MainCriterionObject.SubCriterionListVM = AllCriterionsEntities
                    .Where(x => x.ParentId == MainCriterionObject.Id)
                    .OrderBy(x => x.OrderId)
                    .Select(x => new SubCriterionListVM()
                    {
                        Id = x.Id,
                        Title = Language == "ar"
                            ? x.ArabicTitle
                            : x.EnglishTitle,
                        SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                        MaxAttachmentNumber = x.MaxAttachmentNumber != null
                            ? x.MaxAttachmentNumber.Value
                            : null,
                        AttachmentType = CriterionAttachmentTypeEntities
                            .Where(y => y.CriterionId == x.Id)
                            .Select(y => y.AttachmentType!.Value)
                            .ToList(),
                        AttachFilesOnSubCriterion = (x.AttachFilesOnSubCriterion != null
                            ? x.AttachFilesOnSubCriterion.Value
                            : false)
                    }).ToList();

                foreach (SubCriterionListVM SubCriterionObject in MainCriterionObject.SubCriterionListVM)
                {
                    SubCriterionObject.SubCriterionAttachments = _CriterionAttachmentRepository
                        .Where(x => x.CriterionId == SubCriterionObject.Id && x.ProvidedFormId == Request.ProvidedFormId)
                        .ToList()
                        .Select(x =>
                        {
                            return new AttachmentListVM()
                            {
                                Id = x.Id,
                                Name = x.Name,
                                Description = x.Description,
                                AttachementPath = x.AttachementPath.Contains("wwwroot")
                                    ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                    : x.AttachementPath.Replace("\\", "/"),
                                SizeOfAttachmentInKB = x.Criterion!.SizeOfAttachmentInKB,
                                IsAccept = x.IsAccepted,
                                ReasonOfReject = x.ReasonForRejecting
                            };
                        }).ToList();

                    if (SubCriterionObject.SubCriterionAttachments.Any(a => a.IsAccept == false))
                    {
                        SubCriterionObject.rejected = true;
                    }

                    if (!SubCriterionObject.AttachFilesOnSubCriterion)
                    {
                        SubCriterionObject.CriterionItemListVM = _CriterionItemRepository
                            .Where(x => x.CriterionId == SubCriterionObject.Id)
                            .AsEnumerable()
                            .OrderBy(x => x.OrderId)
                            .AsEnumerable()
                            .Select(x => new CriterionItemListVM()
                            {
                                Id = x.Id,
                                Name = Language == "ar"
                                    ? x.ArabicName
                                    : x.EnglishName,
                                SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                                MaxAttachmentNumber = x.MaxAttachmentNumber,
                                AttachmentType = CriterionItemAttachmentTypeEntities
                                    .AsEnumerable()
                                    .Where(y => y.CriterionItemId == x.Id)
                                    .AsEnumerable()
                                    .Select(y => y.AttachmentType)
                                    .ToList()
                            }).ToList();

                        foreach (CriterionItemListVM CriterionItemObject in SubCriterionObject.CriterionItemListVM)
                        {
                            CriterionItemObject.CriterionItemAttachments = _CriterionItemAttachmentRepository
                                .Where(x => x.CriterionItemId == CriterionItemObject.Id && x.ProvidedFormId == Request.ProvidedFormId)
                                .ToList()
                                .Select(x =>
                                {
                                    return new AttachmentListVM
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Description = x.Description,
                                        AttachementPath = x.AttachementPath.Contains("wwwroot")
                                            ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                            : x.AttachementPath.Replace("\\", "/"),
                                        SizeOfAttachmentInKB = x.CriterionItem!.SizeOfAttachmentInKB != null
                                            ? x.CriterionItem!.SizeOfAttachmentInKB.Value
                                            : 0,
                                        IsAccept = x.IsAccepted,
                                        ReasonOfReject = x.ReasonForRejecting
                                    };
                                }).ToList();

                            if (CriterionItemObject.CriterionItemAttachments.Any(a => a.IsAccept == false))
                            {
                                CriterionItemObject.rejected = true;
                            }
                        }

                        if (SubCriterionObject.CriterionItemListVM.Any(a => a.rejected == true))
                        {
                            SubCriterionObject.rejected = true;
                        }
                    }
                }

                if (MainCriterionObject.SubCriterionListVM.Any(s => s.rejected == true)
                    || MainCriterionObject.SubCriterionListVM.Any(s => s.CriterionItemListVM.Any(c => c.rejected == true)))
                {
                    MainCriterionObject.rejected = true;
                }

                FullObjectResponse.Add(MainCriterionObject);
            }

            return new BaseResponse<List<MainCriterionListVM>>(ResponseMessage, true, 200, FullObjectResponse);
        }
    }
}
