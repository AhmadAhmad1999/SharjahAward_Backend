using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById
{
    public class GetEmailMessageByIdQueryHandler
        : IRequestHandler<GetEmailMessageByIdQuery, BaseResponse<EmailMessageDto>>
    {
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        private readonly IAsyncRepository<EmailAttachment> _EmailAttachmentRepository;
        private readonly IAsyncRepository<MessageType> _MessageTypeRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;

        public GetEmailMessageByIdQueryHandler(IAsyncRepository<MessageType> _MessageTypeRepository, IAsyncRepository<EmailMessage> _EmailMessageRepository, IAsyncRepository<EmailAttachment> _EmailAttachmentRepository, IUserRepository _UserRepository, IJwtProvider _JwtProvider, IMapper _Mapper)
        {
            this._EmailMessageRepository = _EmailMessageRepository;
            this._EmailAttachmentRepository = _EmailAttachmentRepository;
            this._MessageTypeRepository = _MessageTypeRepository;
            this._UserRepository = _UserRepository;
            this._JwtProvider = _JwtProvider;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<EmailMessageDto>> Handle(GetEmailMessageByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token));
            
            var User = await _UserRepository.GetByIdAsync(UserId);

            EmailMessage? EmailMessageEntity = await _EmailMessageRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EmailMessageEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Message Not Found"
                    : "الرسالة غير موجودة";

                return new BaseResponse<EmailMessageDto>(ResponseMessage, false, 404);
            }

            if (EmailMessageEntity.To == User!.Email && !EmailMessageEntity.IsRead)
            {
                EmailMessageEntity.IsRead = true;
                await _EmailMessageRepository.UpdateAsync(EmailMessageEntity);
            }

            EmailMessageDto Response = _Mapper.Map<EmailMessageDto>(EmailMessageEntity);

            Response.Attachments = _Mapper.Map<List<EmailAttachmentListVm>>(await _EmailAttachmentRepository
                .Where(x => x.MessageId == Response.Id).ToListAsync());

            Response.PersonalPhotoUrl = EmailMessageEntity.User is not null
                ? EmailMessageEntity.User.ImageURL!
                : string.Empty;

            Response.Gender = EmailMessageEntity.User is not null
                ? EmailMessageEntity.User.Gender
                : null;

            Response.TypeName = Request.lang == "en" 
                ? EmailMessageEntity.Type!.EnglishType 
                : EmailMessageEntity.Type!.ArabicType;

            List<EmailMessage> ReplayMessages = await _EmailMessageRepository
                .Where(x => x.MessageId == EmailMessageEntity.Id &&
                    x.Id != EmailMessageEntity.Id)
                .ToListAsync();

            List<EmailAttachment> AllEmailAttachmentEntities = await _EmailAttachmentRepository
                .Where(x => ReplayMessages.Select(y => y.Id).Contains(x.MessageId))
                .ToListAsync();

            Response.ReplayMessages = ReplayMessages
                .Select(x => new EmailMessageDto()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    From = x.From,
                    To = x.To,
                    Body = x.Body,
                    TypeId = x.TypeId,
                    TypeName = Request.lang == "en"
                        ? x.Type.EnglishType
                        : x.Type.ArabicType,
                    Status = x.Status,
                    IsRead = x.IsRead,
                    MessageId = x.MessageId,
                    IsReplay = x.MessageId == x.Id
                        ? false
                        : true,
                    CreatedAt = x.CreatedAt,
                    PersonalPhotoUrl = User!.ImageURL!,
                    Gender = User!.Gender!,
                    Attachments = _Mapper.Map<List<EmailAttachmentListVm>>(AllEmailAttachmentEntities
                        .Where(y => x.Id == y.MessageId)
                        .ToList()),
                    FromWebsite = EmailMessageEntity.UserId == null
                        ? true : false
                }).ToList();

            return new BaseResponse<EmailMessageDto>("", true, 200, Response);
        }
    }
}
