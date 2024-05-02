using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardSponsorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Commands.DeleteAwardSponsor
{
    public class DeleteAwardSponsorCommandHandler
        : IRequestHandler<DeleteAwardSponsorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AwardSponsor> _awardSponsorRepository;

        public DeleteAwardSponsorCommandHandler(IAsyncRepository<AwardSponsor> awardSponsorRepository)
        {
            _awardSponsorRepository = awardSponsorRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteAwardSponsorCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Award Sponser has been Deleted"
                : "تم حذف راعي الجائزة";

            var Sponser = await _awardSponsorRepository.GetByIdAsync(request.Id);
            
            if(Sponser == null)
            {
                msg = request.lang == "en"
                ? "Award Sponser not found"
                : "راعي الجائزة غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _awardSponsorRepository.DeleteAsync(Sponser);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
