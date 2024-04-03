using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetCriterionItemById
{
    public class GetCriterionItemByIdHandler : IRequestHandler<GetCriterionItemByIdQuery, BaseResponse<GetCriterionItemByIdDto>>
    {
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IMapper _Mapper;

        public GetCriterionItemByIdHandler(IAsyncRepository<CriterionItem> CriterionItemRepository,
            IMapper Mapper)
        {
            _CriterionItemRepository = CriterionItemRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetCriterionItemByIdDto>> Handle(GetCriterionItemByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CriterionItem? CriterionItemEntity = await _CriterionItemRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CriterionItemEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion item is not found"
                    : "عنصر المعيار الفرعي غير موجود";

                return new BaseResponse<GetCriterionItemByIdDto>(ResponseMessage, false, 404);
            }

            GetCriterionItemByIdDto GetCriterionItemByIdDto = _Mapper.Map<GetCriterionItemByIdDto>(CriterionItemEntity);

            return new BaseResponse<GetCriterionItemByIdDto>(ResponseMessage, true, 200, GetCriterionItemByIdDto);
        }
    }
}
