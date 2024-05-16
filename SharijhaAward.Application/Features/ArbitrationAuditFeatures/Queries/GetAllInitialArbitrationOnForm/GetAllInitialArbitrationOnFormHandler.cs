using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm
{
    public class GetAllInitialArbitrationOnFormHandler
        : IRequestHandler<GetAllInitialArbitrationOnFormQuery, BaseResponse<List<GetAllInitialArbitrationOnFormListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;
        public GetAllInitialArbitrationOnFormHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
        }
        public async Task<BaseResponse<List<GetAllInitialArbitrationOnFormListVM>>> Handle(GetAllInitialArbitrationOnFormQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                .Where(x => x.ProvidedFormId == Request.FormId)
                .Include(x => x.Arbitrator!)
                .ToListAsync();

            List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                .Where(x => ArbitrationEntities.Select(y => y.Id).Contains(x.ArbitrationId))
                .Include(x => x.Criterion!)
                .Include(x => x.CriterionItem!)
                .ToListAsync();

            List<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationEntities = await _ChairmanNotesOnInitialArbitrationRepository
                .Where(x => InitialArbitrationEntities.Select(y => y.Id).Contains(x.InitialArbitrationId))
                .ToListAsync();

            List<GetAllInitialArbitrationOnFormListVM> Response = new List<GetAllInitialArbitrationOnFormListVM>();

            foreach (Arbitration ArbitrationEntity in ArbitrationEntities)
            {
                GetAllInitialArbitrationOnFormListVM GetAllInitialArbitrationOnFormListVM = new GetAllInitialArbitrationOnFormListVM()
                {
                    Id = ArbitrationEntity.Id,
                    ArbitratorId = ArbitrationEntity.ArbitratorId,
                    ArbitratorName = Request.lang == "en"
                        ? ArbitrationEntity.Arbitrator!.EnglishName
                        : ArbitrationEntity.Arbitrator!.ArabicName,
                    Type = ArbitrationEntity.Type
                };

                List<InitialArbitration> InitialArbitrationEntitiesForThisArbitration = InitialArbitrationEntities
                    .Where(x => x.ArbitrationId == ArbitrationEntity.Id)
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

                    List<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationEntitiesForThisInitialArbitration = ChairmanNotesOnInitialArbitrationEntities
                        .Where(x => x.InitialArbitrationId == InitialArbitrationEntityForThisArbitration.Id)
                        .ToList();

                    foreach (ChairmanNotesOnInitialArbitration ChairmanNotesOnInitialArbitrationEntityForThisInitialArbitration in ChairmanNotesOnInitialArbitrationEntitiesForThisInitialArbitration)
                    {
                        ChairmanNotesOnInitialArbitrationDto ChairmanNotesOnInitialArbitrationDto = new ChairmanNotesOnInitialArbitrationDto()
                        {
                            Id = ChairmanNotesOnInitialArbitrationEntityForThisInitialArbitration.Id,
                            Note = ChairmanNotesOnInitialArbitrationEntityForThisInitialArbitration.Note
                        };

                        InitialArbitrationDto.ChairmanNotesOnInitialArbitrationDtos.Add(ChairmanNotesOnInitialArbitrationDto);
                    }

                    GetAllInitialArbitrationOnFormListVM.InitialArbitrationDtos.Add(InitialArbitrationDto);
                }

                Response.Add(GetAllInitialArbitrationOnFormListVM);
            }

            return new BaseResponse<List<GetAllInitialArbitrationOnFormListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
