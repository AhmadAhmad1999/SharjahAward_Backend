using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm
{
    public class GetAllInitialArbitrationOnFormHandler
        : IRequestHandler<GetAllInitialArbitrationOnFormQuery, BaseResponse<List<GetAllInitialArbitrationOnFormListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;
        public GetAllInitialArbitrationOnFormHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository,
            IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository,
            IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
            this._ComitteeArbitratorRepository = _ComitteeArbitratorRepository;
            this._ComitteeOfficerRepository = _ComitteeOfficerRepository;
        }
        public async Task<BaseResponse<List<GetAllInitialArbitrationOnFormListVM>>> Handle(GetAllInitialArbitrationOnFormQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                .Where(x => x.ProvidedFormId == Request.FormId)
                .ToListAsync();

            List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                .Where(x => ArbitrationEntities.Select(y => y.Id).Contains(x.ArbitrationId))
                .ToListAsync();

            List<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationEntities = new List<ChairmanNotesOnInitialArbitration>();

            if (Request.asNormalArbitrator)
            {
                List<ComitteeArbitrator> ComitteeArbitratorEntities = await _ComitteeArbitratorRepository
                    .Where(x => ArbitrationEntities.Select(y => y.ArbitratorId).Contains(x.ArbitratorId))
                    .ToListAsync();

                List<int> OfficersIds = await _ComitteeOfficerRepository
                    .Where(x => ComitteeArbitratorEntities.Select(x => x.CommitteeId).Contains(x.CommitteeId))
                    .Select(x => x.ArbitratorId)
                    .ToListAsync();

                if (OfficersIds.Any())
                {
                    ChairmanNotesOnInitialArbitrationEntities = await _ChairmanNotesOnInitialArbitrationRepository
                        .Where(x => InitialArbitrationEntities.Select(y => y.Id).Contains(x.InitialArbitrationId) &&
                            OfficersIds.Contains(x.ChairmanId))
                        .ToListAsync();
                }
                else
                {
                    List<int> ChairmansIds = ComitteeArbitratorEntities
                        .Select(x => x.Committee!.ChairmanId)
                        .ToList();

                    ChairmanNotesOnInitialArbitrationEntities = await _ChairmanNotesOnInitialArbitrationRepository
                        .Where(x => InitialArbitrationEntities.Select(y => y.Id).Contains(x.InitialArbitrationId) &&
                            ChairmansIds.Contains(x.ChairmanId))
                        .ToListAsync();
                }
            }
            else
            {
                List<int> ComitteeOfficerEntities = await _ComitteeOfficerRepository
                    .Where(x => ArbitrationEntities.Select(y => y.ArbitratorId).Contains(x.ArbitratorId))
                    .Select(x => x.Committee!.ChairmanId)
                    .ToListAsync();

                ChairmanNotesOnInitialArbitrationEntities = await _ChairmanNotesOnInitialArbitrationRepository
                    .Where(x => InitialArbitrationEntities.Select(y => y.Id).Contains(x.InitialArbitrationId) &&
                        ComitteeOfficerEntities.Contains(x.ChairmanId))
                    .ToListAsync();
            }

            List<GetAllInitialArbitrationOnFormListVM> Response = new List<GetAllInitialArbitrationOnFormListVM>();

            List<IGrouping<int, Arbitration>> GroupOfArbitrationEntities = ArbitrationEntities
                .OrderByDescending(x => x.CreatedAt)
                .GroupBy(x => x.ArbitratorId)
                .ToList();

            foreach (IGrouping<int, Arbitration> GroupOfArbitrationEntity in GroupOfArbitrationEntities)
            {
                GetAllInitialArbitrationOnFormListVM NewValueForResponse = new GetAllInitialArbitrationOnFormListVM()
                {
                    ArbitratorId = GroupOfArbitrationEntity.Key,
                    ArbitratorName = Request.lang == "en"
                        ? GroupOfArbitrationEntity.FirstOrDefault()!.Arbitrator!.EnglishName
                        : GroupOfArbitrationEntity.FirstOrDefault()!.Arbitrator!.ArabicName,
                    Type = GroupOfArbitrationEntity.FirstOrDefault()!.Type
                };

                foreach (Arbitration ArbitrationEntityFromGroup in GroupOfArbitrationEntity)
                {
                    EachArbitrationDto EachArbitrationDto = new EachArbitrationDto();

                    EachArbitrationDto.ArbitrationId = ArbitrationEntityFromGroup.Id;

                    List<InitialArbitration> InitialArbitrationEntitiesForThisArbitration = InitialArbitrationEntities
                        .Where(x => x.ArbitrationId == ArbitrationEntityFromGroup.Id)
                        .ToList();

                    foreach (InitialArbitration InitialArbitrationEntityForThisArbitration in InitialArbitrationEntitiesForThisArbitration)
                    {
                        InitialArbitrationDto InitialArbitrationDto = new InitialArbitrationDto()
                        {
                            Id = InitialArbitrationEntityForThisArbitration.Id,
                            CriterionId = InitialArbitrationEntityForThisArbitration.CriterionId,
                            Criterion_Name = InitialArbitrationEntityForThisArbitration.CriterionId != null
                                ? (Request.lang == "en"
                                    ? InitialArbitrationEntityForThisArbitration.Criterion!.EnglishTitle
                                    : InitialArbitrationEntityForThisArbitration.Criterion!.ArabicTitle)
                                : null,
                            CriterionItemId = InitialArbitrationEntityForThisArbitration.CriterionItemId,
                            CriterionItemName = InitialArbitrationEntityForThisArbitration.CriterionItemId != null
                                ? (Request.lang == "en"
                                    ? InitialArbitrationEntityForThisArbitration.CriterionItem!.EnglishName
                                    : InitialArbitrationEntityForThisArbitration.CriterionItem!.ArabicName)
                                : null,
                            StrengthPoint = InitialArbitrationEntityForThisArbitration.StrengthPoint,
                            ImprovementAreas = InitialArbitrationEntityForThisArbitration.ImprovementAreas,
                            ArbitrationScore = InitialArbitrationEntityForThisArbitration.ArbitrationScore
                        };

                        InitialArbitrationDto.ChairmanNotesOnInitialArbitrationDtos = ChairmanNotesOnInitialArbitrationEntities
                            .Where(x => x.InitialArbitrationId == InitialArbitrationEntityForThisArbitration.Id)
                            .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                            {
                                Id = x.Id,
                                Note = x.Note,
                                CreatedAt = x.CreatedAt,
                                ChairmanId = x.ChairmanId,
                                ChairmanName = Request.lang == "en"
                                    ? x.Chairman!.EnglishName
                                    : x.Chairman!.ArabicName,
                                ChairmanEmail = x.Chairman!.Email
                            }).ToList();

                        EachArbitrationDto.InitialArbitrationDtos.Add(InitialArbitrationDto);
                    }
                }

                Response.Add(NewValueForResponse);
            }

            return new BaseResponse<List<GetAllInitialArbitrationOnFormListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
