using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.UpdateDynamicAttributeListValue
{
    public class UpdateDynamicAttributeListValueHandler : IRequestHandler<UpdateDynamicAttributeListValueCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IMapper _Mapper;

        public UpdateDynamicAttributeListValueHandler(IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IMapper Mapper)
        {
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateDynamicAttributeListValueCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttributeListValue? DynamicAttributeListValueOldData = await _DynamicAttributeListValueRepository
                .GetByIdAsync(Request.Id);

            if (DynamicAttributeListValueOldData == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Value is not found"
                    : "هذه القيمة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, DynamicAttributeListValueOldData, typeof(UpdateDynamicAttributeListValueCommand),
                typeof(DynamicAttributeListValue));

            await _DynamicAttributeListValueRepository.UpdateAsync(DynamicAttributeListValueOldData);

            ResponseMessage = Request.lang == "en"
                ? "Value has been updated successfully"
                : "تم تعديل القيمة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
