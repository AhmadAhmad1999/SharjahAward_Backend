using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.CreateTermAndCondition
{
    public class CreateTermAndConditionCommandHandler 
        : IRequestHandler<CreateTermAndConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository;
        private readonly IMapper _Mapper;

        public CreateTermAndConditionCommandHandler(IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IAsyncRepository<Category> _CategoryRepository, 
            IMapper _Mapper,
            IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository)
        {
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._CategoryRepository = _CategoryRepository;
            this._Mapper = _Mapper;
            this._TermAndConditionAttachmentTypeRepository = _TermAndConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateTermAndConditionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CategoryEntity = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CategoryEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Sub category is not found"
                    : "الفئة الفرعية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            TermAndCondition NewTermAndConditionEntity = _Mapper.Map<TermAndCondition>(Request);

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _TermAndConditionRepository.AddAsync(NewTermAndConditionEntity);

                    IEnumerable<TermAndConditionAttachmentType> NewTermAndConditionAttachmentTypeEntities = Request.AttachmentType
                        .Select(x => new TermAndConditionAttachmentType()
                        {
                            TermAndConditionId = NewTermAndConditionEntity.Id,
                            AttachmentType = x
                        });

                    await _TermAndConditionAttachmentTypeRepository.AddRangeAsync(NewTermAndConditionAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                       ? "Created successfully"
                       : "تم إنشاء الشرط الخاص بالفئة بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
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
