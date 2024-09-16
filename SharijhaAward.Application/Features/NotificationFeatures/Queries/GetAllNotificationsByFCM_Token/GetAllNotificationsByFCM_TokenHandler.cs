﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotificationsByFCM_Token
{
    public class GetAllNotificationsByFCM_TokenHandler 
        : IRequestHandler<GetAllNotificationsByFCM_TokenQuery, BaseResponse<GetAllNotificationsByFCM_TokenListVM>>
    {
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetAllNotificationsByFCM_TokenHandler(IAsyncRepository<UserNotification> UserNotificationRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IJwtProvider JwtProvider)
        {
            _UserNotificationRepository = UserNotificationRepository;
            _UserTokenRepository = UserTokenRepository;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<GetAllNotificationsByFCM_TokenListVM>>
            Handle(GetAllNotificationsByFCM_TokenQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (!string.IsNullOrEmpty(Request.DeviceToken))
            {
                UserToken? CheckUserTokenIfExist = await _UserTokenRepository
                    .FirstOrDefaultAsync(x => x.DeviceToken == Request.DeviceToken);

                if (CheckUserTokenIfExist == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User Token is not Found"
                        : "تعريف المستخدم غير موجود";

                    return new BaseResponse<GetAllNotificationsByFCM_TokenListVM> (ResponseMessage, false, 404);
                }

                List<NotificationDto> Notifications = new List<NotificationDto>();

                if (Request.page != 0 && Request.perPage != -1)
                {
                    var xx = await _UserNotificationRepository
                        .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                        .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                            ? new NotificationDto()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.EnglishTitle,
                                Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email)
                            } : new NotificationDto()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.ArabicTitle,
                                Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                            })
                        .ToListAsync();

                    Notifications = xx
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList();
                }
                else
                {
                    Notifications = await _UserNotificationRepository
                        .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                        .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                            ? new NotificationDto()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.EnglishTitle,
                                Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email)
                            } : new NotificationDto()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.ArabicTitle,
                                Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                            })
                        .OrderByDescending(x => x.Id)
                        .OrderByDescending(x => x.CreatedAt)
                        .ToListAsync();
                }

                var UserNotifications = new GetAllNotificationsByFCM_TokenListVM()
                {
                    ReadedNotifications = Notifications.Where(n => n.isReaded).ToList(),
                    UnReadedNotifications = Notifications.Where(n => !n.isReaded).ToList()
                };

                int TotalCount = await _UserNotificationRepository.GetCountAsync(x => x.UserId == CheckUserTokenIfExist.UserId);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<GetAllNotificationsByFCM_TokenListVM>(ResponseMessage, true, 200, UserNotifications, PaginationParameter);
            }
            else if (!string.IsNullOrEmpty(Request.Token))
            {
                int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

                UserToken? CheckUserTokenIfExist = await _UserTokenRepository
                    .FirstOrDefaultAsync(x => x.Token == Request.Token &&
                        x.UserId == UserId);

                if (CheckUserTokenIfExist == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User token is not Found"
                        : "تعريف المستخدم غير موجود";

                    return new BaseResponse<GetAllNotificationsByFCM_TokenListVM>(ResponseMessage, false, 404);
                }

                List<NotificationDto> Notifications = new List<NotificationDto>();

                if (Request.page != 0 && Request.perPage != -1)
                {
                    Notifications = await _UserNotificationRepository
                        .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                        .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                            ? new NotificationDto()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.EnglishTitle,
                                Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email)
                            } : new NotificationDto()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.ArabicTitle,
                                Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                            })
                        .OrderByDescending(x => x.Id)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    Notifications = await _UserNotificationRepository
                        .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                        .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                            ? new NotificationDto()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.EnglishTitle,
                                Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email)
                            } : new NotificationDto()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.ArabicTitle,
                                Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                            })
                        .OrderByDescending(x => x.Id)
                        .ToListAsync();
                }

                var UserNotifications = new GetAllNotificationsByFCM_TokenListVM()
                {
                    ReadedNotifications = Notifications.Where(n => n.isReaded).ToList(),
                    UnReadedNotifications = Notifications.Where(n => !n.isReaded).ToList()
                };

                int TotalCount = await _UserNotificationRepository.GetCountAsync(x => x.UserId == CheckUserTokenIfExist.UserId);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<GetAllNotificationsByFCM_TokenListVM>(ResponseMessage, true, 200, UserNotifications, PaginationParameter);
            }

            return new BaseResponse<GetAllNotificationsByFCM_TokenListVM>(ResponseMessage, true, 200);
        }
    }
}
