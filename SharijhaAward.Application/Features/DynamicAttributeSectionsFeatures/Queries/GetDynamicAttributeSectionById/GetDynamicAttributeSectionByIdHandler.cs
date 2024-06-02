using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById
{
    public class GetDynamicAttributeSectionByIdHandler : IRequestHandler<GetDynamicAttributeSectionByIdQuery,
        BaseResponse<GetDynamicAttributeSectionByIdDto>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IMapper _Mapper;

        public GetDynamicAttributeSectionByIdHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IMapper Mapper)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetDynamicAttributeSectionByIdDto>> Handle(GetDynamicAttributeSectionByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            GetDynamicAttributeSectionByIdDto? DynamicAttributeSection = await _DynamicAttributeSectionRepository.Where(x => x.Id == Request.Id)
                .Select(x => new GetDynamicAttributeSectionByIdDto()
                {
                    Id = x.Id,
                    ArabicName = x.ArabicName,
                    EnglishName = x.EnglishName,
                    TableTypeSection = x.TableTypeSection
                }).FirstOrDefaultAsync();

            if (DynamicAttributeSection == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section not found"
                    : "هذا القسم غير موجود";

                return new BaseResponse<GetDynamicAttributeSectionByIdDto>(ResponseMessage, false, 404);
            }

            DynamicAttributeSection.DynamicAttributes = _DynamicAttributeRepository
                .WhereThenInclude(x => x.DynamicAttributeSectionId == DynamicAttributeSection.Id,
                    x => x.AttributeDataType!)
                .Select(x => new DynamicAttributeListVM()
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

            return new BaseResponse<GetDynamicAttributeSectionByIdDto>(ResponseMessage, true, 200, DynamicAttributeSection);
        }
    }
}
