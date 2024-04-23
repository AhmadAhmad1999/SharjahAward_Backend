using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.DownloadAwardPublication
{
    public class DownloadAwardPublicationQueryHandler
        : IRequestHandler<DownloadAwardPublicationQuery, BaseResponse<DownloadPublicationDto>>
    {
        private readonly IAsyncRepository<AwardPublication> _awardPublicationRepository;
        private readonly IFileService _fileService;

        public DownloadAwardPublicationQueryHandler(IAsyncRepository<AwardPublication> awardPublicationRepository, IFileService fileService)
        {
            _awardPublicationRepository = awardPublicationRepository;
            _fileService = fileService;
        }

        public async Task<BaseResponse<DownloadPublicationDto>> Handle(DownloadAwardPublicationQuery request, CancellationToken cancellationToken)
        {
            var AwardPublication = await _awardPublicationRepository.GetByIdAsync(request.PublicationId);
            if(AwardPublication == null)
            {
                return new BaseResponse<DownloadPublicationDto>("", false, 404);
            }
            byte[] fileContent;
            
            fileContent = await _fileService.ReadFileAsync(AwardPublication.PublicationUrl);
           
            var data = new DownloadPublicationDto()
            {
                fileContent = fileContent!,
                fileContentType = "applection/pdf",
                fileFileName = AwardPublication.Title
            };

            return new BaseResponse<DownloadPublicationDto>("", true, 200, data);
        }
    }
}
