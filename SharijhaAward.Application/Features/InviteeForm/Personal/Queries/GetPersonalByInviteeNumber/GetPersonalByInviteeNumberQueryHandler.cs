using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalByInviteeNumber
{
    public class GetPersonalByInviteeNumberQueryHandler
        : IRequestHandler<GetPersonalByInviteeNumberQuery , BaseResponse<PersonalDto>>
    {
        private readonly IPersonalInviteeRepository _personalInviteeRepository;
        private readonly IMapper _mapper;

        public GetPersonalByInviteeNumberQueryHandler(IPersonalInviteeRepository personalInviteeRepository, IMapper mapper)
        {
            _personalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<PersonalDto>> Handle(GetPersonalByInviteeNumberQuery request, CancellationToken cancellationToken)
        {
            string msg;
            var personal = await _personalInviteeRepository.GetByInviteeNumber(request.InviteeNumber);
            if (personal == null)
            {
                msg = request.lang == "en"
                    ? "Personal Invitee not found"
                    : "الدعوة الفردية غير موجودة";

                return new BaseResponse<PersonalDto>(msg, false, 404);
            }
            var data = _mapper.Map<PersonalDto>(personal);

            return new BaseResponse<PersonalDto>("", true, 200, data);
        }
    }
}
