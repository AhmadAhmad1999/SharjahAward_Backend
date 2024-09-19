using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorClass
{
    public class CreateArbitratorClassHandler : IRequestHandler<CreateArbitratorClassCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CateogryEducationalClassRepository;

        public CreateArbitratorClassHandler(IAsyncRepository<ArbitratorClass> ArbitratorClassRepository,
             IAsyncRepository<Arbitrator> ArbitratorRepository,
             IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository)
        {
            _ArbitratorClassRepository = ArbitratorClassRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _CateogryEducationalClassRepository = CategoryEducationalClassRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateArbitratorClassCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? CheckIfArbitratorIdIsExist = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitratorId);

            if (CheckIfArbitratorIdIsExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not found"
                    : "المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            CategoryEducationalClass? CheckIfCategoryEducationalClassIdIsExist = await _CateogryEducationalClassRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryEducationalClassId);

            if (CheckIfCategoryEducationalClassIdIsExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category class is not found"
                    : "الصف ضمن الفئة غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            ArbitratorClass? CheckIfArbitratorDoesConnectWithClass = await _ArbitratorClassRepository
                .FirstOrDefaultAsync(x => x.ArbitratorId == CheckIfArbitratorIdIsExist.Id &&
                    x.CategoryEducationalClassId == CheckIfCategoryEducationalClassIdIsExist.Id);

            if (CheckIfArbitratorDoesConnectWithClass is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This arbitrator is already arbitrating on this class"
                    : "هذا المحكم يحكم مسبقاً على هذا الصف";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            ArbitratorClass NewArbitratorClassEntity = new ArbitratorClass()
            {
                isDeleted = false,
                DeletedAt = null,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                ArbitratorId = CheckIfArbitratorIdIsExist.Id,
                CategoryEducationalClassId = CheckIfCategoryEducationalClassIdIsExist.Id
            };

            await _ArbitratorClassRepository.AddAsync(NewArbitratorClassEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم ربط المحكم بالصف بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
