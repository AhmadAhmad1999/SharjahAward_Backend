using Aspose.Pdf;
using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop
{
    public class UpdateTrainingWorkshopCommandHandler 
        : IRequestHandler<UpdateTrainingWorkshopCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateTrainingWorkshopCommandHandler(IFileService fileService,IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository, IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateTrainingWorkshopCommand request, CancellationToken cancellationToken)
        {
            var worksopToUpdate = await _trainingWorkshopRepository.GetByIdAsync(request.Id);
           
            if(worksopToUpdate == null)
            {
                return new BaseResponse<object>("", false, 404);
            }

            var workShop = worksopToUpdate;
            _mapper.Map(request, worksopToUpdate, typeof(UpdateTrainingWorkshopCommand), typeof(TrainingWorkshop));
           
            if (request.EditeOnThumbnail)
                worksopToUpdate.Thumbnail = await _fileService.SaveFileAsync(request.Thumbnail!);
            else
                worksopToUpdate.Thumbnail = workShop.Thumbnail;
            
            await _trainingWorkshopRepository.UpdateAsync(worksopToUpdate);

            string msg = request.lang == "en"
                ? "Workshop has been Updated"
                : "تم تعديل الورشة التدريبية";

            return new BaseResponse<object>("Workshop has been Updated", true, 200);
        }
    }
}
