using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllSubCategories
{
    public class GetAllSubCategoriesHandler 
        : IRequestHandler<GetAllSubCategoriesQuery, BaseResponse<List<GetAllSubCategoriesListVM>>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;

        public GetAllSubCategoriesHandler(IAsyncRepository<Category> CategoryRepository, IAsyncRepository<Cycle> cycleRepository)
        {
            _CategoryRepository = CategoryRepository;
            _cycleRepository = cycleRepository;
        }

        public async Task<BaseResponse<List<GetAllSubCategoriesListVM>>> 
            Handle(GetAllSubCategoriesQuery Request, CancellationToken cancellationToken)
        {
            var Cycle = Request.CycleId == null
                ? await _cycleRepository.FirstOrDefaultAsync(c=>c.Status == Domain.Constants.Common.Status.Active)
                : await _cycleRepository.FirstOrDefaultAsync(c=>c.Id == Request.CycleId);
            if(Cycle == null)
            {
                return new BaseResponse<List<GetAllSubCategoriesListVM>>("الدورة غير موجودة", false, 400);
            }

            List<GetAllSubCategoriesListVM> CategoriesEntities = await _CategoryRepository
                .Where(x => x.ParentId != null && x.CycleId == Cycle!.Id)
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new GetAllSubCategoriesListVM()
                {
                    Id = x.Id,
                    CategoryName = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName,
                    SortingFormsStartDate = x.SortingFormsStartDate,
                    SortingFormsEndDate = x.SortingFormsEndDate,
                    InitialArbitrationStartDate = x.InitialArbitrationStartDate,
                    InitialArbitrationEndDate = x.InitialArbitrationEndDate,
                    FinalArbitrationStartDate= x.FinalArbitrationStartDate,
                    FinalArbitrationEndDate= x.FinalArbitrationEndDate,
                    ArbitrationAuditStartDate = x.ArbitrationAuditStartDate,
                    ArbitrationAuditEndDate = x.ArbitrationAuditEndDate,
                    MarginOfDifferenceBetweenArbitrators = x.MarginOfDifferenceBetweenArbitrators
                }).ToListAsync();

            return new BaseResponse<List<GetAllSubCategoriesListVM>>(string.Empty, true, 200, CategoriesEntities);
        }
    }
}
