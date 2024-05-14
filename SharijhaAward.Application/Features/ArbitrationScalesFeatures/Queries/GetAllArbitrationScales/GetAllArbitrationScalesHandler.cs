using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationScaleModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class GetAllArbitrationScalesHandler
        : IRequestHandler<GetAllArbitrationScalesQuery, BaseResponse<GetAllArbitrationScalesListVM>>
    {
        private readonly IAsyncRepository<ArbitrationScalesCriterion> _ArbitrationScalesCriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        public GetAllArbitrationScalesHandler(IAsyncRepository<ArbitrationScalesCriterion> ArbitrationScalesCriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<Criterion> CriterionRepository)
        {
            _ArbitrationScalesCriterionRepository = ArbitrationScalesCriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionRepository = CriterionRepository;
        }
        public async Task<BaseResponse<GetAllArbitrationScalesListVM>> 
            Handle(GetAllArbitrationScalesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<ArbitrationScalesCriterion> ArbitrationScalesCriterionEntities = await _ArbitrationScalesCriterionRepository
                .Include(x => x.ArbitrationScale!)
                .Include(x => x.Criterion!)
                .Where(x => x.ArbitrationScale!.CategoryId == Request.SubCategoryId)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            List<Criterion> AllCriterions = await _CriterionRepository
                .Where(x => x.CategoryId == Request.SubCategoryId)
                .Include(x => x.Parent!)
                .ToListAsync();

            List<Criterion> AllMainCriterionsEntities = AllCriterions
                .Where(x => x.ParentId == null)
                .ToList();

            List<Criterion> AllSubCriterionsEntities = AllCriterions
                .Where(x => x.ParentId != null)
                .ToList();

            List<CriterionItem> ListOfCriterionItemEntities = await _CriterionItemRepository
                .Where(x => AllSubCriterionsEntities.Select(y => y.Id).Contains(x.CriterionId))
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
            
            List<MainCriterionDto> ListOfMainCriterionDto = new List<MainCriterionDto>();
            List<ArbitrationScaleDto> ListOfArbitrationScaleDto = ArbitrationScalesCriterionEntities
                .DistinctBy(x => x.ArbitrationScaleId)
                .OrderBy(x => x.Id)
                .Select(x => x.ArbitrationScale!)
                .Select(x => new ArbitrationScaleDto()
                {
                    Id = x.Id,
                    ArabicTitle = x.ArabicTitle,
                    DegreeScale = x.DegreeScale,
                    EnglishTitle = x.EnglishTitle
                }).ToList();

            foreach (Criterion MainCriterionEntity in AllMainCriterionsEntities)
            {
                MainCriterionDto MainCriterionDto = new MainCriterionDto()
                {
                    Id = MainCriterionEntity.Id,
                    Title = Request.lang == "en"
                        ? MainCriterionEntity.EnglishTitle
                        : MainCriterionEntity.ArabicTitle,
                    Score = MainCriterionEntity.Score
                };

                List<Criterion> SubCriterionsEntities = AllSubCriterionsEntities
                    .Where(x => x.ParentId == MainCriterionEntity.Id)
                    .ToList();

                MainCriterionDto.SubCriterionDto = SubCriterionsEntities
                    .Select(x => new SubCriterionDto()
                    {
                        Id = x.Id,
                        Title = Request.lang == "en"
                            ? x.EnglishTitle
                            : x.ArabicTitle,
                        Score = x.Score
                    }).ToList();

                foreach (SubCriterionDto SubCriterionDto in MainCriterionDto.SubCriterionDto)
                {
                    List<CriterionItem> CheckIfThereIsItemsForThisSubCriterion = await _CriterionItemRepository
                        .Where(x => x.CriterionId == SubCriterionDto.Id)
                        .OrderByDescending(x => x.CreatedAt)
                        .ToListAsync();

                    if (CheckIfThereIsItemsForThisSubCriterion.Any())
                    {
                        SubCriterionDto.CriterionItemDto = CheckIfThereIsItemsForThisSubCriterion
                            .Select(x => new CriterionItemDto()
                            {
                                Id = x.Id,
                                Name = Request.lang == "en"
                                    ? x.EnglishName
                                    : x.ArabicName,
                                Score = x.Score
                            }).ToList();

                        foreach (CriterionItemDto CriterionItemDto in SubCriterionDto.CriterionItemDto)
                        {
                            List<ArbitrationScalesCriterion> SubCriterionArbitrationScalesCriterion = ArbitrationScalesCriterionEntities
                                .Where(x => x.CriterionItemId != null && x.CriterionItemId == CriterionItemDto.Id)
                                .OrderBy(x => x.ArbitrationScaleId)
                                .ToList();

                            CriterionItemDto.ArbitrationScaleCriterionDto = SubCriterionArbitrationScalesCriterion
                                .Select(x => new ArbitrationScaleCriterionDto()
                                {
                                    Id = x.Id,
                                    CriterionId = null,
                                    CriterionItemId = x.CriterionItemId,
                                    ArabicDescription = x.ArabicDescription,
                                    ArbitrationScaleId = x.ArbitrationScaleId,
                                    ScaleId = x.ArbitrationScaleId
                                }).ToList();
                        }
                    }
                    else
                    {
                        List<ArbitrationScalesCriterion> SubCriterionArbitrationScalesCriterion = ArbitrationScalesCriterionEntities
                            .Where(x => x.CriterionId != null && x.CriterionId == SubCriterionDto.Id)
                            .OrderBy(x => x.ArbitrationScaleId)
                            .ToList();

                        SubCriterionDto.ArbitrationScaleCriterionDto = SubCriterionArbitrationScalesCriterion
                            .Select(x => new ArbitrationScaleCriterionDto()
                            {
                                Id = x.Id,
                                ArabicDescription = x.ArabicDescription,
                                ArbitrationScaleId = x.ArbitrationScaleId,
                                CriterionId = x.CriterionId,
                                CriterionItemId = null,
                                EnglishDescription = x.EnglishDescription,
                                ScaleId = x.ArbitrationScaleId
                            }).ToList();
                    }
                }

                ListOfMainCriterionDto.Add(MainCriterionDto);
            }

            GetAllArbitrationScalesListVM Response = new GetAllArbitrationScalesListVM()
            {
                MainCriterionDto = ListOfMainCriterionDto,
                ArbitrationScaleDto = ListOfArbitrationScaleDto
            };

            return new BaseResponse<GetAllArbitrationScalesListVM>(ResponseMessage, true, 200, Response);
        }
    }
}
