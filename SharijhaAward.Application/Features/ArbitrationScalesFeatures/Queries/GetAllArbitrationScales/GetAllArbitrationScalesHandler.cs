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
        public GetAllArbitrationScalesHandler(IAsyncRepository<ArbitrationScalesCriterion> ArbitrationScalesCriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository)
        {
            _ArbitrationScalesCriterionRepository = ArbitrationScalesCriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
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

            List<CriterionItem> ListOfCriterionItemEntities = await _CriterionItemRepository
                .Include(x => x.Criterion!)
                .Include(x => x.Criterion!.Parent!)
                .Where(x => x.Criterion!.CategoryId == Request.SubCategoryId)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
            
            List<Criterion> AllMainCriterionsEntities = ListOfCriterionItemEntities
                .Where(x => x.Criterion!.ParentId is { })
                .Select(x => x.Criterion!)
                .ToList();

            List<Criterion> AllSubCriterionsEntities = ListOfCriterionItemEntities
                .Select(x => x.Criterion!)
                .Except(AllMainCriterionsEntities)
                .ToList();

            List<MainCriterionDto> ListOfMainCriterionDto = new List<MainCriterionDto>();
            List<ArbitrationScaleDto> ListOfArbitrationScaleDto = ArbitrationScalesCriterionEntities
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
                        : MainCriterionEntity.ArabicTitle
                };

                List<Criterion> SubCriterionsEntities = AllSubCriterionsEntities
                    .Where(x => x.ParentId == MainCriterionEntity.Id)
                    .ToList();

                MainCriterionDto.SubCriterionDto = SubCriterionsEntities
                    .Select(x => new SubCriterionDto()
                    {
                        Id = x.Id,
                        Title = Request.lang == "en"
                            ? MainCriterionEntity.EnglishTitle
                            : MainCriterionEntity.ArabicTitle
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
                                    : x.ArabicName
                            }).ToList();

                        foreach (CriterionItemDto CriterionItemDto in SubCriterionDto.CriterionItemDto)
                        {
                            List<ArbitrationScalesCriterion> SubCriterionArbitrationScalesCriterion = ArbitrationScalesCriterionEntities
                                .Where(x => x.CriterionItemId != null && x.CriterionItemId == CriterionItemDto.Id)
                                .OrderByDescending(x => x.CreatedAt)
                                .ToList();

                            CriterionItemDto.ArbitrationScaleCriterionDto = SubCriterionArbitrationScalesCriterion
                                .Select(x => new ArbitrationScaleCriterionDto()
                                {
                                    Id = x.Id,
                                    CriterionId = null,
                                    CriterionItemId = x.CriterionItemId,
                                    ArabicDescription = x.ArabicDescription,
                                    ArbitrationScaleId = x.ArbitrationScaleId
                                }).ToList();
                        }
                    }
                    else
                    {
                        List<ArbitrationScalesCriterion> SubCriterionArbitrationScalesCriterion = ArbitrationScalesCriterionEntities
                            .Where(x => x.CriterionId != null && x.CriterionId == SubCriterionDto.Id)
                            .OrderByDescending(x => x.CreatedAt)
                            .ToList();

                        SubCriterionDto.ArbitrationScaleCriterionDto = SubCriterionArbitrationScalesCriterion
                            .Select(x => new ArbitrationScaleCriterionDto()
                            {
                                Id = x.Id,
                                ArabicDescription = x.ArabicDescription,
                                ArbitrationScaleId = x.ArbitrationScaleId,
                                CriterionId = x.CriterionId,
                                CriterionItemId = null,
                                EnglishDescription = x.EnglishDescription
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
