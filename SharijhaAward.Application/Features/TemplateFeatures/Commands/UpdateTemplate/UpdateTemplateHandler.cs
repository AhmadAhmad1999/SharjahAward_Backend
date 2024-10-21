using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.UpdateTemplate
{
    public class UpdateTemplateHandler : IRequestHandler<UpdateTemplateCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Template> _TemplateRepository;

        public UpdateTemplateHandler(IMapper Mapper,
            IAsyncRepository<Template> _TemplateRepository)
        {
            _Mapper = Mapper;
            this._TemplateRepository = _TemplateRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateTemplateCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Template? TemplateEntityToUpdate = await _TemplateRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (TemplateEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Template is not found"
                    : "النموذج غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, TemplateEntityToUpdate, typeof(UpdateTemplateCommand), typeof(Template));

            await _TemplateRepository.UpdateAsync(TemplateEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Template has been updated successfully"
                : "تم تعديل النموذج بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}