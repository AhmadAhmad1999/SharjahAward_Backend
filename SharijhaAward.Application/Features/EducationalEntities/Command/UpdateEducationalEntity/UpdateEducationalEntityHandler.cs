using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.UpdateEducationalEntity
{
    public class UpdateEducationalEntityHandler : IRequestHandler<UpdateEducationalEntityCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;

        public UpdateEducationalEntityHandler(IMapper Mapper,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _CategoryRepository = CategoryRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateEducationalEntityCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalEntity? EducationalEntityToUpdate = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational entity is not found"
                    : "الجهة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            EducationalEntity? CheckIfNameIsAlreadyUsed = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.ArabicName == Request.ArabicName &&
                    x.EnglishName == Request.EnglishName &&
                    x.Id != Request.Id);

            if (CheckIfNameIsAlreadyUsed is not null)
            {
                if (CheckIfNameIsAlreadyUsed.ArabicName == Request.ArabicName)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"There is already an educational entity that has the arabic name: {Request.ArabicName}"
                        : $"يوجد مسبقاً جهة تعليمية بالاسم العربي المدخل: {Request.ArabicName}";

                    return new BaseResponse<object>(ResponseMessage, true, 400);
                }
                else
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"There is already an educational entity that has the english name: {Request.EnglishName}"
                        : $"يوجد مسبقاً جهة تعليمية بالاسم الإنكليزي المدخل: {Request.EnglishName}";

                    return new BaseResponse<object>(ResponseMessage, true, 400);
                }
            }

            List<Category> AllCategoryEntitiesRelatedToEducationalEntitites = await _CategoryRepository
                .Where(x => x.RelatedToEducationalEntities &&
                    x.ParentId != null)
                .ToListAsync();

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
                    await _DynamicAttributeListValueRepository
                        .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != null
                            ? (AllCategoryEntitiesRelatedToEducationalEntitites.Select(y => y.Id).ToList()
                                .Contains(x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation!.Value) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower() &&
                                x.DynamicAttribute!.ArabicTitle == "الجهة التعليمية" && x.DynamicAttribute!.EnglishTitle == "Educational Entity" &&
                                x.ArabicValue == EducationalEntityToUpdate.ArabicName && x.EnglishValue == EducationalEntityToUpdate.EnglishName)
                            : false)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.EnglishValue, Request.EnglishName)
                            .SetProperty(y => y.ArabicValue, Request.ArabicName));

                    _Mapper.Map(Request, EducationalEntityToUpdate, typeof(UpdateEducationalEntityCommand), typeof(EducationalEntity));

                    await _EducationalEntityRepository.UpdateAsync(EducationalEntityToUpdate);

                    ResponseMessage = Request.lang == "en"
                        ? "Educational entity has been updated successfully"
                        : "تم تعديل الجهة التعليمية بنجاح";

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
