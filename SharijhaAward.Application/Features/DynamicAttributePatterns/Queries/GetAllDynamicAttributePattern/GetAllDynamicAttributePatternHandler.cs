using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetAllDynamicAttributePattern
{
    public class GetAllDynamicAttributePatternHandler : IRequestHandler<GetAllDynamicAttributePatternQuery,
        BaseResponse<List<GetAllDynamicAttributePatternListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributePattern> _DynamicAttributePatternRepository;
        private readonly IMapper _Mapper;

        public GetAllDynamicAttributePatternHandler(IAsyncRepository<DynamicAttributePattern> DynamicAttributePatternRepository,
            IMapper Mapper)
        {
            _DynamicAttributePatternRepository = DynamicAttributePatternRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllDynamicAttributePatternListVM>>> Handle(GetAllDynamicAttributePatternQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllDynamicAttributePatternListVM> DynamicAttributePatterns = _Mapper.Map<List<GetAllDynamicAttributePatternListVM>>(
                await _DynamicAttributePatternRepository.GetPagedReponseAsync(Request.page, Request.pageSize));

            if (DynamicAttributePatterns.Count() == 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no patterns"
                    : "لا يوجد نماذج";

                return new BaseResponse<List<GetAllDynamicAttributePatternListVM>>(ResponseMessage, true, 204, DynamicAttributePatterns, 0);
            }

            int TotalCount = await _DynamicAttributePatternRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllDynamicAttributePatternListVM>>(ResponseMessage, true, 200,
                DynamicAttributePatterns, PaginationParameter);
        }
    }
}
