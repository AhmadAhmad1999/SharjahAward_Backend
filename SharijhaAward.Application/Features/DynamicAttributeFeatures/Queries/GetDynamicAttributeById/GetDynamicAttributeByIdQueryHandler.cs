using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class GetDynamicAttributeByIdQueryHandler : IRequestHandler<GetDynamicAttributeByIdQuery,
        BaseResponse<GetDynamicAttributeByIdDto>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IMapper _Mapper;

        public GetDynamicAttributeByIdQueryHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IMapper Mapper)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetDynamicAttributeByIdDto>> Handle(GetDynamicAttributeByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            GetDynamicAttributeByIdDto DynamicAttribute = _Mapper.Map<GetDynamicAttributeByIdDto>
                (await _DynamicAttributeRepository.IncludeThenFirstOrDefaultAsync(x => x.AttributeDataType!, 
                    x => x.Id == Request.Id));

            if (DynamicAttribute == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<GetDynamicAttributeByIdDto>(ResponseMessage, false, 404);
            }

            return new BaseResponse<GetDynamicAttributeByIdDto>(ResponseMessage, true, 200, DynamicAttribute);
        }
    }
}