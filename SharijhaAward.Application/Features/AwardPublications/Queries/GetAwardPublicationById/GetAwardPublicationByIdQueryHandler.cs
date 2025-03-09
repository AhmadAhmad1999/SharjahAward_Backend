using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.GetAwardPublicationById
{
    public class GetAwardPublicationByIdQueryHandler
        : IRequestHandler<GetAwardPublicationByIdQuery, BaseResponse<AwardPublicationDto>>
    {
        private readonly IAsyncRepository<AwardPublication> _AwardPublicationRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAwardPublicationByIdQueryHandler(IAsyncRepository<AwardPublication> _AwardPublicationRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AwardPublicationRepository = _AwardPublicationRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<AwardPublicationDto>> Handle(GetAwardPublicationByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AwardPublication? AwardPublicationEntitty = await _AwardPublicationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);
           
            if (AwardPublicationEntitty == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Award publication is not found"
                    : "إصدار الجائزة غير موجود";

                return new BaseResponse<AwardPublicationDto>(ResponseMessage, false, 404);
            }

            AwardPublicationDto Response = _Mapper.Map<AwardPublicationDto>(AwardPublicationEntitty);

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            Response.ImageUrl = Response.ImageUrl.Contains("wwwroot")
                ? (WWWRootFilePath + Response.ImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                : Response.ImageUrl.Replace("\\", "/");

            Response.PublicationUrl = Response.PublicationUrl.Contains("wwwroot")
                ? (WWWRootFilePath + Response.PublicationUrl.Split("wwwroot")[1]).Replace("\\", "/")
                : Response.PublicationUrl.Replace("\\", "/");

            return new BaseResponse<AwardPublicationDto>(ResponseMessage, true, 200, Response);
        }
    }
}
