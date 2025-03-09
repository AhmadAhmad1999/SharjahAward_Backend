using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutionsByCategoryId
{
    public class GetAllEducationalInstitutionsByCategoryIdHandler 
        : IRequestHandler<GetAllEducationalInstitutionsByCategoryIdQuery, BaseResponse<List<GetAllEducationalInstitutionsByCategoryIdListVM>>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;

        public GetAllEducationalInstitutionsByCategoryIdHandler(IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository,
            IAsyncRepository<Category> _CategoryRepository,
            IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository)
        {
            this._EducationalInstitutionRepository = _EducationalInstitutionRepository;
            this._CategoryRepository = _CategoryRepository;
            this._DynamicAttributeListValueRepository = _DynamicAttributeListValueRepository;
        }

        public async Task<BaseResponse<List<GetAllEducationalInstitutionsByCategoryIdListVM>>> 
            Handle(GetAllEducationalInstitutionsByCategoryIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CategoryEntity = await _CategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

            if (CategoryEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<List<GetAllEducationalInstitutionsByCategoryIdListVM>>(ResponseMessage, false, 404);
            }

            List<EducationalInstitution> EducationalInstitutionEntities = await _EducationalInstitutionRepository
                .Where(x => x.EducationalEntity!.CycleId == CategoryEntity.CycleId &&
                    (Request.Emirates != null
                        ? x.Emirates == Request.Emirates
                        : true) &&
                    (Request.EducationType != null
                        ? x.EducationType == Request.EducationType
                        : true))
                .ToListAsync();

            List<DynamicAttributeListValue> DynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                .Where(x => x.DynamicAttribute!.EnglishLabel.ToLower() == "Educational Institution".ToLower() &&
                    x.DynamicAttribute!.ArabicLabel == "المؤسسة التعليمية" &&
                    EducationalInstitutionEntities.Select(y => y.EnglishName.ToLower()).Contains(x.EnglishValue.ToLower()) &&
                    EducationalInstitutionEntities.Select(y => y.ArabicName.ToLower()).Contains(x.ArabicValue.ToLower()))
                .ToListAsync();

            List<GetAllEducationalInstitutionsByCategoryIdListVM> Response = EducationalInstitutionEntities
                .Select(x => new GetAllEducationalInstitutionsByCategoryIdListVM()
                {
                    Id = x.Id,
                    EducationalInstitutionName = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName,
                    EducationalEntityName = Request.lang == "en"
                        ? x.EducationalEntity!.EnglishName
                        : x.EducationalEntity!.ArabicName,
                    DynamicAttributeListValueId = DynamicAttributeListValueEntities
                        .FirstOrDefault(y => y.EnglishValue.ToLower() == x.EnglishName.ToLower() &&
                            y.ArabicValue == x.ArabicName) ? .Id ?? 0
                }).ToList();

            return new BaseResponse<List<GetAllEducationalInstitutionsByCategoryIdListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
