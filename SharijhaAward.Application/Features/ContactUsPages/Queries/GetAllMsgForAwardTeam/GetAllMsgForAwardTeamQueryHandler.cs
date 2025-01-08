using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllMsgForAwardTeam
{
    public class GetAllMsgForAwardTeamQueryHandler
        : IRequestHandler<GetAllMsgForAwardTeamQuery, BaseResponse<List<EmailMessageListVM>>>
    {
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        private readonly IAsyncRepository<MessageType> _MessageTypeRepository;
        private readonly IAsyncRepository<RoleMessageType> _RoleMessageTypeRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<EmailAttachment> _EmailAttachmentRepository;

        public GetAllMsgForAwardTeamQueryHandler(IUserRepository _UserRepository, 
            IAsyncRepository<MessageType> _MessageTypeRepository, 
            IAsyncRepository<EmailMessage> _EmailMessageRepository, 
            IAsyncRepository<RoleMessageType> _RoleMessageTypeRepository, 
            IAsyncRepository<UserRole> _UserRoleRepository, 
            IJwtProvider _JWTProvider, 
            IMapper _Mapper,
            IAsyncRepository<EmailAttachment> _EmailAttachmentRepository)
        {
            this._EmailMessageRepository = _EmailMessageRepository;
            this._RoleMessageTypeRepository = _RoleMessageTypeRepository;
            this._MessageTypeRepository = _MessageTypeRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._UserRepository = _UserRepository;
            this._JWTProvider = _JWTProvider;
            this._Mapper = _Mapper;
            this._EmailAttachmentRepository = _EmailAttachmentRepository;
        }

        public async Task<BaseResponse<List<EmailMessageListVM>>> Handle(GetAllMsgForAwardTeamQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));
           
            var User = await _UserRepository.GetByIdAsync(UserId);

            List<int> RoleIds = await _UserRoleRepository.Where(x => x.UserId == UserId)
                .Select(x => x.RoleId)
                .ToListAsync();
            
            List<int> MessageTypeIds = await _RoleMessageTypeRepository
                .Where(x => RoleIds.Contains(x.RoleId))
                .Select(x => x.MessageTypeId)
                .ToListAsync();
            
            List<EmailMessageListVM> EmailMessages = await _EmailMessageRepository
                .Where(x => (x.AsignId == null
                    ? (MessageTypeIds.Contains(x.TypeId) &&
                        x.Id == x.MessageId)
                    : (x.AsignId == UserId)) &&
                    (Request.FromWebsite 
                        ? x.UserId == null 
                        : x.UserId != null))
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.perPage)
                .Take(Request.perPage)
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
                    IsReplay = x.Id == x.MessageId
                        ? false : true,
                    IsRead = x.IsRead,
                    CreatedAt = x.CreatedAt,
                    PersonalPhotoUrl = x.User!.ImageURL,
                    Gender = x.User!.Gender
                }).ToListAsync();
            
            int Count = await _EmailMessageRepository
                .GetCountAsync(x => (x.AsignId == null
                    ? (MessageTypeIds.Contains(x.TypeId) &&
                        x.Id == x.MessageId)    
                    : (x.AsignId == UserId)) &&
                    (Request.FromWebsite
                        ? x.UserId == null
                        : x.UserId != null));

            List<EmailMessageListVM> Response = _Mapper.Map<List<EmailMessageListVM>>(EmailMessages);
            
            Pagination Pagination = new Pagination(Request.page, Request.perPage, Count);
            
            return new BaseResponse<List<EmailMessageListVM>>(ResponseMessage, true, 200, Response, Pagination, Count);
        }
    }
}
