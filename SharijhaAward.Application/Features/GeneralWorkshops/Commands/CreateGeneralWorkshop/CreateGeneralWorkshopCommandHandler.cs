using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Commands.CreateGeneralWorkshop
{
    public class CreateGeneralWorkshopCommandHandler
        : IRequestHandler<CreateGeneralWorkshopCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<GeneralWorkshop> _generalWorkshopeRepository;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;

        public CreateGeneralWorkshopCommandHandler(IAsyncRepository<GeneralWorkshop> generalWorkshopeRepository, IMapper mapper, IFileService fileService)
        {
            _generalWorkshopeRepository = generalWorkshopeRepository;
            _mapper = mapper;
            _fileService = fileService;
        }

        public async Task<BaseResponse<int>> Handle(CreateGeneralWorkshopCommand request, CancellationToken cancellationToken)
        {
            var GeneralWorkshop = _mapper.Map<GeneralWorkshop>(request);

            GeneralWorkshop.Thumbnale = await _fileService.SaveFileAsync(request.Thumbnale);

            GeneralWorkshop.Video = request.Video != null
                ? await _fileService.SaveFileAsync(request.Video) 
                : string.Empty;

            GeneralWorkshop.AgendaImage = request.AgendaImage != null
                ? await _fileService.SaveFileAsync(request.AgendaImage)
                : string.Empty;
            CultureInfo culture = new CultureInfo("ar");

            GeneralWorkshop.DayName = request.DateOfWorkShop.Day.ToString(culture);

            var data = await _generalWorkshopeRepository.AddAsync(GeneralWorkshop);
            string msg = request.lang == "en"
                ? "The General Workshpoe has Been Created"
                : "تم إانشاء الورشة التدريبية";


            return new BaseResponse<int>(msg, true, 200, data.Id);

        }
    }
}
