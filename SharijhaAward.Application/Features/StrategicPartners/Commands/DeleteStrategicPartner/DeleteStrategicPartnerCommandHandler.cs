using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.StrategicPartnerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.StrategicPartners.Commands.DeleteStrategicPartner
{
    public class DeleteStrategicPartnerCommandHandler
        : IRequestHandler<DeleteStrategicPartnerCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<StrategicPartner> _strategicPartnerRepository;

        public DeleteStrategicPartnerCommandHandler(IAsyncRepository<StrategicPartner> strategicPartnerRepository)
        {
            _strategicPartnerRepository = strategicPartnerRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteStrategicPartnerCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Strategic Partner has been Deleted"
                : "تم حذف الشريك الإستراتيجي";

            var StrategicPartner = await _strategicPartnerRepository.GetByIdAsync(request.Id);

            if(StrategicPartner ==  null)
            {
                msg = request.lang == "en"
                ? "Strategic Partner Not Found"
                : "الشريك الإستراتيجي غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _strategicPartnerRepository.DeleteAsync(StrategicPartner);

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
