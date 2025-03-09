using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAgendaByCycleId
{
    public class GetAgendaByCycleIdQueryHandler
        : IRequestHandler<GetAgendaByCycleIdQuery, BaseResponse<List<AgendaListVm>>>
    {
        private readonly IAsyncRepository<Agenda> _AgendaRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAgendaByCycleIdQueryHandler(IAsyncRepository<Agenda> _AgendaRepository, 
            IAsyncRepository<Cycle> _CycleRepository, 
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AgendaRepository = _AgendaRepository;
            this._CycleRepository = _CycleRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<AgendaListVm>>> Handle(GetAgendaByCycleIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntity = Request.CycleId == null
                ? await _CycleRepository.FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active)
                : await _CycleRepository.FirstOrDefaultAsync(x => x.Id == Request.CycleId);

            if (CycleEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no active cycle yet"
                    : "لا يوجد دورات فعالة ";

                return new BaseResponse<List<AgendaListVm>>(ResponseMessage, false, 400);
            }

            IReadOnlyList<Agenda> AgendaEntities = new List<Agenda>();

            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                AgendaEntities = _AgendaRepository
                    .Where(x => x.CycleId == CycleEntity.Id && !x.IsPrivate)
                    .OrderByDescending(x => x.StartDate)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToList();
            }
            else
            {
                AgendaEntities = _AgendaRepository
                    .Where(x => x.CycleId == CycleEntity.Id && !x.IsPrivate)
                    .OrderByDescending(x => x.StartDate)
                    .ToList();
            }
            
            foreach (Agenda AgendaEntity in AgendaEntities)
            {
                if (DateTime.Now >= AgendaEntity.StartDate && DateTime.Now <= AgendaEntity.EndDate)
                    AgendaEntity.Status = Domain.Constants.AgendaConstants.AgendaStatus.Active;

                else if (DateTime.Now > AgendaEntity.StartDate && DateTime.Now > AgendaEntity.EndDate)
                    AgendaEntity.Status = Domain.Constants.AgendaConstants.AgendaStatus.Previous;

                else if (DateTime.Now < AgendaEntity.StartDate && DateTime.Now < AgendaEntity.EndDate)
                    AgendaEntity.Status = Domain.Constants.AgendaConstants.AgendaStatus.Later;

                await _AgendaRepository.UpdateAsync(AgendaEntity);
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
                .GetCount(x => !x.IsPrivate && x.CycleId == CycleEntity.Id);

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);
            
            return new BaseResponse<List<AgendaListVm>>(ResponseMessage, true, 200, Response,Pagination);
        }
    }
}
