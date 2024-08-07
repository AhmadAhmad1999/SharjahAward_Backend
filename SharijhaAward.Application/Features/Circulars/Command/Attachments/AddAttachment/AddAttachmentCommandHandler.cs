using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.CircularModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.Attachments.AddAttachment
{
    public class AddAttachmentCommandHandler
        : IRequestHandler<AddAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IAsyncRepository<CircularAttachment> _circularAttachmentRepository;
        private readonly IFileService _fileService;
        public AddAttachmentCommandHandler(IAsyncRepository<Circular> circularRepository, IAsyncRepository<CircularAttachment> circularAttachmentRepository, IFileService fileService)
        {
            _circularRepository = circularRepository;
            _circularAttachmentRepository = circularAttachmentRepository;
            _fileService = fileService;
        }
        public async Task<BaseResponse<object>> Handle(AddAttachmentCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Circular Not Found"
                : "التعميم غير موجود";

            var Circular = await _circularRepository.GetByIdAsync(request.CircularId);
           
            if(Circular == null)
            {
                return new BaseResponse<object>(msg, false, 404); 
            }

            CircularAttachment circularAttachment = new CircularAttachment()
            {
                AttachementPath = await _fileService.SaveFileAsync(request.CircularFile, SystemFileType.Circulars),
                CircularId = request.CircularId
            };

            await _circularAttachmentRepository.AddAsync(circularAttachment);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
