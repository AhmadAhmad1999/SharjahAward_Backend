﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;
using System.Transactions;

namespace SharijhaAward.Application.Helpers.RejectDynamicAttributeValue
{
    public class RejectDynamicAttributeValueHandler : IRequestHandler<RejectDynamicAttributeValueMainCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IEmailSender _EmailSender;
        public RejectDynamicAttributeValueHandler(IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<Notification> NotificationRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IAsyncRepository<UserNotification> UserNotificationRepository,
            IEmailSender EmailSender)
        {
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
            _NotificationRepository = NotificationRepository;
            _UserTokenRepository = UserTokenRepository;
            _UserNotificationRepository = UserNotificationRepository;
            _EmailSender = EmailSender;
        }
        public async Task<BaseResponse<object>> Handle(RejectDynamicAttributeValueMainCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => Request.RejectDynamicAttributeValueCommand.Any()
                    ? x.Id == Request.RejectDynamicAttributeValueCommand.FirstOrDefault()!.FormId
                    : false);

            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not found"
                    : "الاستمارة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<DynamicAttributeValue> DynamicAttributeValueEntities = _DynamicAttributeValueRepository
                .AsEnumerable()
                .Where(x => Request.RejectDynamicAttributeValueCommand.Select(y => new
                {
                    y.DynamicAttributesId,
                    y.FormId
                }).Any(y => y.DynamicAttributesId == x.DynamicAttributeId && 
                    y.FormId == x.RecordId &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1))
                .ToList();

            foreach (DynamicAttributeValue DynamicAttributeValueEntity in DynamicAttributeValueEntities)
            {
                RejectDynamicAttributeValueCommand? RequestCommand = Request.RejectDynamicAttributeValueCommand
                    .FirstOrDefault(x => x.DynamicAttributesId == DynamicAttributeValueEntity.DynamicAttributeId);

                if (RequestCommand is not null)
                {
                    DynamicAttributeValueEntity.isAccepted = RequestCommand.isAccepted;
                    DynamicAttributeValueEntity.ReasonForRejecting = RequestCommand.ReasonForRejecting;
                }
            }

            List<DynamicAttributeTableValue> DynamicAttributeTableValueEntities = await _DynamicAttributeTableValueRepository
                .Where(x => Request.RejectDynamicAttributeValueCommand.Select(y => y.DynamicAttributesId).Contains(x.DynamicAttributeId))
                .ToListAsync();

            foreach (DynamicAttributeTableValue DynamicAttributeTableValueEntity in DynamicAttributeTableValueEntities)
            {
                RejectDynamicAttributeValueCommand? RequestCommand = Request.RejectDynamicAttributeValueCommand
                    .FirstOrDefault(x => x.DynamicAttributesId == DynamicAttributeTableValueEntity.DynamicAttributeId && 
                        x.RowId == DynamicAttributeTableValueEntity.RowId);

                if (RequestCommand is not null)
                {
                    DynamicAttributeTableValueEntity.isAccepted = RequestCommand.isAccepted;
                    DynamicAttributeTableValueEntity.ReasonForRejecting = RequestCommand.ReasonForRejecting;
                }
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
                    await _DynamicAttributeValueRepository.UpdateListAsync(DynamicAttributeValueEntities);
                    await _DynamicAttributeTableValueRepository.UpdateListAsync(DynamicAttributeTableValueEntities);


                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Field's acceptance status has been successfully changed"
                        : "تم تغيير حالة قبول الحقل بنجاح";

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
