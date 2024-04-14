using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.CreateExtraAttachment
{
    public class CreateExtraAttachmentCommandHandler
        : IRequestHandler<CreateExtraAttachmentCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentRepository;
        private readonly IMapper _mapper;

        public CreateExtraAttachmentCommandHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IAsyncRepository<ExtraAttachment> extraAttachmentRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _extraAttachmentRepository = extraAttachmentRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateExtraAttachmentCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Extra Attachment has been Added"
                : "تم إضافة الملحق الإضافي";

            var providedForm = await _formRepository.GetByIdAsync(request.ProvidedFormId);
            if(providedForm == null)
            {
                msg = request.lang == "en"
                ? "Provided Form Not Found"
                : "الإستمارة غير موجودة";

                return new BaseResponse<int>(msg, false, 404);
            }
            providedForm.TotalStep = 8;
            
            var PercentFormula = (providedForm.CurrentStep - 1 * 100) / providedForm.TotalStep;
            providedForm.PercentCompletion = PercentFormula < 0 ? 0 : PercentFormula;

            var extraAttachment = _mapper.Map<ExtraAttachment>(request);

            var data = await _extraAttachmentRepository.AddAsync(extraAttachment);
            await _formRepository.UpdateAsync(providedForm);

            return new BaseResponse<int>(msg, true, 200, data.Id);
        }
    }
}
