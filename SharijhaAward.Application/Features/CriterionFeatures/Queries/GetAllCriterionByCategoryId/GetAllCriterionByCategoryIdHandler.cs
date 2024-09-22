using AutoMapper;
using MediatR;
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

        public GetAllCriterionByCategoryIdHandler(IMapper Mapper,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository)
        {
            _Mapper = Mapper;
            _CategoryRepository = CategoryRepository;
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
        }
        public async Task<BaseResponse<List<MainCriterionListVM>>> Handle(GetAllCriterionByCategoryIdQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            Category? CheckIfCategoryIdIsExist = await _CategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

            if (CheckIfCategoryIdIsExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجود";

                return new BaseResponse<List<MainCriterionListVM>>(ResponseMessage, false, 404);
            }

            List<MainCriterionListVM> FullObjectResponse = new List<MainCriterionListVM>();

            List<Criterion> AllCriterionsEntities = await _CriterionRepository
                .Where(x => x.CategoryId == Request.CategoryId).ToListAsync();

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
                        AttachmentType = x.AttachmentType,
                        AttachFilesOnSubCriterion = (x.AttachFilesOnSubCriterion != null
                            ? x.AttachFilesOnSubCriterion.Value
                            : false)
                    }).ToList();

                foreach (SubCriterionListVM SubCriterionObject in MainCriterionObject.SubCriterionListVM)
                {
                    if (!SubCriterionObject.AttachFilesOnSubCriterion)
                    {
                        SubCriterionObject.SubCriterionAttachments = _Mapper.Map<List<AttachmentListVM>>(_CriterionAttachmentRepository
                            .Where(x => x.CriterionId == SubCriterionObject.Id && x.ProvidedFormId == Request.ProvidedFormId));

                        if (SubCriterionObject.SubCriterionAttachments.Any(a => a.IsAccept == false))
                        {
                            SubCriterionObject.rejected = true;
                        }

                        SubCriterionObject.CriterionItemListVM = _CriterionItemRepository
                            .Where(x => x.CriterionId == SubCriterionObject.Id)
                            .OrderBy(x => x.OrderId)
                            .Select(x => new CriterionItemListVM()
                            {
                                Id = x.Id,
                                Name = Language == "ar"
                                    ? x.ArabicName
                                    : x.EnglishName,
                                SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                                MaxAttachmentNumber = x.MaxAttachmentNumber,
                                AttachmentType = x.AttachmentType

                            }).ToList();

                        foreach (CriterionItemListVM CriterionItemObject in SubCriterionObject.CriterionItemListVM)
                        {
                            CriterionItemObject.CriterionItemAttachments = _Mapper.Map<List<AttachmentListVM>>(_CriterionItemAttachmentRepository
                                .Where(x => x.CriterionItemId == CriterionItemObject.Id && x.ProvidedFormId == Request.ProvidedFormId));

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

                if(MainCriterionObject.SubCriterionListVM.Any(s=>s.rejected == true) 
                    || MainCriterionObject.SubCriterionListVM.Any(s=>s.CriterionItemListVM.Any(c=>c.rejected == true)))
                {
                    MainCriterionObject.rejected = true;
                }

                FullObjectResponse.Add(MainCriterionObject);
            }

            return new BaseResponse<List<MainCriterionListVM>>(ResponseMessage, true, 200, FullObjectResponse);
        }
    }
}
