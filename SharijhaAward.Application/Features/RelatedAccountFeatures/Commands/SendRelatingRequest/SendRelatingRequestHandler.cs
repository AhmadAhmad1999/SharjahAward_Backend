﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;
using SharijhaAward.Domain.Entities.RelatedAccountModel;
using SharijhaAward.Domain.Entities.StaticNotificationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.SendRelatingRequest
{
    public class SendRelatingRequestHandler : IRequestHandler<SendRelatingRequestCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        private readonly IAsyncRepository<RelatedAccountRequest> _RelatedAccountRequestRepository;
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<StaticNotification> _StaticNotificationRepository;

        public SendRelatingRequestHandler(IUserRepository UserRepository,
            IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository,
            IAsyncRepository<UserNotification> UserNotificationRepository,
            IAsyncRepository<RelatedAccount> RelatedAccountRepository,
            IJwtProvider JWTProvider,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<Notification> NotificationRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IAsyncRepository<StaticNotification> _StaticNotificationRepository)
        {
            _UserNotificationRepository = UserNotificationRepository;
            _UserRepository = UserRepository;
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
            _RelatedAccountRepository = RelatedAccountRepository;
            _JWTProvider = JWTProvider;
            _UserRoleRepository = UserRoleRepository;
            _UserTokenRepository = UserTokenRepository;
            _NotificationRepository = NotificationRepository;
            this._StaticNotificationRepository = _StaticNotificationRepository;
        }
        public async Task<BaseResponse<object>> Handle(SendRelatingRequestCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int SenderId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            UserRole? UserRole = await _UserRoleRepository
                .FirstOrDefaultAsync(x => x.User!.Email.ToLower() == Request.ReceiverEmail.ToLower() && x.User!.isValidAccount &&
                    x.Role!.EnglishName.ToLower() == "Subscriber".ToLower());

            if (UserRole == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Account is not found"
                    : "الحساب غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            else if (UserRole.UserId == SenderId)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This is your account's email so you can't send a request to yourself"
                    : "البريد الإلكتروني المدخل هو الخاص بحسابك الشخصي ولا يمكنك إرسال طلب لنفسك";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            RelatedAccount? CheckIfRelatedAccountIsAlreadyExist = await _RelatedAccountRepository
                .FirstOrDefaultAsync(x => x.User1Id == SenderId && x.User2Id == UserRole.UserId);

            if (CheckIfRelatedAccountIsAlreadyExist is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "You already have this account in your linked accounts"
                    : "هذا الحساب موجود مسبقاً في قائمة الحسابات المرتبطة الخاصة بك";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            else
            {
                RelatedAccountRequest? CheckIfRelatedAccountRequestIsAlreadyExist = await _RelatedAccountRequestRepository
                    .FirstOrDefaultAsync(x => x.SenderId == SenderId && x.ReceiverId == UserRole.UserId &&
                        x.Status != Domain.Constants.RelatedAccountRequestStatus.Accepted);

                if (CheckIfRelatedAccountRequestIsAlreadyExist is not null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "You've already sent a request to this account's email"
                        : "لقد قمت مسبقاً بإرسال طلب لهذا الحساب";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

            RelatedAccountRequest NewRelatedAccountRequestEntity = new RelatedAccountRequest()
            {
                isDeleted = false,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                DeletedAt = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                SenderId = SenderId,
                ReceiverId = UserRole.UserId,
                Status = Domain.Constants.RelatedAccountRequestStatus.Pending
            };

            NewRelatedAccountRequestEntity.Status = Domain.Constants.RelatedAccountRequestStatus.Pending;

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _RelatedAccountRequestRepository.AddAsync(NewRelatedAccountRequestEntity);

                    StaticNotification? StaticNotificationEntity = await _StaticNotificationRepository
                        .FirstOrDefaultAsync(x => x.StaticNotificationType == StaticNotificationTypes.SendRelatingRequest &&
                            x.isActive);

                    if (StaticNotificationEntity is not null)
                    {
                        Notification NewNotificationEntity = new Notification()
                        {
                            ArabicTitle = StaticNotificationEntity!.ArabicTitle,
                            ArabicBody = StaticNotificationEntity!.ArabicBody,
                            EnglishTitle = StaticNotificationEntity!.EnglishTitle,
                            EnglishBody = StaticNotificationEntity!.EnglishBody,
                            isStaticNotification = true
                        };

                        await _NotificationRepository.AddAsync(NewNotificationEntity);

                        List<FirebaseAdmin.Messaging.Message>? NotificationMessages = await _UserTokenRepository
                            .Where(x => x.User!.Email == Request.ReceiverEmail && !string.IsNullOrEmpty(x.DeviceToken))
                            .Select(x => x.AppLanguage == "en"
                                ? new FirebaseAdmin.Messaging.Message()
                                {
                                    Notification = new FirebaseAdmin.Messaging.Notification
                                    {
                                        Title = NewNotificationEntity.EnglishTitle,
                                        Body = NewNotificationEntity.EnglishBody
                                    },
                                    Token = x.DeviceToken
                                } : new FirebaseAdmin.Messaging.Message()
                                {
                                    Notification = new FirebaseAdmin.Messaging.Notification
                                    {
                                        Title = NewNotificationEntity.ArabicTitle,
                                        Body = NewNotificationEntity.ArabicBody
                                    },
                                    Token = x.DeviceToken
                                }).ToListAsync();

                        if (NotificationMessages is not null
                            ? NotificationMessages.Any()
                            : false)
                            await FirebaseAdmin.Messaging.FirebaseMessaging.DefaultInstance.SendEachAsync(NotificationMessages);

                        await _UserNotificationRepository.AddAsync(new UserNotification()
                        {
                            NotificationId = StaticNotificationEntity.Id,
                            UserId = UserRole.UserId,
                            isReaded = false,
                            Action = "linked_accounts"
                        });
                    }

                    Transaction.Complete();
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
            ResponseMessage = Request.lang == "en"
                ? "Request sent successfuly"
                : "تم إرسال الطلب بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}