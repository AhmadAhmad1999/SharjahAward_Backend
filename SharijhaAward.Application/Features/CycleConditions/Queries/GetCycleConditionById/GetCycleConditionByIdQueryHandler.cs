using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById
{
    public class GetCycleConditionByIdQueryHandler
        : IRequestHandler<GetCycleConditionByIdQuery, BaseResponse<CycleConditionDto>>
    {
        private readonly IAsyncRepository<CycleCondition> _CycleConditionRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository;

        public GetCycleConditionByIdQueryHandler(IAsyncRepository<CycleCondition> _CycleConditionRepository,
            IMapper _Mapper,
            IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository)
        {
            this._CycleConditionRepository = _CycleConditionRepository;
            this._Mapper = _Mapper;
            this._CycleConditionAttachmentTypeRepository = _CycleConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<CycleConditionDto>> Handle(GetCycleConditionByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CycleCondition? CycleConditionEntity = await _CycleConditionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id); 
            
            if (CycleConditionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Cycle condition is not found"
                    : "شرط الدورة غير موجود";

                return new BaseResponse<CycleConditionDto>(ResponseMessage, false, 404);
            }

            CycleConditionDto Response = _Mapper.Map<CycleConditionDto>(CycleConditionEntity);

            Response.AttachmentType = _CycleConditionAttachmentTypeRepository
                .Where(x => x.CycleConditionId == Request.Id &&
                    x.AttachmentType != null)
                .Select(x => x.AttachmentType!.Value)
                .ToList();

            return new BaseResponse<CycleConditionDto>(ResponseMessage, true, 200, Response);
        }
    }
}
