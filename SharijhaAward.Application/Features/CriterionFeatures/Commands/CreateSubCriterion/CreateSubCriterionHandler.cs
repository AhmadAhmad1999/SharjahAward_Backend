﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateSubCriterion
{
    public class CreateSubCriterionHandler : IRequestHandler<CreateSubCriterionCommand,
        BaseResponse<int>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository;
        private readonly IMapper _Mapper;
        public CreateSubCriterionHandler(IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository,
            IMapper _Mapper)
        {
            this._CriterionRepository = _CriterionRepository;
            this._CriterionAttachmentTypeRepository = _CriterionAttachmentTypeRepository;
            this._Mapper = _Mapper;
        }
        public async Task<BaseResponse<int>> Handle(CreateSubCriterionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Criterion? CheckIfMainCriterionIdDoesExist = await _CriterionRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.ParentId && x.ParentId == null);

            if (CheckIfMainCriterionIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Main criterion is not found"
                    : "المعيار الرئيسي غير موجود";

                return new BaseResponse<int>(ResponseMessage, false, 404);
            }

            int OldTotalScoreForMainCategory = _CriterionRepository
                .Where(x => x.ParentId != null ? x.ParentId == CheckIfMainCriterionIdDoesExist.Id : false)
                .Select(x => x.Score).Sum();

            if (OldTotalScoreForMainCategory + Request.Score > CheckIfMainCriterionIdDoesExist.Score)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"The maximum score of this main criterion : {CheckIfMainCriterionIdDoesExist.EnglishTitle} cannot be exceeded"
                    : $"لا يمكن تجاوز العلامة العظمى للمعيار الرئيسي: {CheckIfMainCriterionIdDoesExist.ArabicTitle}";

                return new BaseResponse<int>(ResponseMessage, false, 400);
            }

            Criterion NewSubCriterionEntity = _Mapper.Map<Criterion>(Request);
            NewSubCriterionEntity.CategoryId = CheckIfMainCriterionIdDoesExist.CategoryId;

            int LastOrderIdForSubCriterion = await _CriterionRepository
                .Where(x => x.CategoryId == CheckIfMainCriterionIdDoesExist.CategoryId &&
                    (x.ParentId != null
                        ? x.ParentId == CheckIfMainCriterionIdDoesExist.Id
                        : false))
                .OrderBy(x => x.OrderId)
                .Select(x => x.OrderId)
                .LastOrDefaultAsync();

            NewSubCriterionEntity.OrderId = LastOrderIdForSubCriterion++;

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromSeconds(30)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _CriterionRepository.AddAsync(NewSubCriterionEntity);

                    List<CriterionAttachmentType> NewCriterionAttachmentTypeEntities = Request
                        .AttachmentType
                        .Select(x => new CriterionAttachmentType()
                        {
                            AttachmentType = x,
                            CriterionId = NewSubCriterionEntity.Id
                        }).ToList();

                    await _CriterionAttachmentTypeRepository.AddRangeAsync(NewCriterionAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المعيار الفرعي بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<int>(ResponseMessage, true, 200, NewSubCriterionEntity.Id);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
