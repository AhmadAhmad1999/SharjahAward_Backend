using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.UpdateCriterion
{
    public class UpdateCriterionHandler : IRequestHandler<UpdateCriterionCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        public UpdateCriterionHandler(IMapper _Mapper,
            IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository,
            IAsyncRepository<Criterion> _CriterionRepository)
        {
            this._Mapper = _Mapper;
            this._CriterionAttachmentTypeRepository = _CriterionAttachmentTypeRepository;
            this._CriterionRepository = _CriterionRepository;
        }
        public async Task<BaseResponse<object>> Handle(UpdateCriterionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Criterion? CriterionEntityToUpdate = await _CriterionRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.Id);

            if (CriterionEntityToUpdate is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion is not found"
                    : "المعيار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (CriterionEntityToUpdate.ParentId is not null)
            {
                Criterion? CheckIfMainCriterionIdDoesExist = await _CriterionRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == CriterionEntityToUpdate.ParentId && x.ParentId == null);

                if (CheckIfMainCriterionIdDoesExist == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Main criterion is not found"
                        : "المعيار الرئيسي غير موجود";

                    return new BaseResponse<object>(ResponseMessage, false, 404);
                }

                int OldTotalScoreForMainCategory = _CriterionRepository
                    .Where(x => x.ParentId != null 
                        ? (x.ParentId == CheckIfMainCriterionIdDoesExist.Id && x.Id != Request.Id)
                        : false)
                    .Select(x => x.Score).Sum();

                if (OldTotalScoreForMainCategory + Request.Score > CheckIfMainCriterionIdDoesExist.Score)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"The maximum score of this main criterion : {CheckIfMainCriterionIdDoesExist.EnglishTitle} cannot be exceeded"
                        : $"لا يمكن تجاوز العلامة العظمى للمعيار الرئيسي: {CheckIfMainCriterionIdDoesExist.ArabicTitle}";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

            _Mapper.Map(Request, CriterionEntityToUpdate, typeof(UpdateCriterionCommand), typeof(Criterion));

            List<CriterionAttachmentType> CriterionAttachmentTypeEntitiesToDelete = _CriterionAttachmentTypeRepository
                .Where(x => x.CriterionId == Request.Id)
                .ToList();

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
                    await _CriterionRepository.UpdateAsync(CriterionEntityToUpdate);
                    
                    await _CriterionAttachmentTypeRepository.DeleteListAsync(CriterionAttachmentTypeEntitiesToDelete);

                    List<CriterionAttachmentType> NewCriterionAttachmentTypeEntities = Request.AttachmentType
                        .Select(x => new CriterionAttachmentType()
                        {
                            CriterionId = Request.Id,
                            AttachmentType = x
                        }).ToList();

                    await _CriterionAttachmentTypeRepository.AddRangeAsync(NewCriterionAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Criterion has been updated successfully"
                        : "تم تعديل المعيار بنجاح";

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
