using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.WebSiteResponseModel;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllWebsiteResponsesForMessage
{
    public class GetAllWebsiteResponsesForMessageHandler 
        : IRequestHandler<GetAllWebsiteResponsesForMessageQuery, BaseResponse<List<GetAllWebsiteResponsesForMessageListVM>>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        private readonly IAsyncRepository<WebSiteResponse> _WebSiteResponseRepository;
        private readonly IAsyncRepository<WebSiteResponseAttachment> _WebSiteResponseAttachmentRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllWebsiteResponsesForMessageHandler(IUserRepository _UserRepository,
            IAsyncRepository<EmailMessage> _EmailMessageRepository,
            IAsyncRepository<WebSiteResponse> _WebSiteResponseRepository,
            IAsyncRepository<WebSiteResponseAttachment> _WebSiteResponseAttachmentRepository,
            IJwtProvider _JWTProvider,
            IFileService _FileService,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._UserRepository = _UserRepository;
            this._EmailMessageRepository = _EmailMessageRepository;
            this._WebSiteResponseRepository = _WebSiteResponseRepository;
            this._WebSiteResponseAttachmentRepository = _WebSiteResponseAttachmentRepository;
            this._JWTProvider = _JWTProvider;
            this._FileService = _FileService;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<GetAllWebsiteResponsesForMessageListVM>>> 
            Handle(GetAllWebsiteResponsesForMessageQuery Request, CancellationToken cancellationToken)
        {
            List<WebSiteResponse> WebSiteResponseEntities = _WebSiteResponseRepository
                .Where(x => x.EmailMessageId == Request.MessageId)
                .ToList();

            List<WebSiteResponseAttachment> WebSiteResponseAttachmentEntities = _WebSiteResponseAttachmentRepository
                .Where(x => WebSiteResponseEntities.Select(y => y.Id).Contains(x.WebSiteResponseId))
                .ToList();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<GetAllWebsiteResponsesForMessageListVM> Response = WebSiteResponseEntities
                .Select(x => new GetAllWebsiteResponsesForMessageListVM()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Body = x.Body,
                    UserId = x.UserId,
                    UserName = Request.lang == "en"
                        ? x.User!.EnglishName
                        : x.User!.ArabicName,
                    Attachments = WebSiteResponseAttachmentEntities
                        .Where(y => y.WebSiteResponseId == x.Id)
                        .Select(y => y.FilePath.Contains("wwwroot")
                            ? (WWWRootFilePath + y.FilePath.Split("wwwroot")[1]).Replace("\\", "/")
                            : y.FilePath.Replace("\\", "/"))
                        .ToList()
                }).ToList();

            return new BaseResponse<List<GetAllWebsiteResponsesForMessageListVM>>(string.Empty, true, 200, Response);
        }
    }
}
