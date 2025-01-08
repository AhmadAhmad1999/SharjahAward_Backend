using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetDigitalSignatureById
{
    public class GetDigitalSignatureByIdHandler : IRequestHandler<GetDigitalSignatureByIdQuery, BaseResponse<GetDigitalSignatureByIdDto>>
    {
        private readonly IAsyncRepository<DigitalSignature> _DigitalSignatureRepository;
        private readonly IMapper _Mapper;
        public GetDigitalSignatureByIdHandler(IAsyncRepository<DigitalSignature> _DigitalSignatureRepository,
            IMapper _Mapper)
        {
            this._DigitalSignatureRepository = _DigitalSignatureRepository;
            this._Mapper = _Mapper;
        }
        public async Task<BaseResponse<GetDigitalSignatureByIdDto>> Handle(GetDigitalSignatureByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DigitalSignature? DigitalSignatureEntity = await _DigitalSignatureRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (DigitalSignatureEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Digital signature is not found"
                    : "التوقيع الرقمي غير موجود";

                return new BaseResponse<GetDigitalSignatureByIdDto>(ResponseMessage, false, 404);
            }

            GetDigitalSignatureByIdDto GetDigitalSignatureByIdDto = _Mapper.Map<GetDigitalSignatureByIdDto>(DigitalSignatureEntity);

            return new BaseResponse<GetDigitalSignatureByIdDto>(ResponseMessage, true, 200, GetDigitalSignatureByIdDto);
        }
    }
}
