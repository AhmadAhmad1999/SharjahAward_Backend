using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationScaleModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetArbitrationScaleById
{
    public class GetArbitrationScaleByIdHandler
        : IRequestHandler<GetArbitrationScaleByIdQuery, BaseResponse<GetArbitrationScaleByIdListVM>>
    {
        private readonly IAsyncRepository<ArbitrationScalesCriterion> _ArbitrationScalesCriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        public GetArbitrationScaleByIdHandler(IAsyncRepository<ArbitrationScalesCriterion> ArbitrationScalesCriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<Criterion> CriterionRepository)
        {
            _ArbitrationScalesCriterionRepository = ArbitrationScalesCriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionRepository = CriterionRepository;
        }

        public async Task<BaseResponse<GetArbitrationScaleByIdListVM>> 
            Handle(GetArbitrationScaleByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<ArbitrationScalesCriterion> ArbitrationScalesCriterionEntities = await _ArbitrationScalesCriterionRepository
                .Where(x => x.CriterionId == Request.CriterionId &&
                    x.CriterionItemId == Request.CriterionItemId)
                .ToListAsync();

            List<ArbitrationScaleDto> ListOfArbitrationScaleDto = ArbitrationScalesCriterionEntities
                .DistinctBy(x => x.ArbitrationScaleId)
                .OrderBy(x => x.Id)
                .Select(x => new ArbitrationScaleDto()
                {
                    Id = x.Id,
                    ArabicTitle = x.ArbitrationScale!.ArabicTitle,
                    DegreeScale = x.ArbitrationScale!.DegreeScale,
                    EnglishTitle = x.ArbitrationScale!.EnglishTitle,
                    Title = Request.lang == "en"
                        ? x.ArbitrationScale!.EnglishTitle
                        : x.ArbitrationScale!.ArabicTitle,
                    ArabicDescription = x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription
                }).ToList();

            GetArbitrationScaleByIdListVM Response = new GetArbitrationScaleByIdListVM()
            {
                ArbitrationScaleDto = ListOfArbitrationScaleDto
            };

            return new BaseResponse<GetArbitrationScaleByIdListVM>(ResponseMessage, true, 200, Response);
        }
    }
}
