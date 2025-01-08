using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.DeleteVirtualTableFroSection
{
    public class DeleteVirtualTableFroSectionHandler : IRequestHandler<DeleteVirtualTableFroSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;
        public DeleteVirtualTableFroSectionHandler(IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository)
        {
            this._VirtualTableForSectionRepository = _VirtualTableForSectionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteVirtualTableFroSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            VirtualTableForSection? VirtualTableForSectionToDelete = await _VirtualTableForSectionRepository.
                FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (VirtualTableForSectionToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _VirtualTableForSectionRepository.DeleteAsync(VirtualTableForSectionToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Advanced form has been deleted successfully"
                : "تم حذف النموذج المتقدم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
