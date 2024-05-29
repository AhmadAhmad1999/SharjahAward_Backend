using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.CreateDynamicAttributeListValue
{
    public class CreateDynamicAttributeListValueHandler : IRequestHandler<CreateDynamicAttributeListValueCommand,
        BaseResponse<CreateDynamicAttributeListValueResponse>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        public CreateDynamicAttributeListValueHandler(IMapper Mapper,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _Mapper = Mapper;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<BaseResponse<CreateDynamicAttributeListValueResponse>> Handle(CreateDynamicAttributeListValueCommand Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttribute? CheckIfDynamicAttributeIdDoesExist = await _DynamicAttributeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributeId);

            if (CheckIfDynamicAttributeIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "field is not Found"
                  : "الحقل غير موجود";

                return new BaseResponse<CreateDynamicAttributeListValueResponse>(ResponseMessage, false, 404);
            }

            DynamicAttributeListValue NewDynamicAttributeListValueEntity = _Mapper.Map<DynamicAttributeListValue>(Request);
            await _DynamicAttributeListValueRepository.AddAsync(NewDynamicAttributeListValueEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء القيمة بنجاح";

            return new BaseResponse<CreateDynamicAttributeListValueResponse>()
            {
                data = new CreateDynamicAttributeListValueResponse()
                {
                    CreateDynamicAttributeListValueDto = new CreateDynamicAttributeListValueDto()
                    {
                        Id = NewDynamicAttributeListValueEntity.Id,
                        Value = Request.Value,
                        DynamicAttributeId = Request.DynamicAttributeId
                    }
                },
                message = ResponseMessage,
                statusCode = 200,
                success = true
            };
        }
    }
}
