using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution
{
    public class CreateEducationalInstitutionCommandHandler
        : IRequestHandler<CreateEducationalInstitutionMainCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;

        public CreateEducationalInstitutionCommandHandler(IMapper _Mapper,
            IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository,
            IAsyncRepository<EducationalEntity> _EducationalEntityRepository,
            IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository,
            IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository,
            IAsyncRepository<Category> _CategoryRepository)
        {
            this._Mapper = _Mapper;
            this._EducationalInstitutionRepository = _EducationalInstitutionRepository;
            this._EducationalEntityRepository = _EducationalEntityRepository;
            this._DynamicAttributeListValueRepository = _DynamicAttributeListValueRepository;
            this._DynamicAttributeRepository = _DynamicAttributeRepository;
            this._CategoryRepository = _CategoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateEducationalInstitutionMainCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalEntity? EducationalEntity = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.Id == Request.EducationalEntityId);
           
            if (EducationalEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational entity dose not Exist"
                    : "الجهة التعليمية غير موجودة";
                
                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            EducationalInstitution? CheckIfNameIsAlreadyUsed = await _EducationalInstitutionRepository
                .FirstOrDefaultAsync(x => (Request.CreateEducationalInstitutionCommand.Select(y => y.ArabicName.ToLower()).Contains(x.ArabicName.ToLower()) ||
                    Request.CreateEducationalInstitutionCommand.Select(y => y.EnglishName.ToLower()).Contains(x.EnglishName.ToLower())) &&
                    x.EducationalEntityId == Request.EducationalEntityId);

            if (CheckIfNameIsAlreadyUsed is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"There is already an educational institution with the same name as the one inserted"
                    : $"يوجد مسبقاً مؤسسة تعليمية بالاسم المدخل";

                return new BaseResponse<object>(ResponseMessage, true, 400);
            }

            IGrouping<string, string>? HasDuplicateArabicNames = Request.CreateEducationalInstitutionCommand
                .Select(x => x.ArabicName.ToLower())
                .GroupBy(x => x)
                .FirstOrDefault(x => x.Count() > 1);

            if (HasDuplicateArabicNames is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"You can't insert the same educational institution arabic name more than once: {HasDuplicateArabicNames.Key}"
                    : $"لا يمكنك إدخال نفس الاسم باللغة العربية لأكثر من مؤسسة تعليمية واحدة";

                return new BaseResponse<object>(ResponseMessage, true, 400);
            }

            IGrouping<string, string>? HasDuplicateEnglishNames = Request.CreateEducationalInstitutionCommand
                .Select(x => x.EnglishName.ToLower())
                .GroupBy(x => x)
                .FirstOrDefault(x => x.Count() > 1);

            if (HasDuplicateEnglishNames is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"You can't insert the same educational institution english name more than once: {HasDuplicateEnglishNames.Key}"
                    : $"لا يمكنك إدخال نفس الاسم باللغة الإنكليزية لأكثر من مؤسسة تعليمية واحدة";

                return new BaseResponse<object>(ResponseMessage, true, 400);
            }

            List<EducationalInstitution> NewEducationalInstitutionEntities = _Mapper.Map<List<EducationalInstitution>>
                (Request.CreateEducationalInstitutionCommand);

            foreach (EducationalInstitution NewEducationalInstitutionEntity in NewEducationalInstitutionEntities)
            {
                NewEducationalInstitutionEntity.EducationalEntityId = EducationalEntity.Id;
            }

            List<Category> AllCategoryEntitiesRelatedToEducationalEntitites = await _CategoryRepository
                .Where(x => x.RelatedToEducationalEntities &&
                    x.ParentId != null &&
                    EducationalEntity.CycleId == x.CycleId)
                .ToListAsync();

            DynamicAttribute? NewDynamicAttributeEntities = await _DynamicAttributeRepository
                .FirstOrDefaultAsync(x => x.DynamicAttributeSection!.RecordIdOnRelation != null
                    ? (AllCategoryEntitiesRelatedToEducationalEntitites.Select(y => y.Id).ToList()
                        .Contains(x.DynamicAttributeSection!.RecordIdOnRelation!.Value) &&
                        x.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower() &&
                        x.ArabicTitle == "المؤسسة التعليمية" && x.EnglishTitle.ToLower() == "Educational Institution".ToLower())
                    : false);

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
                    if (NewDynamicAttributeEntities is not null)
                    {
                        List<DynamicAttributeListValue> NewDynamicAttributeListValueEntities = Request
                            .CreateEducationalInstitutionCommand
                            .Select(x => new DynamicAttributeListValue()
                            {
                                DynamicAttributeId = NewDynamicAttributeEntities.Id,
                                ArabicValue = x.ArabicName,
                                EnglishValue = x.EnglishName
                            }).ToList();

                        await _DynamicAttributeListValueRepository.AddRangeAsync(NewDynamicAttributeListValueEntities);
                    }

                    await _EducationalInstitutionRepository.AddRangeAsync(NewEducationalInstitutionEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Created Successfuly"
                        : "تم إنشاء المؤسسات التعليمية بنجاح";

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
