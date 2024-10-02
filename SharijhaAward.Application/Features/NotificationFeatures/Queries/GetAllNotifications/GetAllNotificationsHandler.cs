using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
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
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            List<GetAllNotificationsListVM> NotificationEntities = await _NotificationRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .Select(x => new GetAllNotificationsListVM()
                {
                    ArabicBody = x.ArabicBody,
                    ArabicTitle = x.ArabicTitle,
                    Body = Request.lang == "en"
                        ? x.EnglishBody : x.ArabicBody,
                    EnglishBody = x.EnglishBody,
                    CreatedAt = x.CreatedAt,
                    EnglishTitle = x.EnglishTitle,
                    Id = x.Id,
                    isReaded = false,
                    Title = Request.lang == "en"
                        ? x.EnglishTitle : x.ArabicTitle,
                }).ToListAsync();

            int TotalCount = await _NotificationRepository.WhereThenFilter(x => true, filterObject)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllNotificationsListVM>>(ResponseMessage, true, 200, NotificationEntities, PaginationParameter);
        }
    }
}
