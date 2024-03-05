using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupByInviteeNumber
{
    public class GetGroupByInviteeNumberQueryHandler
        : IRequestHandler<GetGroupByInviteeNumberQuery , BaseResponse<GroupDto>>
    {
        private readonly IGroupInviteeRepository _groupInviteeRepository;
        private readonly IMapper _mapper;

        public GetGroupByInviteeNumberQueryHandler(IGroupInviteeRepository groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<GroupDto>> Handle(GetGroupByInviteeNumberQuery request, CancellationToken cancellationToken)
        {
            var group = await _groupInviteeRepository.GetByInviteeNumber(request.InviteeNumber);
            string msg;
            if (group == null)
            {
                msg = request.lang == "en"
                    ? "Group Invitee Not Found"
                    : "الدعوة الجماعية غير موجودة";
                return new BaseResponse<GroupDto>(msg, false, 404);
            }

            var data = _mapper.Map<GroupDto>(group);

            return new BaseResponse<GroupDto>("", true, 200,data);

        }
    }
}
