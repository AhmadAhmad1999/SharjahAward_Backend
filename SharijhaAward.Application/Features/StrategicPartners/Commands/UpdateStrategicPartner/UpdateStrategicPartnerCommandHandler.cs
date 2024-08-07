using AutoMapper;
using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.StrategicPartnerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.StrategicPartners.Commands.UpdateStrategicPartner
{
    public class UpdateStrategicPartnerCommandHandler
        : IRequestHandler<UpdateStrategicPartnerCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<StrategicPartner> _strategicPartnerRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateStrategicPartnerCommandHandler(IAsyncRepository<StrategicPartner> strategicPartnerRepository, IFileService fileService, IMapper mapper)
        {
            _strategicPartnerRepository = strategicPartnerRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateStrategicPartnerCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                       ? "Strategic Partner has been Updated"
                       : "تم تعديل الشريك الإستراتيجي";

            var StrategicPartner = await _strategicPartnerRepository.GetByIdAsync(request.Id);

            if(StrategicPartner == null)
            {
                msg = request.lang == "en"
                    ? "Strategic Partner Not Found"
                    : "الشريك الإستراتيجي غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var logoUrl = StrategicPartner.LogoUrl;
           
            _mapper.Map(request, StrategicPartner, typeof(UpdateStrategicPartnerCommand), typeof(StrategicPartner));
          
            if (request.UpdateOnLogo)
                StrategicPartner.LogoUrl = await _fileService.SaveFileAsync(request.Logo!, SystemFileType.Icons);
            else
                StrategicPartner.LogoUrl = logoUrl;

            if (!request.Url!.Contains("http"))
                StrategicPartner.Url = "https://" + request.Url;

            await _strategicPartnerRepository.UpdateAsync(StrategicPartner);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
