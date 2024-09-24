using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllCriterionsForCoordinator
{
    public class GetAllCriterionsForCoordinatorHandler
        : IRequestHandler<GetAllCriterionsForCoordinatorQuery, BaseResponse<List<GetAllCriterionsForCoordinatorListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;

        public GetAllCriterionsForCoordinatorHandler(IMapper Mapper,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository)
        {
            _Mapper = Mapper;
            _ProvidedFormRepository = ProvidedFormRepository;
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
        }
        public async Task<BaseResponse<List<GetAllCriterionsForCoordinatorListVM>>> 
            Handle(GetAllCriterionsForCoordinatorQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            Domain.Entities.ProvidedFormModel.ProvidedForm? CheckIfFormIdIsExist = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.FormId);

            if (CheckIfFormIdIsExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Form is not found"
                    : "الاستمارة غير موجودة";

                return new BaseResponse<List<GetAllCriterionsForCoordinatorListVM>>(ResponseMessage, false, 404);
            }

            List<GetAllCriterionsForCoordinatorListVM> FullObjectResponse = new List<GetAllCriterionsForCoordinatorListVM>();

            List<Criterion> AllCriterionsEntities = await _CriterionRepository
                .Where(x => x.CategoryId == CheckIfFormIdIsExist.categoryId)
                .Include(x => x.Parent!).ToListAsync();

            List<GetAllCriterionsForCoordinatorListVM> MainCriterionObjects = AllCriterionsEntities
                .Where(x => x.ParentId == null)
                .OrderBy(x => x.OrderId)
                .Select(x => new GetAllCriterionsForCoordinatorListVM()
                {
                    Id = x.Id,
                    Title = Language == "ar"
                        ? x.ArabicTitle
                        : x.EnglishTitle,
                    OrderId = x.OrderId
                }).ToList();

            foreach (GetAllCriterionsForCoordinatorListVM MainCriterionObject in MainCriterionObjects)
            {
                MainCriterionObject.SubCriterions = AllCriterionsEntities
                    .Where(x => x.ParentId == MainCriterionObject.Id)
                    .OrderBy(x => x.OrderId)
                    .Select(x => new GetAllCriterionsForCoordinatorSubCriterion()
                    {
                        Id = x.Id,
                        Title = Language == "ar"
                            ? x.ArabicTitle
                            : x.EnglishTitle,
                        OrderId = x.OrderId,
                        AttachFilesOnSubCriterion = x.AttachFilesOnSubCriterion != null
                            ? x.AttachFilesOnSubCriterion.Value
                            : false
                    }).ToList();

                foreach (GetAllCriterionsForCoordinatorSubCriterion SubCriterionObject in MainCriterionObject.SubCriterions)
                {
                    SubCriterionObject.SubCriterionAttachments = _Mapper.Map<List<GetAllCriterionsForCoordinatorAttachment>>(_CriterionAttachmentRepository
                        .Where(x => x.CriterionId == SubCriterionObject.Id && x.ProvidedFormId == Request.FormId));

                    SubCriterionObject.SubCriterionItems = _CriterionItemRepository
                        .Where(x => x.CriterionId == SubCriterionObject.Id)
                        .OrderBy(x => x.OrderId)
                        .Select(x => new GetAllCriterionsForCoordinatorCriterionItem()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName,
                            OrderId = x.OrderId
                        }).ToList();

                    foreach (GetAllCriterionsForCoordinatorCriterionItem CriterionItemObject in SubCriterionObject.SubCriterionItems)
                    {
                        CriterionItemObject.SubCriterionItemAttachments = 
                            _Mapper.Map<List<GetAllCriterionsForCoordinatorAttachment>>(_CriterionItemAttachmentRepository
                                .Where(x => x.CriterionItemId == CriterionItemObject.Id && x.ProvidedFormId == Request.FormId));
                    }
                }

                FullObjectResponse.Add(MainCriterionObject);
            }

            return new BaseResponse<List<GetAllCriterionsForCoordinatorListVM>>(ResponseMessage, true, 200, FullObjectResponse);
        }
    }
}
