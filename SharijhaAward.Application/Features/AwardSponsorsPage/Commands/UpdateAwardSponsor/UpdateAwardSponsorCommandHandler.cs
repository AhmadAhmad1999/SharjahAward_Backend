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

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Commands.UpdateAwardSponsor
{
    public class UpdateAwardSponsorCommandHandler
        : IRequestHandler<UpdateAwardSponsorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AwardSponsor> _awardSponsorRepository;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;

        public UpdateAwardSponsorCommandHandler(IAsyncRepository<AwardSponsor> awardSponsorRepository, IMapper mapper, IFileService fileService)
        {
            _awardSponsorRepository = awardSponsorRepository;
            _mapper = mapper;
            _fileService = fileService;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAwardSponsorCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                        ? "Award Sponser has been Updated"
                        : "تم تعديل راعي الجائزة";

            var Sponser = await _awardSponsorRepository.GetByIdAsync(request.Id);
            
            if (Sponser == null)
            {
                msg = request.lang == "en"
                    ? "Award Sponser not found"
                    : "راعي الجائزة غير موجود";

                return new BaseResponse<object>(msg,false,404);
            }

            var Image1 = Sponser.Image;
            var Image2 = Sponser.Image2;
            var Image3 = Sponser.Image3;

            _mapper.Map(request, Sponser, typeof(UpdateAwardSponsorCommand), typeof(AwardSponsor));

            Sponser.Image = request.UpdateOnImage1 == true
                ? await _fileService.SaveFileAsync(request.Image!, SystemFileType.Images)
                : Image1;

            Sponser.Image2 = request.UpdateOnImage2 == true
                ? await _fileService.SaveFileAsync(request.Image2!, SystemFileType.Images)
                : Image2;

            Sponser.Image3 = request.UpdateOnImage3 == true
                ? await _fileService.SaveFileAsync(request.Image3!, SystemFileType.Images)
                : Image3;

            await _awardSponsorRepository.UpdateAsync(Sponser);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
