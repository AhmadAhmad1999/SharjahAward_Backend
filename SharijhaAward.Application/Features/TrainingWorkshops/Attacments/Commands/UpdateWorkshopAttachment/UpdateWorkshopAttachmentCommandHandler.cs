using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment
{
    public class UpdateWorkshopAttachmentCommandHandler
        : IRequestHandler<UpdateWorkshopAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _workshopRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachment> _attachmentRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateWorkshopAttachmentCommandHandler(IAsyncRepository<TrainingWorkshop> workshopRepository, IAsyncRepository<TrainingWorkshopAttachment> attachmentRepository, IFileService fileService, IMapper mapper)
        {
            _workshopRepository = workshopRepository;
            _attachmentRepository = attachmentRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateWorkshopAttachmentCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
               ? "Attachment has been Updated"
               : "تم تعديل الملف";

            var attachmentToUpdate = await _attachmentRepository.GetByIdAsync(request.Id);
            if (attachmentToUpdate == null)
            {
                 msg = request.lang == "en"
               ? "The Attachment Not Found"
               : "الملف المطلوب غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var attachment = attachmentToUpdate.AttachementPath;

            _mapper.Map(request, attachmentToUpdate, typeof(UpdateWorkshopAttachmentCommand), typeof(TrainingWorkshopAttachment));
    
            if (request.EditOnAttachment)
                attachmentToUpdate.AttachementPath = await _fileService.SaveFileAsync(request.attachment, SystemFileType.Pdf);
            else
                attachmentToUpdate.AttachementPath = attachment;

            await _attachmentRepository.UpdateAsync(attachmentToUpdate);

           

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
