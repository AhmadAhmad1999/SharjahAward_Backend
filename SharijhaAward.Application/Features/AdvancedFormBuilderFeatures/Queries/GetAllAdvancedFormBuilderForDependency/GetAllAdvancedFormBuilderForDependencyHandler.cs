using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuilderForDependency
{
    public class GetAllAdvancedFormBuilderForDependencyHandler : IRequestHandler<GetAllAdvancedFormBuilderForDependencyQuery,
        BaseResponse<List<GetAllAdvancedFormBuilderForDependencyListVM>>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        public GetAllAdvancedFormBuilderForDependencyHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
        }
        public async Task<BaseResponse<List<GetAllAdvancedFormBuilderForDependencyListVM>>> 
            Handle(GetAllAdvancedFormBuilderForDependencyQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllAdvancedFormBuilderForDependencyListVM> DynamicAttributes = await _AdvancedFormBuilderRepository
                .Where(x => x.AdvancedFormBuilderSection!.VirtualTableForSectionId == Request.VirtualTableForSectionId &&
                    !x.AdvancedFormBuilderSection!.TableTypeSection)
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new GetAllAdvancedFormBuilderForDependencyListVM()
                {
                    Id = x.Id,
                    Label = Language == "ar"
                        ? x.ArabicLabel
                        : x.EnglishLabel
                }).ToListAsync();

            return new BaseResponse<List<GetAllAdvancedFormBuilderForDependencyListVM>>(ResponseMessage, true, 200, DynamicAttributes, 0);
        }
    }
}
