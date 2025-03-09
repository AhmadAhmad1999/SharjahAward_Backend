using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion
{
    public class CreateCriterionHandler : IRequestHandler<CreateCriterionCommand,
        BaseResponse<int>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository;
        private readonly IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository;
        private readonly IMapper _Mapper;
        public CreateCriterionHandler(IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IAsyncRepository<Category> _CategoryRepository,
            IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository,
            IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository,
            IMapper _Mapper)
        {
            this._CriterionRepository = _CriterionRepository;
            this._CriterionItemRepository = _CriterionItemRepository;
            this._CategoryRepository = _CategoryRepository;
            this._CriterionAttachmentTypeRepository = _CriterionAttachmentTypeRepository;
            this._CriterionItemAttachmentTypeRepository = _CriterionItemAttachmentTypeRepository;
            this._Mapper = _Mapper;
        }
        public async Task<BaseResponse<int>> Handle(CreateCriterionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CheckIfCategoryIdDoesExist = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CheckIfCategoryIdDoesExist is null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Category is not Found"
                  : "الفئة الفرعية غير موجود";

                return new BaseResponse<int>(ResponseMessage, false, 404);
            }

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
                    // Create Main Criterion..
                    Criterion NewMainCriterionEntity = _Mapper.Map<Criterion>(Request);

                    int LastOrderIdForMainCriterion = await _CriterionRepository
                        .Where(x => x.CategoryId == Request.CategoryId && x.ParentId == null)
                        .OrderBy(x => x.OrderId)
                        .Select(x => x.OrderId)
                        .LastOrDefaultAsync();

                    NewMainCriterionEntity.OrderId = LastOrderIdForMainCriterion++;

                    await _CriterionRepository.AddAsync(NewMainCriterionEntity);

                    // Create Sub Criterions..
                    foreach (CreateSubCriterionDto SubCriterionDto in Request.CreateSubCriterionDto)
                    {
                        Criterion NewSubCriterionEntity = _Mapper.Map<Criterion>(SubCriterionDto);

                        NewSubCriterionEntity.ParentId = NewMainCriterionEntity.Id;
                        NewSubCriterionEntity.CategoryId = NewMainCriterionEntity.CategoryId;

                        int LastOrderIdForSubCriterion = await _CriterionRepository
                            .Where(x => x.CategoryId == Request.CategoryId && 
                                (x.ParentId != null
                                    ? x.ParentId == NewMainCriterionEntity.Id
                                    : false))
                            .OrderBy(x => x.OrderId)
                            .Select(x => x.OrderId)
                            .LastOrDefaultAsync();

                        NewSubCriterionEntity.OrderId = LastOrderIdForSubCriterion++;

                        await _CriterionRepository.AddAsync(NewSubCriterionEntity);

                        List<CriterionAttachmentType> NewCriterionAttachmentTypeEntities = SubCriterionDto
                            .AttachmentType
                            .Select(x => new CriterionAttachmentType()
                            {
                                AttachmentType = x,
                                CriterionId = NewSubCriterionEntity.Id
                            }).ToList();

                        await _CriterionAttachmentTypeRepository.AddRangeAsync(NewCriterionAttachmentTypeEntities);

                        if (SubCriterionDto.CreateCriterionItemDto is not null)
                        {
                            foreach (CreateCriterionItemDto SubCriterionItemDto in SubCriterionDto.CreateCriterionItemDto)
                            {
                                CriterionItem NewCriterionItemEntity = _Mapper.Map<CriterionItem>(SubCriterionItemDto);

                                NewCriterionItemEntity.CriterionId = NewSubCriterionEntity.Id;

                                await _CriterionItemRepository.AddAsync(NewCriterionItemEntity);

                                List<CriterionItemAttachmentType> NewCriterionItemAttachmentTypeEntities = SubCriterionItemDto
                                    .AttachmentType
                                    .Select(x => new CriterionItemAttachmentType()
                                    {
                                        AttachmentType = x,
                                        CriterionItemId = NewCriterionItemEntity.Id
                                    }).ToList();

                                await _CriterionItemAttachmentTypeRepository.AddRangeAsync(NewCriterionItemAttachmentTypeEntities);
                            }
                        }
                    }
                    
                    Transaction.Complete();
                    
                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المعيار بنجاح";

                    return new BaseResponse<int>(ResponseMessage, true, 200, NewMainCriterionEntity.Id);
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
