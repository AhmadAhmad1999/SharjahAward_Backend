using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationModel;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotifications
{
    public class GetAllNotificationsHandler : IRequestHandler<GetAllNotificationsQuery, BaseResponse<List<GetAllNotificationsListVM>>>
    {
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        private readonly IMapper _Mapper;
        public GetAllNotificationsHandler(IAsyncRepository<Notification> NotificationRepository,
            IMapper Mapper)
        {
            _NotificationRepository = NotificationRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllNotificationsListVM>>> 
            Handle(GetAllNotificationsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllNotificationsListVM> Classes = _Mapper.Map<List<GetAllNotificationsListVM>>(await _NotificationRepository
                .OrderByDescending(x => x.CreatedAt, Request.page, Request.pageSize).ToListAsync());

            int TotalCount = await _NotificationRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllNotificationsListVM>>(ResponseMessage, true, 200, Classes, PaginationParameter);
        }
    }
}
