using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.StaticNotificationModel;
using System.ComponentModel;
using System.Reflection;

namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Queries.GetAllStaticNotifications
{
    public class GetAllStaticNotificationsHandler : IRequestHandler<GetAllStaticNotificationsQuery, BaseResponse<List<GetAllStaticNotificationsListVM>>>
    {
        private readonly IAsyncRepository<StaticNotification> _StaticNotificationRepository;
        public GetAllStaticNotificationsHandler(IAsyncRepository<StaticNotification> StaticNotificationRepository)
        {
            _StaticNotificationRepository = StaticNotificationRepository;
        }

        public async Task<BaseResponse<List<GetAllStaticNotificationsListVM>>> 
            Handle(GetAllStaticNotificationsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            var FilterObject = new FilterObject() { Filters = Request.filters };

            List<GetAllStaticNotificationsListVM> StaticNotificationEntities = _StaticNotificationRepository
                .OrderByDescending(FilterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .ToList()
                .Select(x =>
                {
                    StaticNotificationTypes EnumValue = (StaticNotificationTypes)x.StaticNotificationType;

                    List<string> StaticNotificationTypeSpliter = GetEnumDescription(EnumValue).Split(" - ").ToList();

                    return new GetAllStaticNotificationsListVM()
                    {
                        Id = x.Id,
                        StaticNotificationType = Request.lang == "en"
                            ? StaticNotificationTypeSpliter[0]
                            : StaticNotificationTypeSpliter[1],
                        Title = Request.lang == "en"
                            ? x.EnglishTitle
                            : x.ArabicTitle,
                        isActive = x.isActive,
                        ArabicTitle = x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle,
                        EnglishBody = x.EnglishBody,
                        ArabicBody = x.ArabicBody,
                        Body = Request.lang == "en"
                            ? x.EnglishBody
                            : x.ArabicBody
                    };
                }).ToList();

            int TotalCount = await _StaticNotificationRepository
                .WhereThenFilter(c => true, FilterObject)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllStaticNotificationsListVM>>(ResponseMessage, true, 200, StaticNotificationEntities, PaginationParameter);
        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo? FI = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])FI.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
