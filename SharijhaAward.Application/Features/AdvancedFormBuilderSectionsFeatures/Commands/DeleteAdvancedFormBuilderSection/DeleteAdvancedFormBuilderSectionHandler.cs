using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.DeleteAdvancedFormBuilderSection
{
    public class DeleteAdvancedFormBuilderSectionHandler : IRequestHandler<DeleteAdvancedFormBuilderSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        public DeleteAdvancedFormBuilderSectionHandler(IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository)
        {
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteAdvancedFormBuilderSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilderSection? AdvancedFormBuilderSectionToDelete = await _AdvancedFormBuilderSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (AdvancedFormBuilderSectionToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section Not Found"
                    : "هذا القسم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _AdvancedFormBuilderSectionRepository.DeleteAsync(AdvancedFormBuilderSectionToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Section has been Deleted successfully"
                : "تم حذف القسم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
