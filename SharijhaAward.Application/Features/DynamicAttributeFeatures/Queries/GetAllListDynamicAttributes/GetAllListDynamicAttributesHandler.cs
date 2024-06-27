using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllListDynamicAttributes
{
    public class GetAllListDynamicAttributesHandler : IRequestHandler<GetAllListDynamicAttributesQuery, BaseResponse<List<GetAllListDynamicAttributesListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        public GetAllListDynamicAttributesHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
        }

        public async Task<BaseResponse<List<GetAllListDynamicAttributesListVM>>> Handle(GetAllListDynamicAttributesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttributeSection? DynamicAttributeSectionEntity = null;

            if (Request.SectionId is not null)
            {
                DynamicAttributeSectionEntity = await _DynamicAttributeSectionRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.SectionId);

                if (DynamicAttributeSectionEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Section is not Found"
                        : "القسم غير موجود";

                    return new BaseResponse<List<GetAllListDynamicAttributesListVM>>(ResponseMessage, false, 404);
                }
            }

            List<DynamicAttribute> DynamicAttributeEntities = await _DynamicAttributeRepository
                .Where(x => x.AttributeDataTypeId == 8 &&
                    DynamicAttributeSectionEntity != null 
                        ? x.DynamicAttributeSectionId == DynamicAttributeSectionEntity.Id
                        : true)
                .ToListAsync();

            List<DynamicAttributeListValue> DynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                .ToListAsync();

            if (Request.lang == "en")
            {
                List<GetAllListDynamicAttributesListVM> GetAllListDynamicAttributesListVM = DynamicAttributeEntities
                    .Select(x => new GetAllListDynamicAttributesListVM()
                    {
                        Id = x.Id,
                        Label = x.EnglishLabel,
                        Values = DynamicAttributeListValueEntities
                            .Where(y => y.DynamicAttributeId == x.Id)
                            .Select(y => new DynamicAttributeListValueDto()
                            {
                                Id = y.Id,
                                Value = y.EnglishValue
                            }).ToList()
                    }).ToList();

                return new BaseResponse<List<GetAllListDynamicAttributesListVM>>(ResponseMessage, true, 200, GetAllListDynamicAttributesListVM);
            }
            else
            {
                List<GetAllListDynamicAttributesListVM> GetAllListDynamicAttributesListVM = DynamicAttributeEntities
                    .Select(x => new GetAllListDynamicAttributesListVM()
                    {
                        Id = x.Id,
                        Label = x.ArabicLabel,
                        Values = DynamicAttributeListValueEntities
                            .Where(y => y.DynamicAttributeId == x.Id)
                            .Select(y => new DynamicAttributeListValueDto()
                            {
                                Id = y.Id,
                                Value = y.ArabicValue
                            }).ToList()
                    }).ToList();

                return new BaseResponse<List<GetAllListDynamicAttributesListVM>>(ResponseMessage, true, 200, GetAllListDynamicAttributesListVM);
            }
        }
    }
}
