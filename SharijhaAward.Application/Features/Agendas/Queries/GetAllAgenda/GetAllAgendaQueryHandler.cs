using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AgendaModel;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda
{
    public class GetAllAgendaQueryHandler
        : IRequestHandler<GetAllAgendaQuery, BaseResponse<List<AgendaListVm>>>
    {
        private readonly IAsyncRepository<Agenda> _AgendaRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllAgendaQueryHandler(IAsyncRepository<Agenda> _AgendaRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AgendaRepository = _AgendaRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<AgendaListVm>>> Handle(GetAllAgendaQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Agenda> AgendaEntities = new List<Agenda>();

            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                AgendaEntities = _AgendaRepository
                    .Where(x => !x.IsPrivate)
                    .OrderByDescending(x => x.CreatedAt)
                    .AsEnumerable()
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .AsEnumerable()
                    .ToList();
            }
            else
            {
                AgendaEntities = _AgendaRepository
                    .Where(x => !x.IsPrivate)
                    .OrderByDescending(x => x.CreatedAt)
                    .AsEnumerable()
                    .AsEnumerable()
                    .ToList();
            }

            foreach (Agenda Agenda in AgendaEntities)
            {
                if (DateTime.Now >= Agenda.StartDate && DateTime.Now <= Agenda.EndDate)
                    Agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Active;

                else if (DateTime.Now > Agenda.StartDate && DateTime.Now > Agenda.EndDate)
                    Agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Previous;

                else if (DateTime.Now < Agenda.StartDate && DateTime.Now < Agenda.EndDate)
                    Agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Later;

                await _AgendaRepository.UpdateAsync(Agenda);
            }

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<AgendaListVm> Response = AgendaEntities
                .Select(x => new AgendaListVm()
                {
                    Id = x.Id,
                    Title = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    ArabicTitle = x.ArabicTitle,
                    EnglishTitle = x.EnglishTitle,
                    Icon = x.Icon.Contains("wwwroot")
                        ? (WWWRootFilePath + x.Icon.Split("wwwroot")[1]).Replace("\\", "/")
                        : x.Icon.Replace("\\", "/"),
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    CurrentDate = x.CurrentDate,
                    Status = x.Status,
                    DateType = x.DateType,
                    IsPrivate = x.IsPrivate,
                    CycleId = x.CycleId
                }).ToList();

            int TotalCount = _AgendaRepository
                .GetCount(x => !x.IsPrivate);

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<AgendaListVm>>(ResponseMessage, true, 200, Response, Pagination);
        }
    }
}
