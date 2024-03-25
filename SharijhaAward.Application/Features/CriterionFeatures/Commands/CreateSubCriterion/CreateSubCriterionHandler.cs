using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateSubCriterion
{
    public class CreateSubCriterionHandler : IRequestHandler<CreateSubCriterionCommand,
        BaseResponse<object>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IMapper _Mapper;
        public CreateSubCriterionHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<Category> CategoryRepository,
            IMapper Mapper)
        {
            _CriterionRepository = CriterionRepository;
            _CategoryRepository = CategoryRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(CreateSubCriterionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CheckIfCategoryIdDoesExist = await _CategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

            if (CheckIfCategoryIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Category is not Found"
                  : "الفئة الفرعية غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Criterion? CheckIfMainCriterionIdDoesExist = await _CriterionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ParentId && x.ParentId == null);

            if (CheckIfMainCriterionIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Main criterion is not Found"
                  : "المعيار الرئيسي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Criterion NewSubCriterionEntity = _Mapper.Map<Criterion>(Request);

            await _CriterionRepository.AddAsync(NewSubCriterionEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء المعيار الفرعي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
