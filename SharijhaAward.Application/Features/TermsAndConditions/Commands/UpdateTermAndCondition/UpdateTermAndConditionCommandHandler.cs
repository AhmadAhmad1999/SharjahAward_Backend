using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.UpdateTermAndCondition
{
    public class UpdateTermAndConditionCommandHandler 
        : IRequestHandler<UpdateTermAndConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository;

        public UpdateTermAndConditionCommandHandler(IAsyncRepository<TermAndCondition> _TermAndConditionRepository, 
            IAsyncRepository<Category> _CategoryRepository, 
            IMapper _Mapper,
            IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository)
        {
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._CategoryRepository = _CategoryRepository;
            this._Mapper = _Mapper;
            this._TermAndConditionAttachmentTypeRepository = _TermAndConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateTermAndConditionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TermAndCondition? TermAndConditionEntity = await _TermAndConditionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (TermAndConditionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                   ? "Term and condition is not Found"
                   : "الشرط الخاص بالفئة غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Category? CategoryEntity = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CategoryEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                   ? "Sub Category is not found"
                   : "الفئة الفرعية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }
            
            _Mapper.Map(Request, TermAndConditionEntity, typeof(UpdateTermAndConditionCommand), typeof(TermAndCondition));

            await _TermAndConditionRepository.UpdateAsync(TermAndConditionEntity);

            List<TermAndConditionAttachmentType> TermAndConditionAttachmentTypeEntitiesToDelete = _TermAndConditionAttachmentTypeRepository
                .Where(x => x.TermAndConditionId == Request.Id)
                .ToList();

            IEnumerable<TermAndConditionAttachmentType> NewTermAndConditionAttachmentTypeEntities = Request.AttachmentType
                .Select(x => new TermAndConditionAttachmentType()
                {
                    AttachmentType = x,
                    TermAndConditionId = Request.Id
                });

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
                    if (TermAndConditionAttachmentTypeEntitiesToDelete.Any())
                        await _TermAndConditionAttachmentTypeRepository.DeleteListAsync(TermAndConditionAttachmentTypeEntitiesToDelete);

                    if (NewTermAndConditionAttachmentTypeEntities.Any())
                        await _TermAndConditionAttachmentTypeRepository.AddRangeAsync(NewTermAndConditionAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Term and condition has been updated successfully"
                        : "تم التعديل بنجاح";

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
