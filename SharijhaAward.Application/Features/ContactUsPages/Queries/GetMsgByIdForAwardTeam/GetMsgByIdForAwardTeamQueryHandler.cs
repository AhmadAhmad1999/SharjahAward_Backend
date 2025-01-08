using AutoMapper;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetMsgByIdForAwardTeam
{
    public class GetMsgByIdForAwardTeamQueryHandler
        : IRequestHandler<GetMsgByIdForAwardTeamQuery, BaseResponse<EmailMessageDto>>
    {
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        private readonly IAsyncRepository<EmailAttachment> _EmailAttachmentRepository;
        private readonly IAsyncRepository<RoleMessageType> _RoleMessageTypeRepository;
        private readonly IAsyncRepository<MessageType> _MessageTypeRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;

        public GetMsgByIdForAwardTeamQueryHandler(IAsyncRepository<RoleMessageType> _RoleMessageTypeRepository, IAsyncRepository<UserRole> _UserRoleRepository, IAsyncRepository<EmailMessage> _EmailMessageRepository, IAsyncRepository<EmailAttachment> _EmailAttachmentRepository, IAsyncRepository<MessageType> _MessageTypeRepository, IUserRepository _UserRepository, IJwtProvider _JwtProvider, IMapper _Mapper)
        {
            this._EmailMessageRepository = _EmailMessageRepository;
            this._EmailAttachmentRepository = _EmailAttachmentRepository;
            this._MessageTypeRepository = _MessageTypeRepository;
            this._RoleMessageTypeRepository = _RoleMessageTypeRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._UserRepository = _UserRepository;
            this._JwtProvider = _JwtProvider;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<EmailMessageDto>> Handle(GetMsgByIdForAwardTeamQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token));
            
            var User = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            List<int> RoleIds = await _UserRoleRepository
                .Where(x => x.UserId == UserId)
                .Select(x => x.RoleId)
                .ToListAsync();
           
            List<int> MessageTypeIds = await _RoleMessageTypeRepository
                .Where(x => RoleIds.Contains(x.RoleId))
                .Select(x => x.MessageTypeId)
                .ToListAsync();

            EmailMessage? EmailMessageEntity = await _EmailMessageRepository
                .FirstOrDefaultAsync(m => m.Id == Request.Id);
            
            if (EmailMessageEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Message is not found"
                    : "الرسالة غير موجودة";

                return new BaseResponse<EmailMessageDto>(ResponseMessage, false, 404);
            }

            if (!EmailMessageEntity.IsRead)
            {
                EmailMessageEntity.IsRead = true;
                EmailMessageEntity.Status = Domain.Constants.ContactUsConstants.MessageStatus.InProgress;
                await _EmailMessageRepository.UpdateAsync(EmailMessageEntity);
            }

            EmailMessageDto Response = _Mapper.Map<EmailMessageDto>(EmailMessageEntity);

            if (EmailMessageEntity.UserId is null)
                Response.FromWebsite = true;

            Response.Attachments = _Mapper.Map<List<EmailAttachmentListVm>>(await _EmailAttachmentRepository
                .Where(x => x.MessageId == Response.Id).ToListAsync());

            Response.PersonalPhotoUrl = EmailMessageEntity.User is not null 
                ? EmailMessageEntity.User!.ImageURL!
                : string.Empty;

            Response.Gender = EmailMessageEntity.User is not null
                ? EmailMessageEntity.User!.Gender
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
