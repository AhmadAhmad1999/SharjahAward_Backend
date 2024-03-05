using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetDynamicAttributePatternById
{
    public class GetDynamicAttributePatternByIdHandler : IRequestHandler<GetDynamicAttributePatternByIdQuery,
        BaseResponse<GetDynamicAttributePatternByIdDto>>
    {
        private readonly IAsyncRepository<DynamicAttributePattern> _DynamicAttributePatternRepository;
        private readonly IAsyncRepository<DynamicAttributePatternValue> _DynamicAttributePatternValueRepository;
        private readonly IMapper _Mapper;

        public GetDynamicAttributePatternByIdHandler(IAsyncRepository<DynamicAttributePattern> DynamicAttributePatternRepository,
            IAsyncRepository<DynamicAttributePatternValue> DynamicAttributePatternValueRepository,
            IMapper Mapper)
        {
            _DynamicAttributePatternRepository = DynamicAttributePatternRepository;
            _DynamicAttributePatternValueRepository = DynamicAttributePatternValueRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetDynamicAttributePatternByIdDto>> Handle(GetDynamicAttributePatternByIdQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            DynamicAttributePattern? DynamicAttributePatternEntity = await _DynamicAttributePatternRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (DynamicAttributePatternEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Pattern not found"
                    : "هذا النموذج غير موجود";

                return new BaseResponse<GetDynamicAttributePatternByIdDto>(ResponseMessage, false, 404);
            }

            GetDynamicAttributePatternByIdDto DynamicAttributeSection = _Mapper.Map<GetDynamicAttributePatternByIdDto>
                (DynamicAttributePatternEntity);

            DynamicAttributeSection.Values = _Mapper.Map<List<GetDynamicAttributePatternByIdValues>>(
                await _DynamicAttributePatternValueRepository
                    .Where(x => x.DynamicAttributePatternId == Request.Id)
                    .ToListAsync());

            return new BaseResponse<GetDynamicAttributePatternByIdDto>(ResponseMessage, true, 200, DynamicAttributeSection);
        }
    }
}
