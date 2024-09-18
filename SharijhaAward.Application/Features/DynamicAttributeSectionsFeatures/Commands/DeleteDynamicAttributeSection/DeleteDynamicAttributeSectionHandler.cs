using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection
{
    public class DeleteDynamicAttributeSectionHandler : IRequestHandler<DeleteDynamicAttributeSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        public DeleteDynamicAttributeSectionHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteDynamicAttributeSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttributeSection? DynamicAttributeSectionToDelete = await _DynamicAttributeSectionRepository
                .GetByIdAsync(Request.Id);
            if (DynamicAttributeSectionToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section Not Found"
                    : "هذا القسم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _DynamicAttributeSectionRepository.DeleteAsync(DynamicAttributeSectionToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Section has been Deleted successfully"
                : "تم حذف القسم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
