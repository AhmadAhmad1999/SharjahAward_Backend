using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AgendaModel;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAgendaById
{
    public class GetAgendaByIdQueryHandler
        : IRequestHandler<GetAgendaByIdQuery, BaseResponse<AgendaDto>>
    {
        private readonly IAsyncRepository<Agenda> _AgendaRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAgendaByIdQueryHandler(IAsyncRepository<Agenda> _AgendaRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AgendaRepository = _AgendaRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<AgendaDto>> Handle(GetAgendaByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Agenda? AgendaEntity = _AgendaRepository
                .FirstOrDefault(x => x.Id == Request.Id);

            if (AgendaEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Agenda is not found"
                    : "الأجندة غير موجودة";

                return new BaseResponse<AgendaDto>(ResponseMessage, false, 404);
            }

            AgendaDto Response = _Mapper.Map<AgendaDto>(AgendaEntity);

            Response.Title = Request.lang == "en" 
                ? Response.EnglishTitle 
                : Response.ArabicTitle;

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            Response.Icon = Response.Icon.Contains("wwwroot")
                ? (WWWRootFilePath + Response.Icon.Split("wwwroot")[1]).Replace("\\", "/")
                : Response.Icon.Replace("\\", "/");

            return new BaseResponse<AgendaDto>(ResponseMessage, true, 200, Response);
        }
    }
}
