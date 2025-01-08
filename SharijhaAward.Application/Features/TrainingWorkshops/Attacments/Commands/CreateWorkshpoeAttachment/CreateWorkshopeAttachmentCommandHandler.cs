using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.CreateWorkshpoeAttachment
{
    public class CreateWorkshopeAttachmentCommandHandler
        : IRequestHandler<CreateWorkshopeAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _workshopRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachment> _attachmentRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateWorkshopeAttachmentCommandHandler(IAsyncRepository<TrainingWorkshop> workshopRepository, IAsyncRepository<TrainingWorkshopAttachment> attachmentRepository, IFileService fileService, IMapper mapper)
        {
            _workshopRepository = workshopRepository;
            _attachmentRepository = attachmentRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateWorkshopeAttachmentCommand request, CancellationToken cancellationToken)
        {
            var workShop = await _workshopRepository.GetByIdAsync(request.WorkshopeId);
            if (workShop == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            var data = _mapper.Map<TrainingWorkshopAttachment>(request);
            data.AttachementPath = await _fileService.SaveFileAsync(request.attachment, SystemFileType.Pdf);
            await _attachmentRepository.AddAsync(data);

            return new BaseResponse<object>("", true, 200);

        }
    }
}
