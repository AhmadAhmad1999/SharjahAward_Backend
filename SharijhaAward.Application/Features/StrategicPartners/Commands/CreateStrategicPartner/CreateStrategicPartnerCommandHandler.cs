using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.StrategicPartnerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.StrategicPartners.Commands.CreateStrategicPartner
{
    public class CreateStrategicPartnerCommandHandler
        : IRequestHandler<CreateStrategicPartnerCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<StrategicPartner> _strategicPartnerRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateStrategicPartnerCommandHandler(IAsyncRepository<StrategicPartner> strategicPartnerRepository, IFileService fileService, IMapper mapper)
        {
            _strategicPartnerRepository = strategicPartnerRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateStrategicPartnerCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Strategic Partner has been Created"
                : "تم إضافة الشريك الإستراتيجي";

            var StrategicPartner = _mapper.Map<StrategicPartner>(request);

            StrategicPartner.LogoUrl = await _fileService.SaveFileAsync(request.Logo);

            await _strategicPartnerRepository.AddAsync(StrategicPartner);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
