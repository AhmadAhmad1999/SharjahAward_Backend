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
            string msg = request.lang == "en"
               ? "Workshop has been Updated"
               : "تم تعديل الورشة التدريبية";

            var worksopToUpdate = await _trainingWorkshopRepository.GetByIdAsync(request.Id);
           
            if(worksopToUpdate == null)
            {
                msg = request.lang == "en"
                     ? "Workshop not found"
                     : "الورشة التدريبية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var thumbnail = worksopToUpdate.Thumbnail;
            _mapper.Map(request, worksopToUpdate, typeof(UpdateTrainingWorkshopCommand), typeof(TrainingWorkshop));
           
            if (request.EditeOnThumbnail)
                worksopToUpdate.Thumbnail = await _fileService.SaveFileAsync(request.Thumbnail!);
            else
                worksopToUpdate.Thumbnail = thumbnail;
            
            await _trainingWorkshopRepository.UpdateAsync(worksopToUpdate);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
