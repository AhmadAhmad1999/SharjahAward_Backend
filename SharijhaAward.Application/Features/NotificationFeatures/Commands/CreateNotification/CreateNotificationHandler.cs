using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.NotificationFeatures.Commands.CreateNotification
{
    public class CreateNotificationHandler : IRequestHandler<CreateNotificationCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public CreateNotificationHandler(IMapper Mapper,
            IAsyncRepository<Notification> NotificationRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IAsyncRepository<UserNotification> UserNotificationRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _Mapper = Mapper;
            _NotificationRepository = NotificationRepository;
            _UserTokenRepository = UserTokenRepository;
            _UserNotificationRepository = UserNotificationRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateNotificationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.ToAllRoles)
            {
                Request.UsersIds = await _UserRoleRepository
                    .Select(x => x.UserId)
                    .Distinct()
                    .ToListAsync();
            }
            else if (Request.RolesIds.Any())
            {
                Request.UsersIds = await _UserRoleRepository
                    .Where(x => Request.RolesIds.Contains(x.Id))
                    .Select(x => x.UserId)
                    .Distinct()
                    .ToListAsync();
            }

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
                    Notification NewNotificationEntity = _Mapper.Map<Notification>(Request);

                    await _NotificationRepository.AddAsync(NewNotificationEntity);

                    List<FirebaseAdmin.Messaging.Message> NotificationMessages = await _UserTokenRepository
                        .Where(x => Request.UsersIds.Any(y => y == x.UserId) && !string.IsNullOrEmpty(x.DeviceToken))
                        .Include(x => x.User!)
                        .Select(x => x.AppLanguage == "en"
                            ? new FirebaseAdmin.Messaging.Message()
                            {
                                Notification = new FirebaseAdmin.Messaging.Notification
                                {
                                    Title = NewNotificationEntity.EnglishTitle,
                                    Body = NewNotificationEntity.EnglishBody.Replace("$Email$", x.User!.Email)
                                },
                                Token = x.DeviceToken
                            } : new FirebaseAdmin.Messaging.Message()
                            {
                                Notification = new FirebaseAdmin.Messaging.Notification
                                {
                                    Title = NewNotificationEntity.ArabicTitle,
                                    Body = NewNotificationEntity.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                                },
                                Token = x.DeviceToken
                            }).ToListAsync();

                    List<UserNotification> UserNotificationEntities = await _UserTokenRepository
                        .Where(x => Request.UsersIds.Any(y => y == x.UserId))
                        .GroupBy(x => x.UserId)
                        .Select(x => new UserNotification()
                        {
                            UserId = x.Key,
                            NotificationId = NewNotificationEntity.Id,
                            isReaded = false
                        }).ToListAsync();

                    await _UserNotificationRepository.AddRangeAsync(UserNotificationEntities);

                    if (NotificationMessages.Any())
                        await FirebaseAdmin.Messaging.FirebaseMessaging.DefaultInstance.SendEachAsync(NotificationMessages);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الإشعار بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
