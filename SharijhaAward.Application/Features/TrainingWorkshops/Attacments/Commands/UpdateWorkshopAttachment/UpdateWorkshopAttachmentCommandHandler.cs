using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;
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
        private readonly IAsyncRepository<TrainingWrokshopeAttachment> _attachmentRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateWorkshopAttachmentCommandHandler(IAsyncRepository<TrainingWorkshop> workshopRepository, IAsyncRepository<TrainingWrokshopeAttachment> attachmentRepository, IFileService fileService, IMapper mapper)
        {
            _workshopRepository = workshopRepository;
            _attachmentRepository = attachmentRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateWorkshopAttachmentCommand request, CancellationToken cancellationToken)
        {
            var attachmentToUpdate = await _attachmentRepository.GetByIdAsync(request.Id);
            if (attachmentToUpdate == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            var attachment = attachmentToUpdate;

            _mapper.Map(request, attachmentToUpdate, typeof(UpdateWorkshopAttachmentCommand), typeof(TrainingWrokshopeAttachment));
    
            if (request.EditOnAttachment)
                attachmentToUpdate.AttachementPath = await _fileService.SaveFileAsync(request.attachment);
            else
                attachmentToUpdate.AttachementPath = attachment.AttachementPath;

            await _attachmentRepository.UpdateAsync(attachmentToUpdate);

            string msg = request.lang == "en"
                ? "Attachment has been Updated"
                : "تم تعديل الملف";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
