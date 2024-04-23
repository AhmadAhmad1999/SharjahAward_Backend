using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Commands.DeleteAwardPublication
{
    public class DeleteAwardPublicationCommandHandler
        : IRequestHandler<DeleteAwardPublicationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AwardPublication> _awardPublicationRepository;

        public DeleteAwardPublicationCommandHandler(IAsyncRepository<AwardPublication> awardPublicationRepository)
        {
            _awardPublicationRepository = awardPublicationRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteAwardPublicationCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Award Publication has been Deleted"
                : "تم حذف إصدار الجائزة"; 

            var AwardPublication = await _awardPublicationRepository.GetByIdAsync(request.Id);

            if(AwardPublication == null)
            {
                msg = request.lang == "en"
                ? "Award Publication Not found"
                : " إصدار الجائزة غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _awardPublicationRepository.DeleteAsync(AwardPublication);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
