using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage
{
    public class GetAllEmailMessageQueryHandler
        : IRequestHandler<GetAllEmailMessageQuery, BaseResponse<List<EmailMessageListVM>>>
    {
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        private readonly IAsyncRepository<MessageType> _MessageTypeRepository;
        private readonly IAsyncRepository<EmailAttachment> _EmailAttachmentRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository;
        private readonly IMapper _Mapper;

        public GetAllEmailMessageQueryHandler(IAsyncRepository<EmailMessage> _EmailMessageRepository, 
            IAsyncRepository<MessageType> _MessageTypeRepository, 
            IAsyncRepository<EmailAttachment> _EmailAttachmentRepository,
            IJwtProvider _JWTProvider, 
            IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository, 
            IMapper _Mapper)
        {
            this._EmailMessageRepository = _EmailMessageRepository;
            this._MessageTypeRepository = _MessageTypeRepository;
            this._EmailAttachmentRepository = _EmailAttachmentRepository;
            this._JWTProvider = _JWTProvider;
            this._UserRepository = _UserRepository;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<List<EmailMessageListVM>>> Handle(GetAllEmailMessageQuery Request, CancellationToken cancellationToken)
        {
            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            Domain.Entities.IdentityModels.User? User = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserId)!;

            List<EmailMessage> EmailMessages = new List<EmailMessage>();

            List<EmailMessage> MainEmailMessageEntities = await _EmailMessageRepository
                .Where(x => x.Id == x.MessageId &&
                    x.UserId == UserId)
                .ToListAsync();

            foreach (EmailMessage MainEmailMessageEntity in MainEmailMessageEntities)
            {
                EmailMessage? ResponseEmailMessageEntities = await _EmailMessageRepository
                    .Where(x => x.MessageId == MainEmailMessageEntity.Id && 
                        x.Id != MainEmailMessageEntity.Id)
                    .OrderByDescending(x => x.CreatedAt)
                    .FirstOrDefaultAsync();

                if (ResponseEmailMessageEntities is null)
                    EmailMessages.Add(MainEmailMessageEntity);

                else
                    EmailMessages.Add(ResponseEmailMessageEntities);
            }

            if (Request.filter == 1)
            {
                EmailMessages = EmailMessages
                  .Where(x => x.From == User!.Email)
                  .OrderByDescending(x => x.CreatedAt)
                  .Skip((Request.page - 1) * Request.perPage)
                  .Take(Request.perPage)
                  .ToList();
            }

            if (Request.filter == 2)
            {
                EmailMessages = EmailMessages
                   .Where(x => x.To == User!.Email)
                   .OrderByDescending(x => x.CreatedAt)
                   .Skip((Request.page - 1) * Request.perPage)
                   .Take(Request.perPage)
                   .ToList();
            }

            if (Request.query != null)
            {
                EmailMessages = _EmailMessageRepository
                    .Where(m => m.Body.Contains(Request.query))
                    .OrderByDescending(x => x.CreatedAt).ToList();
            }

            List<EmailAttachment> AllEmailAttachmentEntities = await _EmailAttachmentRepository
                .Where(x => EmailMessages.Select(y => y.Id).Contains(x.MessageId))
                .ToListAsync();

            List<EmailMessageListVM> Response = EmailMessages
                .Select(x => new EmailMessageListVM()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    From = x.From,
                    To = x.To,
                    Body = x.Body,
                    TypeId = x.TypeId,
                    TypeName = Request.lang == "en"
                        ? x.Type!.EnglishType
                        : x.Type!.ArabicType,
                    Status = x.Status,
                    MessageId = x.MessageId,
                    IsReplay = x.MessageId == x.Id
                        ? false
                        : true,
                    IsRead = x.IsRead,
                    IsOutComing = User!.Email == x.From 
                        ? true 
                        : false,
                    CreatedAt = x.CreatedAt,
                    PersonalPhotoUrl = x.UserId != null 
                        ? x.User!.ImageURL!
                        : string.Empty,
                    Gender = x.UserId != null 
                        ? x.User!.Gender
                        : null,
                    Attachments = _Mapper.Map<List<EmailAttachmentListVm>>(AllEmailAttachmentEntities
                        .Where(x => x.MessageId == x.Id)
                        .ToList())
                }).ToList();
            
            int UnReadingMessages = await _EmailMessageRepository
                .GetCountAsync(x => !x.IsRead && x.To == User!.Email);

            int TotalCount = await _EmailMessageRepository
                .GetCountAsync(x => (x.To == User!.Email || 
                    x.From == User.Email) &&
                    x.MessageId == x.Id);
            
            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);
               
            return new BaseResponse<List<EmailMessageListVM>>("", true, 200, Response, Pagination,UnReadingMessages);
        }
    }
}