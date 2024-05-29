using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.UpdateAdvancedFormBuilderSection
{
    public class UpdateAdvancedFormBuilderSectionHandler : IRequestHandler<UpdateAdvancedFormBuilderSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IMapper _Mapper;

        public UpdateAdvancedFormBuilderSectionHandler(IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository,
            IMapper Mapper)
        {
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateAdvancedFormBuilderSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilderSection? AdvancedFormBuilderSectionOldData = await _AdvancedFormBuilderSectionRepository.GetByIdAsync(Request.Id);

            if (AdvancedFormBuilderSectionOldData == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section is not found"
                    : "هذا القسم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, AdvancedFormBuilderSectionOldData, typeof(UpdateAdvancedFormBuilderSectionCommand),
                typeof(AdvancedFormBuilderSection));

            await _AdvancedFormBuilderSectionRepository.UpdateAsync(AdvancedFormBuilderSectionOldData);

            ResponseMessage = Request.lang == "en"
                ? "Section has been updated successfully"
                : "تم تعديل القسم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
