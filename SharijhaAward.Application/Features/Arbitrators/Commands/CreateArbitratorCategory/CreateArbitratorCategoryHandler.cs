using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorCategory
{
    public class CreateArbitratorCategoryHandler : IRequestHandler<CreateArbitratorCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;

        public CreateArbitratorCategoryHandler(IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
             IAsyncRepository<Arbitrator> ArbitratorRepository,
             IAsyncRepository<Category> CategoryRepository)
        {
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryRepository = CategoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateArbitratorCategoryCommand Request, CancellationToken cancellationToken)
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

            Category? CheckIfCategoryIdIsExist = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.ArbitratorId);

            if (CheckIfCategoryIdIsExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            CategoryArbitrator? CheckIfArbitratorDoesConnectWithCategory = await _CategoryArbitratorRepository
                .FirstOrDefaultAsync(x => x.ArbitratorId == CheckIfArbitratorIdIsExist.Id &&
                    x.CategoryId == CheckIfCategoryIdIsExist.Id);

            if (CheckIfArbitratorDoesConnectWithCategory is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This arbitrator is already arbitrating on this category"
                    : "هذا المحكم يحكم مسبقاً على هذه الفئة";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            CategoryArbitrator NewCategoryArbitratorEntity = new CategoryArbitrator()
            {
                isDeleted = false,
                DeletedAt = null,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                ArbitratorId = CheckIfArbitratorIdIsExist.Id,
                CategoryId = CheckIfCategoryIdIsExist.Id
            };

            await _CategoryArbitratorRepository.AddAsync(NewCategoryArbitratorEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم ربط المحكم بالفئة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
