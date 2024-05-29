using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.CreateAdvancedFormBuilderListValue
{
    public class CreateAdvancedFormBuilderListValueHandler : IRequestHandler<CreateAdvancedFormBuilderListValueCommand,
        BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        public CreateAdvancedFormBuilderListValueHandler(IMapper Mapper,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository)
        {
            _Mapper = Mapper;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateAdvancedFormBuilderListValueCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilder? CheckIfAdvancedFormBuilderIdDoesExist = await _AdvancedFormBuilderRepository
                .FirstOrDefaultAsync(x => x.Id == Request.AdvancedFormBuilderId);

            if (CheckIfAdvancedFormBuilderIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "field is not Found"
                  : "الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            AdvancedFormBuilderListValue NewAdvancedFormBuilderListValueEntity = _Mapper.Map<AdvancedFormBuilderListValue>(Request);
            await _AdvancedFormBuilderListValueRepository.AddAsync(NewAdvancedFormBuilderListValueEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء القيمة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
