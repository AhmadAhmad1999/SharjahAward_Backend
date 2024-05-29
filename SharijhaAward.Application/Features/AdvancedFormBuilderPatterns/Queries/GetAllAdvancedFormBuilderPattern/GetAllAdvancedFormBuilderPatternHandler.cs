using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Queries.GetAllAdvancedFormBuilderPattern
{
    public class GetAllAdvancedFormBuilderPatternHandler : IRequestHandler<GetAllAdvancedFormBuilderPatternQuery,
        BaseResponse<List<GetAllAdvancedFormBuilderPatternListVM>>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderPattern> _AdvancedFormBuilderPatternRepository;
        private readonly IMapper _Mapper;

        public GetAllAdvancedFormBuilderPatternHandler(IAsyncRepository<AdvancedFormBuilderPattern> AdvancedFormBuilderPatternRepository,
            IMapper Mapper)
        {
            _AdvancedFormBuilderPatternRepository = AdvancedFormBuilderPatternRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllAdvancedFormBuilderPatternListVM>>> Handle(GetAllAdvancedFormBuilderPatternQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllAdvancedFormBuilderPatternListVM> AdvancedFormBuilderPatterns = _Mapper.Map<List<GetAllAdvancedFormBuilderPatternListVM>>(
                await _AdvancedFormBuilderPatternRepository.OrderByDescending(x => x.CreatedAt, Request.page, Request.pageSize)
                    .ToListAsync());

            int TotalCount = await _AdvancedFormBuilderPatternRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllAdvancedFormBuilderPatternListVM>>(ResponseMessage, true, 200,
                AdvancedFormBuilderPatterns, PaginationParameter);
        }
    }
}