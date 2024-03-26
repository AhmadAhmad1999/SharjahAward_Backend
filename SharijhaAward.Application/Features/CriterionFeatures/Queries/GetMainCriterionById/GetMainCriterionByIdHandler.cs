using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetMainCriterionById
{
    public class GetMainCriterionByIdHandler : IRequestHandler<GetMainCriterionByIdQuery, BaseResponse<GetMainCriterionByIdDto>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IMapper _Mapper;

        public GetMainCriterionByIdHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IMapper Mapper)
        {
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetMainCriterionByIdDto>> Handle(GetMainCriterionByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Criterion? CriterionEntity = await _CriterionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CriterionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Main criterion is not found"
                    : "المعيار الرئيسي غير موجود";

                return new BaseResponse<GetMainCriterionByIdDto>(ResponseMessage, false, 404);
            }

            GetMainCriterionByIdDto GetMainCriterionByIdDto = _Mapper.Map<GetMainCriterionByIdDto>(CriterionEntity);

            GetMainCriterionByIdDto.SubCriterions = _Mapper.Map<List<SubCriterionListDto>>(await _CriterionRepository
                .Where(x => x.ParentId == Request.Id)
                .ToListAsync());

            foreach (SubCriterionListDto SubCriterion in GetMainCriterionByIdDto.SubCriterions)
            {
                SubCriterion.CriterionItems = _Mapper.Map<List<CriterionItemListDto>>(await _CriterionItemRepository
                    .Where(x => x.CriterionId == SubCriterion.Id)
                    .ToListAsync());
            }

            return new BaseResponse<GetMainCriterionByIdDto>(ResponseMessage, true, 200, GetMainCriterionByIdDto);
        }
    }
}
