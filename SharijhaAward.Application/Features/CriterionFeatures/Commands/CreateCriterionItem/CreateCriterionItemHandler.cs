using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CriterionId);

            if (CheckIfSubCriterionIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "SubCriterion is not found"
                  : "المعيار الفرعية غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            int OldTotalScoreForSubCategory = _CriterionItemRepository
                .Where(x => x.CriterionId == CheckIfSubCriterionIdDoesExist.Id)
                .Select(x => x.Score).Sum();

            if (OldTotalScoreForSubCategory + Request.Score > CheckIfSubCriterionIdDoesExist.Score)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"The maximum score of this sub criterion : {CheckIfSubCriterionIdDoesExist.EnglishTitle} cannot be exceeded"
                    : $"لا يمكن تجاوز العلامة العظمى للمعيار الفرعي: {CheckIfSubCriterionIdDoesExist.ArabicTitle}";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            int LastOrderIdInSection = await _CriterionItemRepository
                .Where(x => x.CriterionId == Request.CriterionId)
                .OrderBy(x => x.OrderId)
                .Select(x => x.OrderId)
                .LastOrDefaultAsync();

            CriterionItem NewCriterionItemEntity = _Mapper.Map<CriterionItem>(Request);
            NewCriterionItemEntity.OrderId = LastOrderIdInSection++;

            await _CriterionItemRepository.AddAsync(NewCriterionItemEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء عنصر المعيار الفرعي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
