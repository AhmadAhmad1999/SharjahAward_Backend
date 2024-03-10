using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Linq;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView
{
    public class GetAllDynamicAttributeSectionsForViewHandler : IRequestHandler<GetAllDynamicAttributeSectionsForViewQuery,
        BaseResponse<List<DynamicAttributeSectionListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IMapper _Mapper;

        public GetAllDynamicAttributeSectionsForViewHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IMapper Mapper)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<DynamicAttributeSectionListVM>>> Handle(GetAllDynamicAttributeSectionsForViewQuery Request,
            CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<DynamicAttributeSectionListVM> DynamicAttributeSections = 
                _DynamicAttributeSectionRepository.IncludeThenWhere(x => x.AttributeTableName!,
                    x => x.RecordIdOnRelation == Request.CategoryId &&
                    x.AttributeTableName!.Name.ToLower() == TableNames.Category.ToString().ToLower())
                .Skip((Request.page - 1) * Request.pageSize)
                .Take(Request.pageSize)
                .Select(x => new DynamicAttributeSectionListVM()
                {
                    Id = x.Id,
                    Name = Language == "ar"
                        ? x.ArabicName
                        : x.EnglishName
                }).ToList();

            string ResponseMessage = string.Empty;

            if (DynamicAttributeSections.Count <= 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no sections"
                    : "لا يوجد أقسام";

                return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, true, 204, DynamicAttributeSections, 0);
            }

            foreach (DynamicAttributeSectionListVM DynamicAttributeSection in DynamicAttributeSections)
            {
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
            }

            int TotalCount = await _DynamicAttributeSectionRepository.GetCountAsync(null);
            
            Pagination PaginationParameter = new Pagination(Request.page, 
                Request.pageSize, TotalCount);

            return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, true, 200, DynamicAttributeSections, PaginationParameter);
        }
    }
}
