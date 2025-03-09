using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class GetDynamicAttributeByIdHandler : IRequestHandler<GetDynamicAttributeByIdQuery,
        BaseResponse<GetDynamicAttributeByIdDto>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DependencyValidation> _DependencyValidationRepository;
        private readonly IMapper _Mapper;

        public GetDynamicAttributeByIdHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<GeneralValidation> GeneralValidationRepository,
            IAsyncRepository<Dependency> DependencyRepository,
            IAsyncRepository<DependencyValidation> DependencyValidationRepository,
            IMapper Mapper)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _GeneralValidationRepository = GeneralValidationRepository;
            _DependencyRepository = DependencyRepository;
            _DependencyValidationRepository = DependencyValidationRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetDynamicAttributeByIdDto>> Handle(GetDynamicAttributeByIdQuery Request, 
            CancellationToken cancellationToken)
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

            DynamicAttribute.GeneralValidationObject = _Mapper.Map<GeneralValidationDto>(await _GeneralValidationRepository
                .FirstOrDefaultAsync(x => x.DynamicAttributeId == Request.Id));

            IQueryable<IGrouping<int, Dependency>> Dependencies = _DependencyRepository
                .WhereThenInclude(x => x.MainDynamicAttributeId == Request.Id, x => x.AttributeOperation!, 
                    x => x.DynamicAttribute!, x => x.StaticAttribute!)
                .GroupBy(x => x.DependencyGroupId);

            List<DependencyValidation> DependencyValidations = await _DependencyValidationRepository
                .IncludeThenWhere(x => x.AttributeOperation!, x => Dependencies.Select(y => y.Key).Contains(x.DependencyGroupId))
                .ToListAsync();

            foreach (IGrouping<int, Dependency> Dependency in Dependencies)
            {
                DependencyValidation? DependencyValidation = DependencyValidations
                    .FirstOrDefault(x => x.DependencyGroupId == Dependency.Key);

                if (DependencyValidation != null)
                {
                    DependencyValidationDto? DependencyValidationDto = new DependencyValidationDto()
                    {
                        DependencyValidationId = DependencyValidation.Id,
                        Value = DependencyValidation.Value,
                        Operation = DependencyValidation.AttributeOperation!.OperationAsString,
                        Dependencies = Dependency.Select(x => new DependencyDto()
                        {
                            Id = x.Id,
                            Operation = x.AttributeOperation!.OperationAsString,
                            Value = x.Value,
                            AttributeLabel = x.StaticAttributeId != null 
                                ? (Request.lang == "en"
                                    ? x.StaticAttribute!.EnglishLabel
                                    : x.StaticAttribute!.ArabicLabel)
                                : (Request.lang == "en"
                                    ? x.DynamicAttribute!.EnglishLabel
                                    : x.DynamicAttribute!.ArabicLabel),
                            AttributeOperationId = x.AttributeOperationId,
                            DynamicAttributeId = x.DynamicAttributeId != null
                                ? x.DynamicAttributeId!.Value
                                : 0
                        }).ToList(),
                        AttributeOperationId = DependencyValidation.AttributeOperation!.Id
                    };

                    DynamicAttribute.DependencyValidations.Add(DependencyValidationDto);
                }
            }

            DynamicAttribute.Values = await _DynamicAttributeListValueRepository
                .Where(x => x.DynamicAttributeId == Request.Id)
                .Select(x => new DynamicAttributeListValueListVM()
                {
                    Id = x.Id,
                    EnglishValue = x.EnglishValue,
                    ArabicValue = x.ArabicValue,
                    Value = Request.lang == "en"
                        ? x.EnglishValue
                        : x.ArabicValue
                }).ToListAsync();

            return new BaseResponse<GetDynamicAttributeByIdDto>(ResponseMessage, true, 200, DynamicAttribute);
        }
    }
}