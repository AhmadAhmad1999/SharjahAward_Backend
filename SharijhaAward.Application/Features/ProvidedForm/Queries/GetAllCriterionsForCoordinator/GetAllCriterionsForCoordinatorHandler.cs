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
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;

        public GetAllCriterionsForCoordinatorHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository)
        {
            _CriterionRepository = CriterionRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
        }
        public async Task<BaseResponse<List<GetAllCriterionsForCoordinatorListVM>>> 
            Handle(GetAllCriterionsForCoordinatorQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            // Step 3.2..

            List<CriterionAttachment> CriterionAttachmentEntities = await _CriterionAttachmentRepository
                .Where(x => x.ProvidedFormId == Request.FormId)
                .Include(x => x.Criterion!)
                .Include(x => x.Criterion!.Parent!)
                .ToListAsync();

            // Step 4..

            List<CriterionItemAttachment> CriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                .Where(x => x.ProvidedFormId == Request.FormId)
                .Include(x => x.CriterionItem!)
                .Include(x => x.CriterionItem!.Criterion!)
                .Include(x => x.CriterionItem!.Criterion!.Parent!)
                .ToListAsync();

            // Step 1..

            List<Criterion> MainCriterionEntities = CriterionAttachmentEntities
                .Where(x => x.Criterion!.ParentId == null)
                .Select(x => x.Criterion!.Parent!)
                .Union(CriterionItemAttachmentEntities
                    .Where(x => x.CriterionItem!.Criterion!.ParentId == null)
                    .Select(x => x.CriterionItem!.Criterion!))
                .OrderBy(x => x.OrderId)
                .ToList();

            // Step 2..

            List<Criterion> SubCriterionEntities = CriterionAttachmentEntities
                .Where(x => x.Criterion!.ParentId != null)
                .Select(x => x.Criterion!.Parent!)
                .Union(CriterionItemAttachmentEntities
                    .Where(x => x.CriterionItem!.Criterion!.ParentId != null)
                    .Select(x => x.CriterionItem!.Criterion!))
                .OrderBy(x => x.OrderId)
                .ToList();

            // Step 3.1..

            List<CriterionItem> CriterionItemEntities = CriterionItemAttachmentEntities
                .Select(x => x.CriterionItem!)
                .OrderBy(x => x.OrderId)
                .ToList();

            List<GetAllCriterionsForCoordinatorListVM> Response = new List<GetAllCriterionsForCoordinatorListVM>();

            foreach (Criterion MainCriterionEntity in MainCriterionEntities)
            {
                GetAllCriterionsForCoordinatorListVM MainCriterionDto = new GetAllCriterionsForCoordinatorListVM()
                {
                    Id = MainCriterionEntity.Id,
                    OrderId = MainCriterionEntity.OrderId,
                    Title = Request.lang == "en"
                        ? MainCriterionEntity.EnglishTitle
                        : MainCriterionEntity.ArabicTitle
                };

                List<Criterion> SubCriterionEntitiesForThisMainCriterion = SubCriterionEntities
                    .Where(x => x.ParentId == MainCriterionDto.Id)
                    .ToList();

                foreach (Criterion SubCriterionEntityForThisMainCriterion in SubCriterionEntitiesForThisMainCriterion)
                {
                    GetAllCriterionsForCoordinatorSubCriterion SubCriterionDto = new GetAllCriterionsForCoordinatorSubCriterion()
                    {
                        Id = SubCriterionEntityForThisMainCriterion.Id,
                        OrderId = SubCriterionEntityForThisMainCriterion.OrderId,
                        Title = Request.lang == "en"
                            ? SubCriterionEntityForThisMainCriterion.EnglishTitle
                            : SubCriterionEntityForThisMainCriterion.ArabicTitle
                    };

                    List<CriterionItem> CriterionItemEntitiesForThisSubCriterion = CriterionItemEntities
                        .Where(x => x.CriterionId == SubCriterionDto.Id)
                        .ToList();

                    if (CriterionItemEntitiesForThisSubCriterion.Any())
                    {
                        foreach (CriterionItem CriterionItemEntityForThisSubCriterion in CriterionItemEntitiesForThisSubCriterion)
                        {
                            GetAllCriterionsForCoordinatorCriterionItem CriterionItemDto = new GetAllCriterionsForCoordinatorCriterionItem()
                            {
                                Id = CriterionItemEntityForThisSubCriterion.Id,
                                OrderId = CriterionItemEntityForThisSubCriterion.OrderId,
                                Name = Request.lang == "en"
                                    ? CriterionItemEntityForThisSubCriterion.EnglishName
                                    : CriterionItemEntityForThisSubCriterion.ArabicName,
                                GetAllCriterionsForCoordinatorAttachment = CriterionItemAttachmentEntities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id)
                                    .Select(x => new GetAllCriterionsForCoordinatorAttachment()
                                    {
                                        Id = x.CriterionItemId,
                                        AttachementPath = x.AttachementPath,
                                        Description = x.Description,
                                        Name = x.Name
                                    }).ToList()
                            };

                            SubCriterionDto.GetAllCriterionsForCoordinatorCriterionItem.Add(CriterionItemDto);
                        }
                    }
                    else
                    {
                        SubCriterionDto.GetAllCriterionsForCoordinatorAttachment = CriterionAttachmentEntities
                            .Where(x => x.CriterionId == SubCriterionDto.Id)
                            .Select(x => new GetAllCriterionsForCoordinatorAttachment()
                            {
                                Id = x.CriterionId,
                                AttachementPath = x.AttachementPath,
                                Description = x.Description,
                                Name = x.Name
                            }).ToList();
                    }

                    MainCriterionDto.GetAllCriterionsForCoordinatorSubCriterion.Add(SubCriterionDto);
                }

                Response.Add(MainCriterionDto);
            }

            return new BaseResponse<List<GetAllCriterionsForCoordinatorListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
