using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Queries.GetAdvancedFormBuilderPatternById
{
    public class GetAdvancedFormBuilderPatternByIdHandler : IRequestHandler<GetAdvancedFormBuilderPatternByIdQuery,
        BaseResponse<GetAdvancedFormBuilderPatternByIdDto>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderPattern> _AdvancedFormBuilderPatternRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderPatternValue> _AdvancedFormBuilderPatternValueRepository;
        private readonly IMapper _Mapper;

        public GetAdvancedFormBuilderPatternByIdHandler(IAsyncRepository<AdvancedFormBuilderPattern> AdvancedFormBuilderPatternRepository,
            IAsyncRepository<AdvancedFormBuilderPatternValue> AdvancedFormBuilderPatternValueRepository,
            IMapper Mapper)
        {
            _AdvancedFormBuilderPatternRepository = AdvancedFormBuilderPatternRepository;
            _AdvancedFormBuilderPatternValueRepository = AdvancedFormBuilderPatternValueRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetAdvancedFormBuilderPatternByIdDto>> Handle(GetAdvancedFormBuilderPatternByIdQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            AdvancedFormBuilderPattern? AdvancedFormBuilderPatternEntity = await _AdvancedFormBuilderPatternRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (AdvancedFormBuilderPatternEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Pattern not found"
                    : "هذا النموذج غير موجود";

                return new BaseResponse<GetAdvancedFormBuilderPatternByIdDto>(ResponseMessage, false, 404);
            }

            GetAdvancedFormBuilderPatternByIdDto AdvancedFormBuilderSection = _Mapper.Map<GetAdvancedFormBuilderPatternByIdDto>
                (AdvancedFormBuilderPatternEntity);

            AdvancedFormBuilderSection.Values = _Mapper.Map<List<GetAdvancedFormBuilderPatternByIdValues>>(
                await _AdvancedFormBuilderPatternValueRepository
                    .Where(x => x.AdvancedFormBuilderPatternId == Request.Id)
                    .ToListAsync());

            return new BaseResponse<GetAdvancedFormBuilderPatternByIdDto>(ResponseMessage, true, 200, AdvancedFormBuilderSection);
        }
    }
}
