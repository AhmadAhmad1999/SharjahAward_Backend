using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.MessageTypes.Queries.AsignMessageToRole
{
    public class AsignMessageToRoleQueryHandler
        : IRequestHandler<AsignMessageToRoleQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IAsyncRepository<RoleMessageType> _roleTypeRepository;

        public AsignMessageToRoleQueryHandler(IAsyncRepository<MessageType> messageTypeRepository, IAsyncRepository<Role> roleRepository, IAsyncRepository<RoleMessageType> roleTypeRepository)
        {
            _messageTypeRepository = messageTypeRepository;
            _roleRepository = roleRepository;
            _roleTypeRepository = roleTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(AsignMessageToRoleQuery request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Message Type has been Asigned To Role"
                : "تم إضافة نوع الرسالة للدور";

            var type = await _messageTypeRepository.GetByIdAsync(request.TypeId);
            var Role = await _roleRepository.Where(r => request.RoleId.Contains(r.Id)).ToListAsync();

            if (type == null || Role ==null)
            {
                msg = request.lang == "en"
                ? "Roles or Message Type Not Found"
                : "الأدوار أو نوع الرسالة غير موجودين";

                return new BaseResponse<object>(msg, false, 400);
            }

            foreach(var role in request.RoleId)
            {
                
                var RoleType = new RoleMessageType()
                {
               
                    RoleId = role,
                    MessageTypeId = request.TypeId
                };
                await _roleTypeRepository.AddAsync(RoleType);
            }
           

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
