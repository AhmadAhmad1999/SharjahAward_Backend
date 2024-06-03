using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using System.Text.RegularExpressions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllListAdvancedFormBuilders
{
    public class GetAllListAdvancedFormBuildersHandler : IRequestHandler<GetAllListAdvancedFormBuildersQuery, BaseResponse<List<GetAllListAdvancedFormBuildersListVM>>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        public GetAllListAdvancedFormBuildersHandler(IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository)
        {
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
        }

        public async Task<BaseResponse<List<GetAllListAdvancedFormBuildersListVM>>> Handle(GetAllListAdvancedFormBuildersQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilderSection? AdvancedFormBuilderSectionEntity = await _AdvancedFormBuilderSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.SectionId);

            if (AdvancedFormBuilderSectionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section is not Found"
                    : "القسم غير موجود";

                return new BaseResponse<List<GetAllListAdvancedFormBuildersListVM>>(ResponseMessage, false, 404);
            }

            List<AdvancedFormBuilder> AdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                .Where(x => x.AttributeDataTypeId == 8 &&
                    x.AdvancedFormBuilderSectionId == AdvancedFormBuilderSectionEntity.Id)
                .ToListAsync();

            List<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueEntities = await _AdvancedFormBuilderListValueRepository
                .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                .ToListAsync();

            if (Request.lang == "en")
            {
                List<GetAllListAdvancedFormBuildersListVM> GetAllListAdvancedFormBuildersListVM = AdvancedFormBuilderEntities
                    .Select(x => new GetAllListAdvancedFormBuildersListVM()
                    {
                        Id = x.Id,
                        Label = x.EnglishLabel,
                        Values = AdvancedFormBuilderListValueEntities
                            .Where(y => y.AdvancedFormBuilderId == x.Id &&
                                !Regex.IsMatch(y.Value, @"\p{IsArabic}"))
                            .Select(y => new AdvancedFormBuilderListValueDto()
                            {
                                Id = y.Id,
                                Value = y.Value
                            }).ToList()
                    }).ToList();

                return new BaseResponse<List<GetAllListAdvancedFormBuildersListVM>>(ResponseMessage, true, 200, GetAllListAdvancedFormBuildersListVM);
            }
            else
            {
                List<GetAllListAdvancedFormBuildersListVM> GetAllListAdvancedFormBuildersListVM = AdvancedFormBuilderEntities
                    .Select(x => new GetAllListAdvancedFormBuildersListVM()
                    {
                        Id = x.Id,
                        Label = x.ArabicLabel,
                        Values = AdvancedFormBuilderListValueEntities
                            .Where(y => y.AdvancedFormBuilderId == x.Id &&
                                Regex.IsMatch(y.Value, @"\p{IsArabic}"))
                            .Select(y => new AdvancedFormBuilderListValueDto()
                            {
                                Id = y.Id,
                                Value = y.Value
                            }).ToList()
                    }).ToList();

                return new BaseResponse<List<GetAllListAdvancedFormBuildersListVM>>(ResponseMessage, true, 200, GetAllListAdvancedFormBuildersListVM);
            }
        }
    }
}
