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

namespace SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity
{
    public class CreateEducationalEntityCommandHandler :
        IRequestHandler<CreateEducationalEntityCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IMapper _Mapper;

        public CreateEducationalEntityCommandHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IMapper Mapper)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _CategoryRepository = CategoryRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<int>> Handle(CreateEducationalEntityCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalEntity? CheckIfNameIsAlreadyUsed = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.ArabicName == Request.ArabicName &&
                    x.EnglishName == Request.EnglishName);

            if (CheckIfNameIsAlreadyUsed is not null)
            {
                if (CheckIfNameIsAlreadyUsed.ArabicName == Request.ArabicName)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"There is already an educational entity that has the arabic name: {Request.ArabicName}"
                        : $"يوجد مسبقاً جهة تعليمية بالاسم العربي المدخل: {Request.ArabicName}";

                    return new BaseResponse<int>(ResponseMessage, true, 400);
                }
                else
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"There is already an educational entity that has the english name: {Request.EnglishName}"
                        : $"يوجد مسبقاً جهة تعليمية بالاسم الإنكليزي المدخل: {Request.EnglishName}";

                    return new BaseResponse<int>(ResponseMessage, true, 400);
                }
            }

            List<Category> AllCategoryEntitiesRelatedToEducationalEntitites = await _CategoryRepository
                .Where(x => x.RelatedToEducationalEntities &&
                    x.ParentId != null)
                .ToListAsync();

            List<DynamicAttributeListValue> NewDynamicAttributeListValueEntities = await _DynamicAttributeRepository
                .Where(x => x.DynamicAttributeSection!.RecordIdOnRelation != null
                    ? (AllCategoryEntitiesRelatedToEducationalEntitites.Select(y => y.Id).ToList()
                        .Contains(x.DynamicAttributeSection!.RecordIdOnRelation!.Value) &&
                        x.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower() &&
                        x.ArabicTitle == "الجهة التعليمية" && x.EnglishTitle == "Educational Entity")
                    : false)
                .Select(x => new DynamicAttributeListValue()
                {
                    DynamicAttributeId = x.Id,
                    ArabicValue = Request.ArabicName,
                    EnglishValue = Request.EnglishName
                }).ToListAsync();

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
                    EducationalEntity NewEducationalEntity = _Mapper.Map<EducationalEntity>(Request);

                    await _EducationalEntityRepository.AddAsync(NewEducationalEntity);
                    await _DynamicAttributeListValueRepository.AddRangeAsync(NewDynamicAttributeListValueEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الجهة التعليمية بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<int>(ResponseMessage, true, 200, NewEducationalEntity.Id);
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
