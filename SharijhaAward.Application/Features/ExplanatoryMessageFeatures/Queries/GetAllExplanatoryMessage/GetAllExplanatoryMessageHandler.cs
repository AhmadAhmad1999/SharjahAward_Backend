using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetAllExplanatoryMessage
{
    public class GetAllExplanatoryMessageHandler 
        : IRequestHandler<GetAllExplanatoryMessageQuery, BaseResponse<List<GetAllExplanatoryMessageListVM>>>
    {
        private readonly IAsyncRepository<ExplanatoryMessage> _ExplanatoryMessageRepository;
        private readonly IMapper _Mapper;
        public GetAllExplanatoryMessageHandler(IAsyncRepository<ExplanatoryMessage> ExplanatoryMessageRepository,
            IMapper Mapper)
        {
            _ExplanatoryMessageRepository = ExplanatoryMessageRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllExplanatoryMessageListVM>>> 
            Handle(GetAllExplanatoryMessageQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllExplanatoryMessageListVM> ExplanatoryMessages = _Mapper.Map<List<GetAllExplanatoryMessageListVM>>(await _ExplanatoryMessageRepository
                .OrderByDescending(x => x.CreatedAt, Request.page, Request.perPage).ToListAsync());

            int TotalCount = await _ExplanatoryMessageRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllExplanatoryMessageListVM>>(ResponseMessage, true, 200, ExplanatoryMessages, PaginationParameter);
        }
    }
}
