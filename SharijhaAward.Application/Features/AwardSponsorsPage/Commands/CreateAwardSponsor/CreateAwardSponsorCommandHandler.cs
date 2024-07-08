using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.AwardSponsorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Commands.CreateAwardSponsor
{
    public class CreateAwardSponsorCommandHandler
        : IRequestHandler<CreateAwardSponsorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AwardSponsor> _awardSponsorRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateAwardSponsorCommandHandler(IFileService fileService, IAsyncRepository<AwardSponsor> awardSponsorRepository, IMapper mapper)
        {
            _awardSponsorRepository = awardSponsorRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAwardSponsorCommand request, CancellationToken cancellationToken)
        {
            var Sponser = _mapper.Map<AwardSponsor>(request);

            Sponser.Image = await _fileService.SaveFileAsync(request.Image, SystemFileType.Images);
            Sponser.Image2 = await _fileService.SaveFileAsync(request.Image2, SystemFileType.Images);
            Sponser.Image3 = await _fileService.SaveFileAsync(request.Image3, SystemFileType.Images);

            await _awardSponsorRepository.AddAsync(Sponser);

            string msg = request.lang == "en"
                ? "Award Sponser has been Created"
                : "تم إضافة راعي الجائزة";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
