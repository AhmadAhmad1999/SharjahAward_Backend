using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetGeneralWorkshopById
{
    public class GetGeneralWorkshopByIdQueryHandler
        : IRequestHandler<GetGeneralWorkshopByIdQuery, BaseResponse<GeneralWorkshopDto>>
    {
        private readonly IAsyncRepository<GeneralWorkshop> _GeneralWorkshopRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetGeneralWorkshopByIdQueryHandler(IAsyncRepository<GeneralWorkshop> _GeneralWorkshopRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._GeneralWorkshopRepository = _GeneralWorkshopRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<GeneralWorkshopDto>> Handle(GetGeneralWorkshopByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            GeneralWorkshop? GeneralWorkshopEntity = await _GeneralWorkshopRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);
          
            if (GeneralWorkshopEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "General workshop is not found"
                    : "الورشة التدريبية غير موجودة";

                return new BaseResponse<GeneralWorkshopDto>(ResponseMessage, false, 404);
            }

            GeneralWorkshopDto Response = _Mapper.Map<GeneralWorkshopDto>(GeneralWorkshopEntity);

            Response.Title = Request.lang == "en"
                ? Response.EnglishTitle
                : Response.ArabicTitle;

            Response.Description = Request.lang == "en"
                ? Response.EnglishDescription
                : Response.ArabicDescription;

            Response.AgendaImage = !string.IsNullOrEmpty(Response.AgendaImage)
                ? (Response.AgendaImage.Contains("wwwroot")
                    ? (WWWRootFilePath + Response.AgendaImage.Split("wwwroot")[1]).Replace("\\", "/")
                    : Response.AgendaImage.Replace("\\", "/"))
                : null;

            Response.RegistrationUrl = !string.IsNullOrEmpty(Response.RegistrationUrl)
                ? (Response.RegistrationUrl.Contains("wwwroot")
                    ? (WWWRootFilePath + Response.RegistrationUrl.Split("wwwroot")[1]).Replace("\\", "/")
                    : Response.RegistrationUrl.Replace("\\", "/"))
                : null;

            Response.Thumbnale = Response.Thumbnale.Contains("wwwroot")
                ? (WWWRootFilePath + Response.Thumbnale.Split("wwwroot")[1]).Replace("\\", "/")
                : Response.Thumbnale.Replace("\\", "/");

            Response.Video = !string.IsNullOrEmpty(Response.Video)
                ? (Response.Video.Contains("wwwroot")
                    ? (WWWRootFilePath + Response.Video.Split("wwwroot")[1]).Replace("\\", "/")
                    : Response.Video.Replace("\\", "/"))
                : null;

            return new BaseResponse<GeneralWorkshopDto>(ResponseMessage, true, 200, Response);
        }
    }
}
