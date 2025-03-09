using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetActiveCycleData
{
    public class GetActiveCycleDataHandler : IRequestHandler<GetActiveCycleDataQuery, BaseResponse<GetActiveCycleDataDto>>
    {
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        public GetActiveCycleDataHandler(IAsyncRepository<Cycle> CycleRepository)
        {
            _CycleRepository = CycleRepository;
        }

        public async Task<BaseResponse<GetActiveCycleDataDto>> Handle(GetActiveCycleDataQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if (CycleEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "No active cycle were found in the current time"
                    : "لا يوجد دورة فعالة في الوقت الحالي";

                return new BaseResponse<GetActiveCycleDataDto>(ResponseMessage, false, 404);
            }

            GetActiveCycleDataDto Response = new GetActiveCycleDataDto()
            {
                Id = CycleEntity.Id,
                CycleNumber = CycleEntity.CycleNumber,
                Year = CycleEntity.Year,
                ArabicName = CycleEntity.ArabicName,
                EnglishName = CycleEntity.EnglishName,
                RegistrationPortalOpeningDate = CycleEntity.RegistrationPortalOpeningDate,
                RegistrationPortalClosingDate = CycleEntity.RegistrationPortalClosingDate,
                SubscriberPortalClosingDate = CycleEntity.SubscriberPortalClosingDate
            };

            return new BaseResponse<GetActiveCycleDataDto>(ResponseMessage, true, 200, Response);
        }
    }
}
