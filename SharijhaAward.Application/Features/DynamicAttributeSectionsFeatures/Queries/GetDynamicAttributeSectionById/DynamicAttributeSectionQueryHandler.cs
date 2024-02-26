using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSections;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById
{
    public class DynamicAttributeSectionQueryHandler : IRequestHandler<DynamicAttributeSectionQuery, BaseResponse<DynamicAttributeSectionDto>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IMapper _Mapper;

        public DynamicAttributeSectionQueryHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IMapper Mapper)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<DynamicAttributeSectionDto>> Handle(DynamicAttributeSectionQuery Request, CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            DynamicAttributeSectionDto DynamicAttributeSection = _Mapper.Map<DynamicAttributeSectionDto>
                (await _DynamicAttributeSectionRepository.Where(x => x.Id == Request.Id)
                    .Select(x => new DynamicAttributeSectionDto()
                    {
                        Id = x.Id,
                        Name = Language == "ar"
                            ? x.ArabicName
                            : x.EnglishName
                    }).FirstOrDefaultAsync());

            string ResponseMessage = string.Empty;
            if (DynamicAttributeSection == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"There is no section with this id: {Request.Id}"
                    : $"لا يوجد قسم بهذا المعرف: {Request.Id}";

                return new BaseResponse<DynamicAttributeSectionDto>(ResponseMessage, false, 404);
            }

            DynamicAttributeSection.DynamicAttributes = _DynamicAttributeRepository
                .WhereThenInclude(x => x.DynamicAttributeSectionId == DynamicAttributeSection.Id,
                    x => x.AttributeDataType!)
                .Select(x => new DynamicAttributeListVM()
                {
                    Id = x.Id,
                    Key = x.Key,
                    AttributeDataTypeName = x.AttributeDataType!.Name,
                    Label = Language.ToLower() == "ar"
                        ? x.ArabicLabel
                        : x.EnglishLabel,
                    PlaceHolder = Language.ToLower() == "ar"
                        ? x.ArabicPlaceHolder
                        : x.EnglishPlaceHolder,
                    Status = x.Status.ToString()
                }).ToList();

            ResponseMessage = Request.lang == "en"
                ? "The section are retrieved successfully"
                : "تم إسترجاع القسم بنجاح";

            return new BaseResponse<DynamicAttributeSectionDto>(ResponseMessage, false, 200, DynamicAttributeSection);
        }
    }
}
