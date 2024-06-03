using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAdvancedFormBuilderSectionById
{
    public class GetAdvancedFormBuilderSectionByIdHanlder : IRequestHandler<GetAdvancedFormBuilderSectionByIdQuery,
        BaseResponse<GetAdvancedFormBuilderSectionByIdDto>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;

        public GetAdvancedFormBuilderSectionByIdHanlder(IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository)
        {
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
        }

        public async Task<BaseResponse<GetAdvancedFormBuilderSectionByIdDto>> 
            Handle(GetAdvancedFormBuilderSectionByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            GetAdvancedFormBuilderSectionByIdDto? AdvancedFormBuilderSection = await _AdvancedFormBuilderSectionRepository.Where(x => x.Id == Request.Id)
                .Select(x => new GetAdvancedFormBuilderSectionByIdDto()
                {
                    Id = x.Id,
                    ArabicName = x.ArabicName,
                    EnglishName = x.EnglishName,
                    TableTypeSection = x.TableTypeSection
                }).FirstOrDefaultAsync();

            if (AdvancedFormBuilderSection == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section not found"
                    : "هذا القسم غير موجود";

                return new BaseResponse<GetAdvancedFormBuilderSectionByIdDto>(ResponseMessage, false, 404);
            }

            AdvancedFormBuilderSection.AdvancedFormBuilders = _AdvancedFormBuilderRepository
                .WhereThenInclude(x => x.AdvancedFormBuilderSectionId == AdvancedFormBuilderSection.Id,
                    x => x.AttributeDataType!)
                .Select(x => new AdvancedFormBuilderListVM()
                {
                    Id = x.Id,
                    AttributeDataTypeName = x.AttributeDataType!.Name,
                    Label = Language.ToLower() == "ar"
                        ? x.ArabicLabel
                        : x.EnglishLabel,
                    PlaceHolder = Language.ToLower() == "ar"
                        ? x.ArabicPlaceHolder
                        : x.EnglishPlaceHolder,
                    Status = x.Status.ToString()
                }).ToList();

            return new BaseResponse<GetAdvancedFormBuilderSectionByIdDto>(ResponseMessage, true, 200, AdvancedFormBuilderSection);
        }
    }
}
