using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage
{
    public class CreateMessageCommandHandler
        : IRequestHandler<CreateMessageCommand, BaseResponse<int>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        private readonly IAsyncRepository<EmailAttachment> _EmailAttachmentRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;

        public CreateMessageCommandHandler(IUserRepository _UserRepository,
            IAsyncRepository<EmailMessage> _EmailMessageRepository,
            IAsyncRepository<EmailAttachment> _EmailAttachmentRepository,
            IJwtProvider _JWTProvider,
            IFileService _FileService,
            IMapper _Mapper)
        {
            this._EmailMessageRepository = _EmailMessageRepository;
            this._EmailAttachmentRepository = _EmailAttachmentRepository;
            this._UserRepository = _UserRepository;
            this._FileService = _FileService;
            this._JWTProvider = _JWTProvider;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateMessageCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ResponseMessage = Request.lang == "en"
                ? "Message has been Sended"
                : "تم إرسال الرسالة بنجاح";

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
                    EmailMessage NewEmailMessageEntity = _Mapper.Map<EmailMessage>(Request);

                    NewEmailMessageEntity.IsRead = false;

                    if (string.IsNullOrEmpty(Request.token))
                    {
                        NewEmailMessageEntity.Status = Domain.Constants.ContactUsConstants.MessageStatus.New;

                        await _EmailMessageRepository.AddAsync(NewEmailMessageEntity);
                        if (Request.MessageId is null)
                        {
                            NewEmailMessageEntity.MessageId = NewEmailMessageEntity.Id;
                            await _EmailMessageRepository.UpdateAsync(NewEmailMessageEntity);
                        }
                    }
                    else
                    {
                        int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

                        Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                            .FirstOrDefaultAsync(x => x.Id == UserId);

                        if (NewEmailMessageEntity.UserId == null)
                            NewEmailMessageEntity.UserId = UserEntity!.Id;

                        NewEmailMessageEntity.From = UserEntity!.Email;

                        if (Request.MessageId != null)
                        {
                            EmailMessage? ParentEmailMessageEntity = await _EmailMessageRepository
                                .FirstOrDefaultAsync(x => x.Id == Request.MessageId);

                            if (ParentEmailMessageEntity == null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Message Not Found"
                                    : "الرسالة غير موجودة";

                                return new BaseResponse<int>(ResponseMessage, false, 400);
                            }
                            else
                            {
                                if (NewEmailMessageEntity.AsignId == null)
                                {
                                    NewEmailMessageEntity.UserId = UserEntity.Id;
                                    NewEmailMessageEntity.Status = Domain.Constants.ContactUsConstants.MessageStatus.InProgress;
                                }
                            }
                        }
                        else
                        {
                            NewEmailMessageEntity.Status = Domain.Constants.ContactUsConstants.MessageStatus.New;
                        }

                        if (string.IsNullOrEmpty(Request.FirstName) &&
                            string.IsNullOrEmpty(Request.LastName))
                        {
                            NewEmailMessageEntity.FirstName = Request.lang == "en"
                                ? UserEntity.EnglishName
                                : UserEntity.ArabicName;
                        }

                        await _EmailMessageRepository.AddAsync(NewEmailMessageEntity);

                        if (Request.MessageId == null)
                        {
                            NewEmailMessageEntity.MessageId = NewEmailMessageEntity.Id;
                            await _EmailMessageRepository.UpdateAsync(NewEmailMessageEntity);
                        }
                    }

                    List<EmailAttachment> NewEmailAttachmentEntities = new List<EmailAttachment>();

                    foreach (IFormFile attachment in Request.EmailAttachments!)
                    {
                        EmailAttachment NewEmailAttachmentEntity = new EmailAttachment()
                        {
                            AttachmentUrl = await _FileService.SaveFileAsync(attachment, SystemFileType.ContactUsFiles),
                            MessageId = NewEmailMessageEntity.Id
                        };

                        NewEmailAttachmentEntities.Add(NewEmailAttachmentEntity);
                    }

                    if (NewEmailAttachmentEntities.Any())
                        await _EmailAttachmentRepository.AddRangeAsync(NewEmailAttachmentEntities);

                    Transaction.Complete();

                    return new BaseResponse<int>(ResponseMessage, true, 200, NewEmailMessageEntity.Id);
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
