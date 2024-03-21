using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Commands.DeleteExplanatoryGuide
{
    public class DeleteExplanatoryGuideCommandHandler
        : IRequestHandler<DeleteExplanatoryGuideCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExplanatoryGuide> _explanatoryGuideRepository;

        public DeleteExplanatoryGuideCommandHandler(IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository)
        {
            _explanatoryGuideRepository = explanatoryGuideRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteExplanatoryGuideCommand request, CancellationToken cancellationToken)
        {
            var Guide = await _explanatoryGuideRepository.GetByIdAsync(request.GuideId);
           
            string msg = request.lang =="en"
                ? "The Explanatory Guide has been Deleted"
                : "تم حذف الدليل التفسيري";

            if (Guide == null)
            {
                msg = request.lang == "en"
                    ? "The Explanatory Guide not Found"
                    : "الدليل التفسيري غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _explanatoryGuideRepository.DeleteAsync(Guide);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
