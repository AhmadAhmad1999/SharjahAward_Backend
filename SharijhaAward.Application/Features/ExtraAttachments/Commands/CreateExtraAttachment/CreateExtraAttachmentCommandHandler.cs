using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;
using SharijhaAward.Domain.Entities.StaticNotificationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.CreateExtraAttachment
{
    public class CreateExtraAttachmentCommandHandler
        : IRequestHandler<CreateExtraAttachmentCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository;
        private readonly IAsyncRepository<ExtraAttachmentAttachmentType> _ExtraAttachmentAttachmentTypeRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        private readonly IAsyncRepository<StaticNotification> _StaticNotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;

        public CreateExtraAttachmentCommandHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository, 
            IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository, 
            IMapper _Mapper,
            IAsyncRepository<ExtraAttachmentAttachmentType> _ExtraAttachmentAttachmentTypeRepository,
            IAsyncRepository<Notification> _NotificationRepository,
            IAsyncRepository<StaticNotification> _StaticNotificationRepository,
            IAsyncRepository<UserToken> _UserTokenRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IAsyncRepository<UserNotification> _UserNotificationRepository)
        {
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._ExtraAttachmentRepository = _ExtraAttachmentRepository;
            this._Mapper = _Mapper;
            this._ExtraAttachmentAttachmentTypeRepository = _ExtraAttachmentAttachmentTypeRepository;
            this._NotificationRepository = _NotificationRepository;
            this._StaticNotificationRepository = _StaticNotificationRepository;
            this._UserTokenRepository = _UserTokenRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._UserNotificationRepository = _UserNotificationRepository;
        }

        public async Task<BaseResponse<int>> Handle(CreateExtraAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ProvidedFormId);

            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not found"
                    : "الإستمارة غير موجودة";

                return new BaseResponse<int>(ResponseMessage, false, 404);
            }

            if (ProvidedFormEntity.TotalStep == 6 &&
                !Request.FromArbitrationStep)
            {
                ProvidedFormEntity.TotalStep++;

                var PercentFormula = ((ProvidedFormEntity.CurrentStep - 1) * 100) / ProvidedFormEntity.TotalStep;
                ProvidedFormEntity.PercentCompletion = PercentFormula < 0 ? 0 : PercentFormula;
                ProvidedFormEntity.needSing = true;
            }
                
            ExtraAttachment NewExtraAttachmentEntity = _Mapper.Map<ExtraAttachment>(Request);

            NewExtraAttachmentEntity.isAccepted = !Request.FromArbitrationStep;

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
                    ExtraAttachment Response = await _ExtraAttachmentRepository.AddAsync(NewExtraAttachmentEntity);

                    await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);

                    List<ExtraAttachmentAttachmentType> NewExtraAttachmentAttachmentTypeEntities = Request.AttachmentType
                        .Select(x => new ExtraAttachmentAttachmentType()
                        {
                            AttachmentType = x,
                            ExtraAttachmentId = NewExtraAttachmentEntity.Id
                        }).ToList();

                    await _ExtraAttachmentAttachmentTypeRepository.AddRangeAsync(NewExtraAttachmentAttachmentTypeEntities);

                    if (Request.FromArbitrationStep)
                    {
                        StaticNotification? StaticNotificationEntity = await _StaticNotificationRepository
                            .FirstOrDefaultAsync(x => x.StaticNotificationType == StaticNotificationTypes.SendRequestForExtraAttachment &&
                                x.isActive);

                        if (StaticNotificationEntity is not null)
                        {
                            Notification NewNotificationEntity = new Notification()
                            {
                                ArabicTitle = StaticNotificationEntity!.ArabicTitle,
                                ArabicBody = StaticNotificationEntity!.ArabicBody
                                    .Replace("ProvidedFormId", ProvidedFormEntity.Id.ToString()),
                                EnglishTitle = StaticNotificationEntity!.EnglishTitle,
                                EnglishBody = StaticNotificationEntity!.EnglishBody
                                    .Replace("ProvidedFormId", ProvidedFormEntity.Id.ToString()),
                                isStaticNotification = true
                            };

                            await _NotificationRepository.AddAsync(NewNotificationEntity);

                            List<int> AdminUsersIds = await _UserRoleRepository
                                .Where(x => x.Role!.EnglishName.ToLower() == "Admin".ToLower() &&
                                    x.Role!.ArabicName == "ادمن" &&
                                    x.User!.isValidAccount)
                                .Select(x => x.UserId)
                                .ToListAsync();

                            List<FirebaseAdmin.Messaging.Message>? NotificationMessages = await _UserTokenRepository
                                .Where(x => AdminUsersIds.Contains(x.UserId) && !string.IsNullOrEmpty(x.DeviceToken))
                                .Select(x => x.AppLanguage == "en"
                                    ? new FirebaseAdmin.Messaging.Message()
                                    {
                                        Notification = new FirebaseAdmin.Messaging.Notification
                                        {
                                            Title = NewNotificationEntity.EnglishTitle,
                                            Body = NewNotificationEntity.EnglishBody.Replace("$Email$", x.User!.Email)
                                                .Replace("ProvidedFormId", ProvidedFormEntity.Id.ToString())
                                        },
                                        Token = x.DeviceToken
                                    }
                                    : new FirebaseAdmin.Messaging.Message()
                                    {
                                        Notification = new FirebaseAdmin.Messaging.Notification
                                        {
                                            Title = NewNotificationEntity.ArabicTitle,
                                            Body = NewNotificationEntity.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                                                .Replace("ProvidedFormId", ProvidedFormEntity.Id.ToString())
                                        },
                                        Token = x.DeviceToken
                                    }).ToListAsync();

                            List<UserNotification> UserNotificationEntities = await _UserTokenRepository
                                .Where(x => AdminUsersIds.Contains(x.UserId))
                                .GroupBy(x => x.UserId)
                                .Select(x => new UserNotification()
                                {
                                    UserId = x.Key,
                                    NotificationId = NewNotificationEntity.Id,
                                    isReaded = false,
                                    Action = "RequestForExtraAttachments"
                                }).ToListAsync();

                            if (UserNotificationEntities is not null)
                                await _UserNotificationRepository.AddRangeAsync(UserNotificationEntities!);

                            if (NotificationMessages is not null
                                ? NotificationMessages.Any()
                                : false)
                                await FirebaseAdmin.Messaging.FirebaseMessaging.DefaultInstance.SendEachAsync(NotificationMessages);
                        }
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "Extra Attachment has been Added"
                        : "تم إضافة الملحق الإضافي";

                    Transaction.Complete();

                    return new BaseResponse<int>(ResponseMessage, true, 200, Response.Id);
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
