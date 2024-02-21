using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributes;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSections
{
    public class GetAllDynamicAttributeSectionsQueryHandler : IRequestHandler<GetAllDynamicAttributeSectionsQuery,
        List<DynamicAttributeSectionListVM>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IMapper _Mapper;

        public GetAllDynamicAttributeSectionsQueryHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IMapper Mapper)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }
        public async Task<List<DynamicAttributeSectionListVM>> Handle(GetAllDynamicAttributeSectionsQuery Request, CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<DynamicAttributeSectionListVM> DynamicAttributeSections = _Mapper.Map<List<DynamicAttributeSectionListVM>>
                (_DynamicAttributeSectionRepository.GetPagedReponseAsync(Request.page, Request.pageSize).Result
                .Select(x => new DynamicAttributeSectionListVM()
                {
                    Id = x.Id,
                    Name = Language == "ar"
                        ? x.ArabicName
                        : x.EnglishName
                }));

            foreach (DynamicAttributeSectionListVM DynamicAttributeSection in DynamicAttributeSections)
            {
                DynamicAttributeSection.DynamicAttributes = _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                    .Include(x => x.AttributeDataType)
                    .Select(x => new DynamicAttributeListVM()
                    {
                        Id = x.Id,
                        Key = x.Key,
                        AttributeDataTypeName = x.AttributeDataType.Name,
                        Label = Language.ToLower() == "ar"
                            ? x.ArabicLabel
                            : x.EnglishLabel, 
                        PlaceHolder = Language.ToLower() == "ar"
                            ? x.ArabicPlaceHolder
                            : x.EnglishPlaceHolder,
                        Status = x.Status.ToString()
                    }).ToList();
            }

            return DynamicAttributeSections;
        }
    }
}
