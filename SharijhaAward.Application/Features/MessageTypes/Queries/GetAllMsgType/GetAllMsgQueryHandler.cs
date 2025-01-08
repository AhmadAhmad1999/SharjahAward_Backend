using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;

namespace SharijhaAward.Application.Features.MessageTypes.Queries.GetAllMsgType
{
    public class GetAllMsgQueryHandler 
        : IRequestHandler<GetAllMsgQuery, BaseResponse<List<MessageTypeListVM>>>
    {
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IAsyncRepository<RoleMessageType> _RoleMessageTypeRepository;
        private readonly IAsyncRepository<MessageType> _MessageTypeRepository;

        public GetAllMsgQueryHandler(IAsyncRepository<Role> _RoleRepository, 
            IAsyncRepository<RoleMessageType> _RoleMessageTypeRepository, 
            IAsyncRepository<MessageType> _MessageTypeRepository)
        {
            this._RoleRepository = _RoleRepository;
            this._RoleMessageTypeRepository = _RoleMessageTypeRepository;
            this._MessageTypeRepository = _MessageTypeRepository;
        }

        public async Task<BaseResponse<List<MessageTypeListVM>>>
            Handle(GetAllMsgQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<MessageType> MessageTypeEntities = await _MessageTypeRepository
                .OrderByDescending(x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync();

            List<RoleMessageType> RoleMessageTypeEntities = await _RoleMessageTypeRepository
                .Where(x => MessageTypeEntities.Select(y => y.Id).Contains(x.MessageTypeId))
                .ToListAsync();

            List<MessageTypeListVM> Response = MessageTypeEntities
                .Select(x => new MessageTypeListVM()
                {
                    Id = x.Id,
                    Type = Request.lang == "en" 
                        ? x.EnglishType
                        : x.ArabicType,
                    ArabicType = x.ArabicType,
                    EnglishType = x.EnglishType,
                    RoleName = RoleMessageTypeEntities
                        .Where(y => y.MessageTypeId == x.Id)
                        .Select(y => y.Role!)
                        .Select(y => new MessageTypeRoleDto()
                        {
                            Id = y.Id,
                            RoleName = Request.lang == "en"
                                ? y.EnglishName
                                : y.ArabicName
                        }).ToList()
                }).ToList();

            int TotalCount = await _MessageTypeRepository.GetCountAsync(null);

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<MessageTypeListVM>>(ResponseMessage, true, 200, Response, Pagination);
        }
    }
}
