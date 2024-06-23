 using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Commands.CreateAwardPublication
{
    public class CreateAwardPublicationCommandHandler
        : IRequestHandler<CreateAwardPublicationCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<AwardPublication> _awardPublicationRepository;

        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateAwardPublicationCommandHandler(IFileService fileService, IAsyncRepository<AwardPublication> awardPublicationRepository, IMapper mapper)
        {
            _awardPublicationRepository = awardPublicationRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateAwardPublicationCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Award Publication has been Created"
                : "تم إنشاء إصدار الجائزة";

            var AwardPublication = _mapper.Map<AwardPublication>(request);
            AwardPublication.ImageUrl = await _fileService.SaveFileAsync(request.Image);
            AwardPublication.PublicationUrl = await _fileService.SaveFileAsync(request.Publication);

            var data = await _awardPublicationRepository.AddAsync(AwardPublication);

            return new BaseResponse<int>(msg, true, 200, data.Id);
        }
    }
}
