using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById
{
    public class GetAdvancedFormBuilderByIdHandler : IRequestHandler<GetAdvancedFormBuilderByIdQuery,
        BaseResponse<GetAdvancedFormBuilderByIdDto>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderGeneralValidation> _AdvancedFormBuilderGeneralValidationRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependency> _AdvancedFormBuilderDependencyRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependencyValidation> _AdvancedFormBuilderDependencyValidationRepository;
        private readonly IMapper _Mapper;

        public GetAdvancedFormBuilderByIdHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AdvancedFormBuilderGeneralValidation> AdvancedFormBuilderGeneralValidationRepository,
            IAsyncRepository<AdvancedFormBuilderDependency> AdvancedFormBuilderDependencyRepository,
            IAsyncRepository<AdvancedFormBuilderDependencyValidation> AdvancedFormBuilderDependencyValidationRepository,
            IMapper Mapper)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _AdvancedFormBuilderGeneralValidationRepository = AdvancedFormBuilderGeneralValidationRepository;
            _AdvancedFormBuilderDependencyRepository = AdvancedFormBuilderDependencyRepository;
            _AdvancedFormBuilderDependencyValidationRepository = AdvancedFormBuilderDependencyValidationRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetAdvancedFormBuilderByIdDto>> Handle(GetAdvancedFormBuilderByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            GetAdvancedFormBuilderByIdDto AdvancedFormBuilder = _Mapper.Map<GetAdvancedFormBuilderByIdDto>
                (await _AdvancedFormBuilderRepository.IncludeThenFirstOrDefaultAsync(x => x.AttributeDataType!,
                    x => x.Id == Request.Id));

            if (AdvancedFormBuilder == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<GetAdvancedFormBuilderByIdDto>(ResponseMessage, false, 404);
            }

            AdvancedFormBuilder.GeneralValidation = _Mapper.Map<AdvancedFormBuilderGeneralValidationDto>(await _AdvancedFormBuilderGeneralValidationRepository
                .FirstOrDefaultAsync(x => x.AdvancedFormBuilderId == Request.Id));

            IQueryable<IGrouping<int, AdvancedFormBuilderDependency>> Dependencies = _AdvancedFormBuilderDependencyRepository
                .Where(x => x.MainAdvancedFormBuilderId == Request.Id)
                .Include(x => x.AttributeOperation!)
                .Include(x => x.AdvancedFormBuilder!)
                .Include(x => x.StaticAttribute!)
                .GroupBy(x => x.AdvancedFormBuilderDependencyGroupId);

            foreach (IGrouping<int, AdvancedFormBuilderDependency> AdvancedFormBuilderDependency in Dependencies)
            {
                AdvancedFormBuilderDependencyValidation? DependencyValidation = await _AdvancedFormBuilderDependencyValidationRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!, x => x.AdvancedFormBuilderDependencyGroupId == AdvancedFormBuilderDependency.Key);

                if (DependencyValidation != null)
                {
                    AdvancedFormBuilderDependencyValidationDto? DependencyValidationDto = new AdvancedFormBuilderDependencyValidationDto()
                    {
                        Id = DependencyValidation.Id,
                        Value = DependencyValidation.Value,
                        Operation = DependencyValidation.AttributeOperation!.OperationAsString,
                        Dependencies = AdvancedFormBuilderDependency.Select(x => new AdvancedFormBuilderDependencyDto()
                        {
                            Id = x.Id,
                            Operation = x.AttributeOperation!.OperationAsString,
                            Value = x.Value,
                            AttributeLabel = x.StaticAttributeId != null
                                ? (Request.lang == "en"
                                    ? x.StaticAttribute!.EnglishLabel
                                    : x.StaticAttribute!.ArabicLabel)
                                : (Request.lang == "en"
                                    ? x.AdvancedFormBuilder!.EnglishLabel
                                    : x.AdvancedFormBuilder!.ArabicLabel)
                        }).ToList()
                    };

                    AdvancedFormBuilder.ListOfDependencies.Add(DependencyValidationDto);
                }
            }

            AdvancedFormBuilder.Values = _Mapper.Map<List<AdvancedFormBuilderListValueListVM>>(_AdvancedFormBuilderListValueRepository
                .Where(x => x.AdvancedFormBuilderId == Request.Id));

            return new BaseResponse<GetAdvancedFormBuilderByIdDto>(ResponseMessage, true, 200, AdvancedFormBuilder);
        }
    }
}
