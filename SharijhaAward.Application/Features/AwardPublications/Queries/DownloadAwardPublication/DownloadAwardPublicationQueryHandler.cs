using ErrorOr;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.DownloadAwardPublication
{
    public class DownloadAwardPublicationQueryHandler
        : IRequestHandler<DownloadAwardPublicationQuery, BaseResponse<DownloadPublicationDto>>
    {
        private readonly IAsyncRepository<AwardPublication> _AwardPublicationRepository;
        private readonly IFileService _FileService;

        public DownloadAwardPublicationQueryHandler(IAsyncRepository<AwardPublication> _AwardPublicationRepository, IFileService _FileService)
        {
            this._AwardPublicationRepository = _AwardPublicationRepository;
            this._FileService = _FileService;
        }

        public async Task<BaseResponse<DownloadPublicationDto>> Handle(DownloadAwardPublicationQuery Request, CancellationToken cancellationToken)
        {
            AwardPublication? AwardPublicationEntity = await _AwardPublicationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.PublicationId);
            
            if (AwardPublicationEntity is null)
            {
                return new BaseResponse<DownloadPublicationDto>("", false, 404);
            }

            byte[] fileContent;
            
            fileContent = await _FileService
                .ReadFileAsync(AwardPublicationEntity.PublicationUrl, SystemFileType.Pdf);
           
            var data = new DownloadPublicationDto()
            {
                fileContent = fileContent!,
                fileContentType = "applection/pdf",
                fileFileName = AwardPublicationEntity.Title
            };

            return new BaseResponse<DownloadPublicationDto>("", true, 200, data);
        }
    }
}
