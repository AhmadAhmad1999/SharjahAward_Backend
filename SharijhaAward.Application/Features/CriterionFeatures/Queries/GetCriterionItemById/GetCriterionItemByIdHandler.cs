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
        private readonly IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository;

        public GetCriterionItemByIdHandler(IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IMapper _Mapper,
            IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository)
        {
            this._CriterionItemRepository = _CriterionItemRepository;
            this._Mapper = _Mapper;
            this._CriterionItemAttachmentTypeRepository = _CriterionItemAttachmentTypeRepository;
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

            GetCriterionItemByIdDto.AttachmentType = _CriterionItemAttachmentTypeRepository
                .Where(x => x.CriterionItemId == Request.Id)
                .Select(x => x.AttachmentType)
                .ToList();

            return new BaseResponse<GetCriterionItemByIdDto>(ResponseMessage, true, 200, GetCriterionItemByIdDto);
        }
    }
}
