using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.WebSiteResponseModel;
using System.Net;
using System.Net.Mail;
using System.Transactions;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.ResponseForWebsite
{
    public class ResponseForWebsiteHandler : IRequestHandler<ResponseForWebsiteCommand, BaseResponse<int>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        private readonly IAsyncRepository<WebSiteResponse> _WebSiteResponseRepository;
        private readonly IAsyncRepository<WebSiteResponseAttachment> _WebSiteResponseAttachmentRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;
        private readonly IEmailSender _EmailSender;
        private IConfiguration _Configuration;

        public ResponseForWebsiteHandler(IUserRepository _UserRepository,
            IAsyncRepository<EmailMessage> _EmailMessageRepository,
            IAsyncRepository<WebSiteResponse> _WebSiteResponseRepository,
            IAsyncRepository<WebSiteResponseAttachment> _WebSiteResponseAttachmentRepository,
            IJwtProvider _JWTProvider,
            IFileService _FileService,
            IMapper _Mapper,
            IEmailSender _EmailSender,
            IConfiguration _Configuration)
        {
            this._UserRepository = _UserRepository;
            this._EmailMessageRepository = _EmailMessageRepository;
            this._WebSiteResponseRepository = _WebSiteResponseRepository;
            this._WebSiteResponseAttachmentRepository = _WebSiteResponseAttachmentRepository;
            this._JWTProvider = _JWTProvider;
            this._FileService = _FileService;
            this._Mapper = _Mapper;
            this._EmailSender = _EmailSender;
            this._Configuration = _Configuration;
        }

        public async Task<BaseResponse<int>> Handle(ResponseForWebsiteCommand Request, CancellationToken cancellationToken)
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
                    EmailMessage? ParentEmailMessageEntity = await _EmailMessageRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.MessageId);

                    if (ParentEmailMessageEntity == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Message Not Found"
                            : "الرسالة غير موجودة";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    WebSiteResponse NewWebSiteResponseEntity = _Mapper.Map<WebSiteResponse>(Request);

                    NewWebSiteResponseEntity.UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));
                    NewWebSiteResponseEntity.EmailMessageId = Request.MessageId;

                    await _WebSiteResponseRepository.AddAsync(NewWebSiteResponseEntity);

                    List<WebSiteResponseAttachment> NewWebSiteResponseAttachmentEntities = new List<WebSiteResponseAttachment>();

                    foreach (IFormFile Attachment in Request.Attachments!)
                    {
                        WebSiteResponseAttachment NewEmailAttachmentEntity = new WebSiteResponseAttachment()
                        {
                            FilePath = await _FileService.SaveFileAsync(Attachment, SystemFileType.ContactUsFiles),
                            WebSiteResponseId = NewWebSiteResponseEntity.Id
                        };

                        NewWebSiteResponseAttachmentEntities.Add(NewEmailAttachmentEntity);
                    }

                    if (NewWebSiteResponseAttachmentEntities.Any())
                        await _WebSiteResponseAttachmentRepository.AddRangeAsync(NewWebSiteResponseAttachmentEntities);

                    string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath + "/WebsiteResponsesTemplate.html");

                    byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");
                    string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                    if (string.IsNullOrEmpty(Request.EmailToSendLanguage) ||
                        Request.EmailToSendLanguage != "en" || Request.EmailToSendLanguage != "ar")
                    {
                        Request.EmailToSendLanguage = Request.lang!;
                    }

                    string FullEmailBody = string.Empty;

                    if (Request.EmailToSendLanguage == "en")
                    {
                        FullEmailBody = HTMLContent
                            .Replace("$FirstEnglishLine$", Request.Body, StringComparison.Ordinal);

                        List<string> FullEmailBodySpliter = FullEmailBody.Split("<!--Arabic Language-->").ToList();

                        FullEmailBody = FullEmailBodySpliter[0] + FullEmailBodySpliter[2];
                    }
                    else
                    {
                        FullEmailBody = HTMLContent
                            .Replace("$FirstArabicLine$", Request.Body, StringComparison.Ordinal);

                        List<string> FullEmailBodySpliter = FullEmailBody.Split("<!--English Language-->").ToList();

                        FullEmailBody = FullEmailBodySpliter[0] + FullEmailBodySpliter[2];
                    }

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(FullEmailBody, null, "text/html");

                    System.Net.Mail.LinkedResource HeaderImage = new System.Net.Mail.LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                    AlternateView.LinkedResources.Add(HeaderImage);

                    FullEmailBody = FullEmailBody
                        .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                    int.TryParse(_Configuration.GetSection("SMTP:Port").Value, out int Port);
                    string SenderEmail = _Configuration.GetSection("SMTP:SenderEmail").Value!;
                    
                    try
                    {
                        using (var Client = new System.Net.Mail.SmtpClient())
                        {
                            Client.Credentials = new NetworkCredential
                            {
                                UserName = SenderEmail,
                                Password = _Configuration.GetSection("SMTP:Password").Value!
                            };
                            Client.Host = _Configuration.GetSection("SMTP:Host").Value!;
                            Client.Port = Port;
                            Client.EnableSsl = true;

                            MailMessage Message = new MailMessage
                            {
                                From = new MailAddress(SenderEmail),
                                Subject = Request.Title,
                                IsBodyHtml = true, // Plain text body
                                Body = FullEmailBody
                            };

                            Message.AlternateViews.Add(AlternateView!);

                            if (Request.Attachments != null)
                            {
                                foreach (IFormFile Attachment in Request.Attachments)
                                {
                                    Stream stream = Attachment.OpenReadStream();

                                    // Create the attachment and add it to the message
                                    var emailAttachment = new System.Net.Mail.Attachment(stream, Attachment.FileName);
                                    Message.Attachments.Add(emailAttachment);
                                }
                            }

                            Message.To.Add(ParentEmailMessageEntity.From);

                            await Client.SendMailAsync(Message);
                        }
                    }
                    catch (SmtpException ex)
                    {
                        throw;
                    }
                    catch (Exception)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Invalid email"
                            : "البريد الإلكتروني غير فعال";
                    }

                    ParentEmailMessageEntity.Status = Domain.Constants.ContactUsConstants.MessageStatus.InProgress;

                    await _EmailMessageRepository.UpdateAsync(ParentEmailMessageEntity);
                    
                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Email response has been sent successfully"
                        : "تم إرسال الرد بنجاح";

                    return new BaseResponse<int>(ResponseMessage, true, 200, NewWebSiteResponseEntity.Id);
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
