using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class GetInitialArbitrationByArbitrationIdHandler
        : IRequestHandler<GetInitialArbitrationByArbitrationIdQuery, BaseResponse<List<MainCriterionDto>>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;

        public GetInitialArbitrationByArbitrationIdHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository)
        {
            _CriterionRepository = CriterionRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
        }
        public async Task<BaseResponse<List<MainCriterionDto>>> Handle(GetInitialArbitrationByArbitrationIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitration? ArbitrationEntity = await _ArbitrationRepository
                .Include(x => x.ProvidedForm!)
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitrationId);

            if (ArbitrationEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration is not Found"
                    : "التحكيم غير موجود";

                return new BaseResponse<List<MainCriterionDto>>(ResponseMessage, false, 404);
            }

            int CategoryId = ArbitrationEntity.ProvidedForm!.categoryId;

            List<Criterion> AllCriterionEntities = await _CriterionRepository
                .Where(x => x.CategoryId == CategoryId)
                .ToListAsync();

            List<Criterion> MainCriterionEntities = AllCriterionEntities
                .Where(x => x.ParentId == null)
                .ToList();

            List<Criterion> SubCriterionEntities = AllCriterionEntities
                .Where(x => x.ParentId != null)
                .ToList();

            List<CriterionAttachment> CriterionAttachmentEntities = await _CriterionAttachmentRepository
                .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId))
                .ToListAsync();

            List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId))
                .ToListAsync();

            List<CriterionItemAttachment> CriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                .Where(x => CriterionItemEntities.Select(y => y.Id).Any(y => y == x.CriterionItemId))
                .ToListAsync();

            List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                .Where(x => x.ArbitrationId == ArbitrationEntity.Id)
                .ToListAsync();

            List<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationEntities = await _ChairmanNotesOnInitialArbitrationRepository
                .Where(x => InitialArbitrationEntities.Select(y => y.Id).Any(y => y == x.InitialArbitrationId))
                .ToListAsync();

            List<MainCriterionDto> FullResponse = new List<MainCriterionDto>();

            foreach (Criterion MainCriterionEntity in MainCriterionEntities)
            {
                MainCriterionDto MainCriterionDto = new MainCriterionDto()
                {
                    Title = Request.lang == "en"
                        ? MainCriterionEntity.EnglishTitle
                        : MainCriterionEntity.ArabicTitle
                };

                List<Criterion> SubCriterionEntitiesForThisMainCriterion = SubCriterionEntities
                    .Where(x => x.ParentId == MainCriterionEntity.Id)
                    .ToList();

                foreach (Criterion SubCriterionEntityForThisMainCriterion in SubCriterionEntitiesForThisMainCriterion)
                {
                    SubCriterionDto SubCriterionDto = new SubCriterionDto()
                    {
                        Title = Request.lang == "en"
                            ? SubCriterionEntityForThisMainCriterion.EnglishTitle
                            : SubCriterionEntityForThisMainCriterion.ArabicTitle,
                        SubCriterionScore = SubCriterionEntityForThisMainCriterion.Score
                    };

                    List<CriterionItem> CriterionItemEntitiesForThisSubCriterion = CriterionItemEntities
                        .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                        .ToList();

                    if (!CriterionItemEntitiesForThisSubCriterion.Any())
                    {
                        SubCriterionDto.SubCriterionItemDtos = null;

                        InitialArbitration? InitialArbitrationEntitiesForThisSubCriterion = InitialArbitrationEntities
                            .FirstOrDefault(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id && x.CriterionItemId == null);

                        if (InitialArbitrationEntitiesForThisSubCriterion is null)
                        {
                            SubCriterionDto.StrengthPoint = null;
                            SubCriterionDto.ImprovementAreas = null;
                            SubCriterionDto.ArbitrationScore = 0;
                            SubCriterionDto.ChairmanNotesOnInitialArbitrationDtos = null;

                            SubCriterionDto.SubCriterionAttachmanetsDto = CriterionAttachmentEntities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                                .Select(x => new AttachmanetsDto()
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    Description = x.Description,
                                    AttachementPath = x.AttachementPath
                                }).ToList();
                        }
                        else
                        {
                            SubCriterionDto.StrengthPoint = InitialArbitrationEntitiesForThisSubCriterion.StrengthPoint;
                            SubCriterionDto.ImprovementAreas = InitialArbitrationEntitiesForThisSubCriterion.ImprovementAreas;
                            SubCriterionDto.ArbitrationScore = InitialArbitrationEntitiesForThisSubCriterion.ArbitrationScore;

                            SubCriterionDto.ChairmanNotesOnInitialArbitrationDtos = ChairmanNotesOnInitialArbitrationEntities
                                .Where(x => x.InitialArbitrationId == InitialArbitrationEntitiesForThisSubCriterion.Id)
                                .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                {
                                    Id = x.Id,
                                    Note = x.Note
                                })
                                .OrderBy(x => x.Id)
                                .ToList();

                            SubCriterionDto.SubCriterionAttachmanetsDto = CriterionAttachmentEntities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                                .Select(x => new AttachmanetsDto()
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    Description = x.Description,
                                    AttachementPath = x.AttachementPath
                                }).ToList();
                        }

                        MainCriterionDto.SubCriterionDtos.Add(SubCriterionDto);
                    }
                    else
                    {
                        SubCriterionDto.SubCriterionItemDtos = new List<CriterionItemDto>();

                        SubCriterionDto.StrengthPoint = null;
                        SubCriterionDto.ImprovementAreas = null;
                        SubCriterionDto.ArbitrationScore = 0;
                        SubCriterionDto.SubCriterionAttachmanetsDto = null;
                        SubCriterionDto.ChairmanNotesOnInitialArbitrationDtos = null;

                        foreach (CriterionItem CriterionItemEntityForThisSubCriterion in CriterionItemEntitiesForThisSubCriterion)
                        {
                            CriterionItemDto CriterionItemDto = new CriterionItemDto()
                            {
                                Name = Request.lang == "en"
                                    ? CriterionItemEntityForThisSubCriterion.EnglishName
                                    : CriterionItemEntityForThisSubCriterion.ArabicName,
                                CriterionItemScore = CriterionItemEntityForThisSubCriterion.Score
                            };

                            InitialArbitration? InitialArbitrationEntitiesForThisCriterionItem = InitialArbitrationEntities
                                .FirstOrDefault(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id && x.CriterionId == null);

                            if (InitialArbitrationEntitiesForThisCriterionItem is null)
                            {
                                CriterionItemDto.StrengthPoint = null;
                                CriterionItemDto.ImprovementAreas = null;
                                CriterionItemDto.ArbitrationScore = 0;
                                CriterionItemDto.ChairmanNotesOnInitialArbitrationDtos = new List<ChairmanNotesOnInitialArbitrationDto>();

                                CriterionItemDto.CriterionItemAttachmanetsDto = CriterionItemAttachmentEntities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id)
                                    .Select(x => new AttachmanetsDto()
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Description = x.Description,
                                        AttachementPath = x.AttachementPath
                                    }).ToList();
                            }
                            else
                            {
                                CriterionItemDto.StrengthPoint = InitialArbitrationEntitiesForThisCriterionItem.StrengthPoint;
                                CriterionItemDto.ImprovementAreas = InitialArbitrationEntitiesForThisCriterionItem.ImprovementAreas;
                                CriterionItemDto.ArbitrationScore = InitialArbitrationEntitiesForThisCriterionItem.ArbitrationScore;

                                CriterionItemDto.CriterionItemAttachmanetsDto = CriterionItemAttachmentEntities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id)
                                    .Select(x => new AttachmanetsDto()
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Description = x.Description,
                                        AttachementPath = x.AttachementPath
                                    }).ToList();

                                CriterionItemDto.ChairmanNotesOnInitialArbitrationDtos = ChairmanNotesOnInitialArbitrationEntities
                                    .Where(x => x.InitialArbitrationId == InitialArbitrationEntitiesForThisCriterionItem.Id)
                                    .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                    {
                                        Id = x.Id,
                                        Note = x.Note
                                    })
                                    .OrderBy(x => x.Id)
                                    .ToList();
                            }

                            SubCriterionDto.SubCriterionItemDtos!.Add(CriterionItemDto);
                        }

                        MainCriterionDto.SubCriterionDtos.Add(SubCriterionDto);
                    }
                }

                FullResponse.Add(MainCriterionDto);
            }

            return new BaseResponse<List<MainCriterionDto>>(ResponseMessage, true, 200, FullResponse);
        }
    }
}
