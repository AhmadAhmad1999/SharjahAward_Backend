using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.ActivateTemplate
{
    public class ActivateTemplateHandler : IRequestHandler<ActivateTemplateCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Template> _TemplateRepository;
        public ActivateTemplateHandler(IAsyncRepository<Template> _TemplateRepository)
        {
            this._TemplateRepository = _TemplateRepository;
        }

        public async Task<BaseResponse<object>> Handle(ActivateTemplateCommand Request, CancellationToken cancellationToken)
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

            TemplateEntityToDelete.isActive = !TemplateEntityToDelete.isActive;

            await _TemplateRepository.UpdateAsync(TemplateEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Template has been activated successfully"
                : "تم تفعيل النموذج بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
