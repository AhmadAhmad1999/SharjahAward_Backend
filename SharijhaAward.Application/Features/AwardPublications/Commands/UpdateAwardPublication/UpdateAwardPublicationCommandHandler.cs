using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Commands.UpdateAwardPublication
{
    public class UpdateAwardPublicationCommandHandler
        : IRequestHandler<UpdateAwardPublicationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AwardPublication> _awardPublicationRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateAwardPublicationCommandHandler(IAsyncRepository<AwardPublication> awardPublicationRepository, IFileService fileService, IMapper mapper)
        {
            _awardPublicationRepository = awardPublicationRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAwardPublicationCommand request, CancellationToken cancellationToken)
        {
            var publication = await _awardPublicationRepository.GetByIdAsync(request.Id);

            if (publication == null)
            {
                return new BaseResponse<object>("الإصدار غير موجود", false, 404);
            }
            var image = request.updateOnImage
                ? await _fileService.SaveFileAsync(request.Image!, SystemFileType.Images)
                : publication.ImageUrl;

            var publishFile = request.updateOnPublication
                ? await _fileService.SaveFileAsync(request.Publication!, SystemFileType.Images)
                : publication.PublicationUrl;

            _mapper.Map(request, publication, typeof(UpdateAwardPublicationCommand), typeof(AwardPublication));

            publication.ImageUrl = image;
            publication.PublicationUrl = publishFile;

            await _awardPublicationRepository.UpdateAsync(publication);

            return new BaseResponse<object>("تم التعديل بنجاح", true, 200);
          
            
        }
    }
}
