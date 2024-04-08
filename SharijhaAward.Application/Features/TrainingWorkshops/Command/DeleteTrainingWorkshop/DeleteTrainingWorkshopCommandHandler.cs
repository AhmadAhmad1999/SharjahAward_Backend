using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.DeleteTrainingWorkshop
{
    public class DeleteTrainingWorkshopCommandHandler 
        :IRequestHandler<DeleteTrainingWorkshopCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        
        public DeleteTrainingWorkshopCommandHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteTrainingWorkshopCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Training Workshop has been Deleted"
                : "تم حذف الدورة التدريبية";

            var workToDelete = await _trainingWorkshopRepository.GetByIdAsync(request.Id );
            if ( workToDelete == null )
            {
                msg = request.lang == "en"
                ? "Training Workshop Not Found"
                : "الدورة التدربية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _trainingWorkshopRepository.DeleteAsync(workToDelete);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
