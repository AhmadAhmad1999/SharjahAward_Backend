using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Commands.DeleteGeneralWorkshop
{
    public class DeleteGeneralWorkshopCommandHandler
        : IRequestHandler<DeleteGeneralWorkshopCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GeneralWorkshop> _workShopRepository;

        public DeleteGeneralWorkshopCommandHandler(IAsyncRepository<GeneralWorkshop> workShopRepository)
        {
            _workShopRepository = workShopRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteGeneralWorkshopCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Workshop has been Deleted"
                : "تم حذف الورشة التدريبية";
            var WorkshopToDelete = await _workShopRepository.GetByIdAsync(request.Id);

            if(WorkshopToDelete == null)
            {
                return new BaseResponse<object>("", false, 404);
            }

            await _workShopRepository.DeleteAsync(WorkshopToDelete);
            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
