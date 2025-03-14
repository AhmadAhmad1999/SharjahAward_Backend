﻿using MediatR;
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

            List<Criterion> MainCriterionEntities = await _CriterionRepository
                .Where(x => x.CategoryId == Request.CategoryId &&
                    x.ParentId == null).ToListAsync();

            List<Criterion> SubCriterionEntities = await _CriterionRepository
                .Where(x => x.CategoryId == Request.CategoryId &&
                    x.ParentId != null &&
                    MainCriterionEntities.Select(y => y.Id).Any(y => y == x.ParentId))
                .Include(x => x.Parent!).ToListAsync();

            List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId) &&
                    x.Criterion!.AttachFilesOnSubCriterion == false).ToListAsync();

            List<Criterion> SubCriterionEntitiesWithNoItems = SubCriterionEntities
                .Where(x => !CriterionItemEntities.Select(y => y.CriterionId).Contains(x.Id)).ToList();

            List<CriterionAttachment> InsertedSubCriterionAttachment = await _CriterionAttachmentRepository
                .Where(x => x.Criterion!.CategoryId == Request.CategoryId &&
                    x.ProvidedFormId == Request.ProvidedFormId)
                .ToListAsync();

            List<Criterion> CriterionEntitiesWithNoAttachments = SubCriterionEntitiesWithNoItems
                .Where(x => !InsertedSubCriterionAttachment.Select(y => y.CriterionId).Contains(x.Id) &&
                    x.AttachFilesOnSubCriterion == true).ToList();

            if (CriterionEntitiesWithNoAttachments.Any())
            {
                ResponseMessage = Request.lang == "en"
                    ? $"You have to attach one file at least to this criterion: {CriterionEntitiesWithNoAttachments[0].EnglishTitle}"
                    : $"يجب أن يتم إدخال ملحق واحد على الأقل للمعيار: {CriterionEntitiesWithNoAttachments[0].ArabicTitle}";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            if (InsertedSubCriterionAttachment.Any()
                ? InsertedSubCriterionAttachment.FirstOrDefault()!.Criterion!.MaxAttachmentNumber != 0
                : false)
            {
                IGrouping<int, CriterionAttachment>? CheckMaxAttachment = InsertedSubCriterionAttachment
                    .GroupBy(x => x.CriterionId)
                    .FirstOrDefault(x => x.ToList().FirstOrDefault()!.Criterion!.MaxAttachmentNumber < x.Count());

                if (CheckMaxAttachment is not null
                    ? CheckMaxAttachment.Any()
                    : false)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You can't attach more than {CheckMaxAttachment.FirstOrDefault()!.Criterion!.MaxAttachmentNumber}" +
                            $" files to this criterion: {CriterionEntitiesWithNoAttachments[0].EnglishTitle}"
                        : $"لا يمكن أن يتم إدخال أكثر من {CheckMaxAttachment.FirstOrDefault()!.Criterion!.MaxAttachmentNumber}ملحق للمعيار: {CriterionEntitiesWithNoAttachments[0].ArabicTitle}";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

            if (CriterionItemEntities.Any())
            {
                List<CriterionItemAttachment> InsertedCriterionItemAttachment = await _CriterionItemAttachmentRepository
                    .Where(x => x.CriterionItem!.Criterion!.CategoryId == Request.CategoryId &&
                        x.ProvidedFormId == Request.ProvidedFormId)
                    .ToListAsync();

                List<CriterionItem> CriterionItemEntitiesWithNoAttachments = CriterionItemEntities
                    .Where(x => !InsertedCriterionItemAttachment.Select(y => y.CriterionItemId).Contains(x.Id) &&
                        x.Criterion!.AttachFilesOnSubCriterion == false).ToList();

                if (CriterionItemEntitiesWithNoAttachments.Any())
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You have to attach one file at least to this criterion item: {CriterionItemEntitiesWithNoAttachments[0].EnglishName}"
                        : $"يجب أن يتم إدخال ملحق واحد على الأقل لعنصر المعيار: {CriterionItemEntitiesWithNoAttachments[0].ArabicName}";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }

                if (InsertedCriterionItemAttachment.Any()
                    ? InsertedCriterionItemAttachment.FirstOrDefault()!.CriterionItem!.MaxAttachmentNumber != 0
                    : false)
                {
                    IGrouping<int, CriterionItemAttachment>? CheckMaxAttachment = InsertedCriterionItemAttachment
                        .GroupBy(x => x.CriterionItemId)
                        .FirstOrDefault(x => x.ToList().FirstOrDefault()!.CriterionItem!.MaxAttachmentNumber < x.Count());

                    if (CheckMaxAttachment is not null
                        ? CheckMaxAttachment.Any()
                        : false)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? $"You can't attach more than {CheckMaxAttachment.FirstOrDefault()!.CriterionItem!.MaxAttachmentNumber}" +
                                $" files to this criterion item: {CriterionItemEntitiesWithNoAttachments[0].EnglishName}"
                            : $"لا يمكن أن يتم إدخال أكثر من {CheckMaxAttachment.FirstOrDefault()!.CriterionItem!.MaxAttachmentNumber}ملحق لعنصر المعيار: {CriterionItemEntitiesWithNoAttachments[0].ArabicName}";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }
                }
            }

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
