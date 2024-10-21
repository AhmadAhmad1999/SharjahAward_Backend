using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.DeleteTemplate
{
    public class DeleteTemplateHandler : IRequestHandler<DeleteTemplateCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Template> _TemplateRepository;
        public DeleteTemplateHandler(IAsyncRepository<Template> _TemplateRepository)
        {
            this._TemplateRepository = _TemplateRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteTemplateCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Template? TemplateEntityToDelete = await _TemplateRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (TemplateEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Template is not found"
                    : "النموذج غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _TemplateRepository.DeleteAsync(TemplateEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Template has been deleted successfully"
                : "تم حذف النموذج بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
