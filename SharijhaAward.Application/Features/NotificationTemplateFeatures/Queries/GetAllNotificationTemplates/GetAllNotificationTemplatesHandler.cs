using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationTemplateModel;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetAllNotificationTemplates
{
    public class GetAllNotificationTemplatesHandler 
        : IRequestHandler<GetAllNotificationTemplatesQuery, BaseResponse<List<GetAllNotificationTemplatesListVM>>>
    {
        private readonly IAsyncRepository<NotificationTemplate> _NotificationTemplateRepository;
        private readonly IMapper _Mapper;
        public GetAllNotificationTemplatesHandler(IAsyncRepository<NotificationTemplate> NotificationTemplateRepository,
            IMapper Mapper)
        {
            _NotificationTemplateRepository = NotificationTemplateRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllNotificationTemplatesListVM>>> 
            Handle(GetAllNotificationTemplatesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllNotificationTemplatesListVM> Classes = _Mapper.Map<List<GetAllNotificationTemplatesListVM>>(await _NotificationTemplateRepository
                .OrderByDescending(x => x.CreatedAt, Request.page, Request.perPage).ToListAsync());

            int TotalCount = await _NotificationTemplateRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllNotificationTemplatesListVM>>(ResponseMessage, true, 200, Classes, PaginationParameter);
        }
    }
}
