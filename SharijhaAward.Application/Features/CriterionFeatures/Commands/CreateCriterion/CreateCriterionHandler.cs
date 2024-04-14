using AutoMapper;
using MediatR;
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
        private readonly IMapper _Mapper;
        public CreateCriterionHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<Category> CategoryRepository,
            IMapper Mapper)
        {
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CategoryRepository = CategoryRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<int>> Handle(CreateCriterionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CheckIfCategoryIdDoesExist = await _CategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

            if (CheckIfCategoryIdDoesExist == null)
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
                    await _CriterionRepository.AddAsync(NewMainCriterionEntity);

                    // Create Sub Criterions..
                    foreach (CreateSubCriterionDto SubCriterionDto in Request.CreateSubCriterionDto)
                    {
                        Criterion NewSubCriterionEntity = _Mapper.Map<Criterion>(SubCriterionDto);

                        NewSubCriterionEntity.ParentId = NewMainCriterionEntity.Id;
                        NewSubCriterionEntity.CategoryId = NewMainCriterionEntity.CategoryId;

                        await _CriterionRepository.AddAsync(NewSubCriterionEntity);

                        if (SubCriterionDto.CreateCriterionItemDto is not null)
                        {
                            List<CriterionItem> NewCriterionItemEntities = _Mapper.Map<List<CriterionItem>>(SubCriterionDto.CreateCriterionItemDto);
                            
                            NewCriterionItemEntities.ForEach(NewCriterionItemEntity =>
                            {
                                NewCriterionItemEntity.CriterionId = NewSubCriterionEntity.Id;
                            });

                            await _CriterionItemRepository.AddRangeAsync(NewCriterionItemEntities);
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
