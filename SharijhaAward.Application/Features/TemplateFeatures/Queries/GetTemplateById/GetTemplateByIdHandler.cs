using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Queries.GetTemplateById
{
    public class GetTemplateByIdHandler : IRequestHandler<GetTemplateByIdQuery, BaseResponse<GetTemplateByIdDto>>
    {
        private readonly IAsyncRepository<Template> _TemplateRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetTemplateByIdHandler(IAsyncRepository<Template> TemplateRepository,
            IMapper Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            _TemplateRepository = TemplateRepository;
            _Mapper = Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public async Task<BaseResponse<GetTemplateByIdDto>> Handle(GetTemplateByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Template? TemplateEntity = await _TemplateRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (TemplateEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Template is not found"
                    : "النموذج غير موجود";

                return new BaseResponse<GetTemplateByIdDto>(ResponseMessage, false, 404);
            }

            GetTemplateByIdDto GetTemplateByIdDto = _Mapper.Map<GetTemplateByIdDto>(TemplateEntity);

            if (!string.IsNullOrEmpty(GetTemplateByIdDto.BackgroundImageUrl)
                ? GetTemplateByIdDto.BackgroundImageUrl.Contains("wwwroot")
                : false)
            {
                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                string WWWRootFilePath = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                GetTemplateByIdDto.BackgroundImageUrl = (WWWRootFilePath + GetTemplateByIdDto.BackgroundImageUrl.Split("wwwroot")[1]).Replace("\\", "/");
            }

            return new BaseResponse<GetTemplateByIdDto>(ResponseMessage, true, 200, GetTemplateByIdDto);
        }
    }
}
