using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetDigitalSignatureById
{
    public class GetDigitalSignatureByIdHandler : IRequestHandler<GetDigitalSignatureByIdQuery, BaseResponse<GetDigitalSignatureByIdDto>>
    {
        private readonly IAsyncRepository<DigitalSignature> _DigitalSignatureRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public GetDigitalSignatureByIdHandler(IAsyncRepository<DigitalSignature> _DigitalSignatureRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._DigitalSignatureRepository = _DigitalSignatureRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
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

            if (GetDigitalSignatureByIdDto.ImageUrl.Contains("wwwroot"))
            {
                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                string WWWRootFilePath = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                GetDigitalSignatureByIdDto.ImageUrl = (WWWRootFilePath + GetDigitalSignatureByIdDto.ImageUrl.Split("wwwroot")[1]).Replace("\\", "/");
            }

            return new BaseResponse<GetDigitalSignatureByIdDto>(ResponseMessage, true, 200, GetDigitalSignatureByIdDto);
        }
    }
}
