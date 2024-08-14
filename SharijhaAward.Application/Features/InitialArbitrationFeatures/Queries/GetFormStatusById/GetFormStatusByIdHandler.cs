using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetFormStatusById
{
    public class GetFormStatusByIdHandler : IRequestHandler<GetFormStatusByIdQuery,
        BaseResponse<GetFormStatusByIdDto>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;

        public GetFormStatusByIdHandler(IAsyncRepository<Arbitration> ArbitrationRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
        }

        public async Task<BaseResponse<GetFormStatusByIdDto>> 
            Handle(GetFormStatusByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitration? ArbitrationEntity = await _ArbitrationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitrationId);

            if (ArbitrationEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration is not found"
                    : "التحكيم غير موجود";

                return new BaseResponse<GetFormStatusByIdDto>(ResponseMessage, false, 404);
            }

            GetFormStatusByIdDto Response = new GetFormStatusByIdDto()
            {
                FormId = ArbitrationEntity.ProvidedFormId,
                isAccepted = ArbitrationEntity.isAccepted,
                isAcceptedFromChairman = ArbitrationEntity.isAcceptedFromChairman
            };

            return new BaseResponse<GetFormStatusByIdDto>(ResponseMessage, true, 200, Response);
        }
    }
}
