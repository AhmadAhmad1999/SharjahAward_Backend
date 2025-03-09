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

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.UpdateEducationalInstitutions
{
    public class UpdateEducationalInstitutionsHandler 
        : IRequestHandler<UpdateEducationalInstitutionsMainCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;

        public UpdateEducationalInstitutionsHandler(IMapper _Mapper,
            IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository,
            IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository,
            IAsyncRepository<EducationalEntity> _EducationalEntityRepository)
        {
            this._Mapper = _Mapper;
            this._EducationalInstitutionRepository = _EducationalInstitutionRepository;
            _CategoryRepository = CategoryRepository;
            this._DynamicAttributeListValueRepository = _DynamicAttributeListValueRepository;
            this._DynamicAttributeRepository = _DynamicAttributeRepository;
            this._EducationalEntityRepository = _EducationalEntityRepository;
        }
        public async Task<BaseResponse<object>> Handle(UpdateEducationalInstitutionsMainCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            
            List<EducationalInstitution>? EducationalInstitutionEntitiesToUpdate = await _EducationalInstitutionRepository
                .Where(x => Request.UpdateEducationalInstitutionsCommand.Select(y => y.Id).Contains(x.Id))
                .ToListAsync();

            EducationalEntity? EducationalEntityToUpdate = null;

            if (EducationalInstitutionEntitiesToUpdate.Any())
            {
                EducationalEntityToUpdate = await _EducationalEntityRepository
                    .FirstOrDefaultAsync(x => x.Id == EducationalInstitutionEntitiesToUpdate.FirstOrDefault()!.EducationalEntityId);

                if (EducationalEntityToUpdate == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Educational entity is not found"
                        : "الجهة التعليمية غير موجودة";

                    return new BaseResponse<object>(ResponseMessage, false, 404);
                }

                EducationalInstitution? CheckIfNameIsAlreadyUsed = await _EducationalInstitutionRepository
                    .FirstOrDefaultAsync(x => (Request.UpdateEducationalInstitutionsCommand.Select(y => y.ArabicName.ToLower()).Contains(x.ArabicName.ToLower()) ||
                        Request.UpdateEducationalInstitutionsCommand.Select(y => y.EnglishName.ToLower()).Contains(x.EnglishName.ToLower())) &&
                        !Request.UpdateEducationalInstitutionsCommand.Select(y => y.Id).Contains(x.Id) &&
                        EducationalEntityToUpdate.Id == x.EducationalEntityId);

                if (CheckIfNameIsAlreadyUsed is not null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"There is already an educational institution with the same name as the one inserted"
                        : $"يوجد مسبقاً مؤسسة تعليمية بالاسم المدخل";

                    return new BaseResponse<object>(ResponseMessage, true, 400);
                }
            }

            IGrouping<string, string>? HasDuplicateArabicNames = Request.UpdateEducationalInstitutionsCommand
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

            IGrouping<string, string>? HasDuplicateEnglishNames = Request.UpdateEducationalInstitutionsCommand
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
            
            List<Category> AllCategoryEntitiesRelatedToEducationalEntitites = new List<Category>();

            if (EducationalEntityToUpdate is not null)
            {
                AllCategoryEntitiesRelatedToEducationalEntitites = await _CategoryRepository
                    .Where(x => x.RelatedToEducationalEntities &&
                        x.ParentId != null &&
                        x.CycleId == EducationalEntityToUpdate.CycleId)
                    .ToListAsync();
            }

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
                    foreach (EducationalInstitution EducationalInstitutionEntityToUpdate in EducationalInstitutionEntitiesToUpdate)
                    {
                        UpdateEducationalInstitutionsCommand NewRequestData = Request.UpdateEducationalInstitutionsCommand
                            .FirstOrDefault(x => x.Id == EducationalInstitutionEntityToUpdate.Id)!;

                        _Mapper.Map(NewRequestData, EducationalInstitutionEntityToUpdate, typeof(UpdateEducationalInstitutionsCommand), typeof(EducationalInstitution));

                        await _DynamicAttributeListValueRepository
                            .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation != null
                                ? (AllCategoryEntitiesRelatedToEducationalEntitites.Select(y => y.Id).ToList()
                                    .Contains(x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation!.Value) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower() &&
                                    x.DynamicAttribute!.ArabicTitle == "المؤسسة التعليمية" &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Educational Institution".ToLower() &&
                                    x.ArabicValue == EducationalInstitutionEntityToUpdate.ArabicName &&
                                    x.EnglishValue.ToLower() == EducationalInstitutionEntityToUpdate.EnglishName.ToLower())
                                : false)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.EnglishValue, NewRequestData.EnglishName)
                                .SetProperty(y => y.ArabicValue, NewRequestData.ArabicName));
                    }

                    await _EducationalInstitutionRepository.UpdateListAsync(EducationalInstitutionEntitiesToUpdate);

                    ResponseMessage = Request.lang == "en"
                        ? "Educational institutions has been updated successfully"
                        : "تم تعديل المؤسسات التعليمية بنجاح";

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