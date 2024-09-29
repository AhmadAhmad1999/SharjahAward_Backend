using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetAllExplanatoryMessage
{
    public class GetAllExplanatoryMessageHandler 
        : IRequestHandler<GetAllExplanatoryMessageQuery, BaseResponse<List<GetAllExplanatoryMessageListVM>>>
    {
        private readonly IAsyncRepository<ExplanatoryMessage> _ExplanatoryMessageRepository;
        public GetAllExplanatoryMessageHandler(IAsyncRepository<ExplanatoryMessage> ExplanatoryMessageRepository)
        {
            _ExplanatoryMessageRepository = ExplanatoryMessageRepository;
        }

        public async Task<BaseResponse<List<GetAllExplanatoryMessageListVM>>> 
            Handle(GetAllExplanatoryMessageQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            List<GetAllExplanatoryMessageListVM> ExplanatoryMessages = await _ExplanatoryMessageRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .Select(x => new GetAllExplanatoryMessageListVM()
                {
                    Id = x.Id,
                    Type = x.Type,
                    ArabicText = x.ArabicText,
                    EnglishText = x.EnglishText,
                    Text = Request.lang == "en"
                        ? x.EnglishText
                        : x.ArabicText
                }).ToListAsync();

            int TotalCount = await _ExplanatoryMessageRepository.WhereThenFilter(a => true, filterObject).CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllExplanatoryMessageListVM>>(ResponseMessage, true, 200, ExplanatoryMessages, PaginationParameter);
        }
    }
}
