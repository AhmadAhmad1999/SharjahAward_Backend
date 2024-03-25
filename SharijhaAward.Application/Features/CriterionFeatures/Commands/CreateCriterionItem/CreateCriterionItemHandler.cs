using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionItem
{
    public class CreateCriterionItemHandler : IRequestHandler<CreateCriterionItemCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IMapper _Mapper;
        public CreateCriterionItemHandler(IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<Criterion> CriterionRepository,
            IMapper Mapper)
        {
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionRepository = CriterionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateCriterionItemCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Criterion? CheckIfSubCriterionIdDoesExist = await _CriterionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CriterionId);

            if (CheckIfSubCriterionIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "SubCriterion is not found"
                  : "المعيار الفرعية غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            CriterionItem NewCriterionItemEntity = _Mapper.Map<CriterionItem>(Request);

            await _CriterionItemRepository.AddAsync(NewCriterionItemEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء عنصر المعيار الفرعي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
