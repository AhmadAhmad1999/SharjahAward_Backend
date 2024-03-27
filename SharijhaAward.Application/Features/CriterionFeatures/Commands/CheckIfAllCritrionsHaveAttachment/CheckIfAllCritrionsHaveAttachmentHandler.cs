using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CheckIfAllCritrionsHaveAttachment
{
    public class CheckIfAllCritrionsHaveAttachmentHandler : IRequestHandler<CheckIfAllCritrionsHaveAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        public CheckIfAllCritrionsHaveAttachmentHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository)
        {
            _CriterionRepository = CriterionRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
        }
        public async Task<BaseResponse<object>> Handle(CheckIfAllCritrionsHaveAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Criterion> SubCriterionEntities = await _CriterionRepository
                .Where(x => x.CategoryId == Request.CategoryId &&
                    x.ParentId != null).ToListAsync();

            List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId)).ToListAsync();

            List<Criterion> SubCriterionEntitiesWithNoItems = SubCriterionEntities
                .Where(x => !CriterionItemEntities.Select(y => y.CriterionId).Contains(x.Id)).ToList();

            List<CriterionAttachment> InsertedSubCriterionAttachment = await _CriterionAttachmentRepository
                .Include(x => x.Criterion!)
                .Where(x => x.Criterion!.CategoryId == Request.CategoryId)
                .Include(x => x.Criterion)
                .ToListAsync();

            List<Criterion> CriterionEntitiesWithNoAttachments = SubCriterionEntitiesWithNoItems
                .Where(x => !InsertedSubCriterionAttachment.Select(y => y.CriterionId).Contains(x.Id)).ToList();

            if (CriterionEntitiesWithNoAttachments.Count() > 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"You have to attach one file at least to this criterion: {CriterionEntitiesWithNoAttachments[0].EnglishTitle}"
                    : $"يجب أن يتم إدخال ملحق واحد على الأقل للمعيار: {CriterionEntitiesWithNoAttachments[0].ArabicTitle}";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            List<CriterionItemAttachment> InsertedCriterionItemAttachment = await _CriterionItemAttachmentRepository
                .Include(x => x.CriterionItem!).Include(x => x.CriterionItem!.Criterion!)
                .Where(x => x.CriterionItem!.Criterion!.CategoryId == Request.CategoryId)
                .ToListAsync();

            List<CriterionItem> CriterionItemEntitiesWithNoAttachments = CriterionItemEntities
                .Where(x => !InsertedCriterionItemAttachment.Select(y => y.CriterionItemId).Contains(x.Id)).ToList();

            if (CriterionItemEntitiesWithNoAttachments.Count() > 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"You have to attach one file at least to this criterion item: {CriterionItemEntitiesWithNoAttachments[0].EnglishName}"
                    : $"يجب أن يتم إدخال ملحق واحد على الأقل لعنصر المعيار: {CriterionItemEntitiesWithNoAttachments[0].ArabicName}";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
