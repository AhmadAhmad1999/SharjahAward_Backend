using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetTermAndConditionById
{
    public class GetTermAndConditionByIdQueryHandler
        : IRequestHandler<GetTermAndConditionByIdQuery, BaseResponse<TermAndConditionDto>>
    {
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository;

        public GetTermAndConditionByIdQueryHandler(IAsyncRepository<TermAndCondition> _TermAndConditionRepository, 
            IMapper _Mapper,
            IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository)
        {
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._Mapper = _Mapper;
            this._TermAndConditionAttachmentTypeRepository = _TermAndConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<TermAndConditionDto>> Handle(GetTermAndConditionByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TermAndCondition? TermAndConditionEntity = await _TermAndConditionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (TermAndConditionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Term and condition is not found"
                    : "الشرط الخاص للفئة غير موجود";

                return new BaseResponse<TermAndConditionDto>(ResponseMessage, false, 404);
            }

            List<AttachmentType> TermAndConditionAttachmentTypeEntities = _TermAndConditionAttachmentTypeRepository
                .Where(x => TermAndConditionEntity.Id == x.TermAndConditionId &&
                    x.AttachmentType != null)
                .Select(x => x.AttachmentType!.Value)
                .ToList();

            TermAndConditionDto Response = _Mapper.Map<TermAndConditionDto>(TermAndConditionEntity);

            Response.Description = Request.lang == "en" 
                ? TermAndConditionEntity.EnglishDescription 
                : TermAndConditionEntity.ArabicDescription;

            Response.AttachmentType = TermAndConditionAttachmentTypeEntities;

            return new BaseResponse<TermAndConditionDto>(string.Empty, true,200,Response);
        }
    }
}
