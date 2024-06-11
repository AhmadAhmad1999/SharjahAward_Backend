using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetResponsibilityById
{
    public class GetResponsibilityByIdQueryHandler
        : IRequestHandler<GetResponsibilityByIdQuery, BaseResponse<ResponsibilityDto>>
    {
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public GetResponsibilityByIdQueryHandler(IAsyncRepository<Role> roleRepository, IAsyncRepository<Responsibility> responsibilityRepository, IMapper mapper)
        {
            _responsibilityRepository = responsibilityRepository;
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ResponsibilityDto>> Handle(GetResponsibilityByIdQuery request, CancellationToken cancellationToken)
        {
            var Responsibility = await _responsibilityRepository.GetByIdAsync(request.Id);
            
            if(Responsibility == null)
            {
                string msg = request.lang == "en"
                ? "Responsibility not Found"
                : "المسؤولية غير موجودة";

                return new BaseResponse<ResponsibilityDto>(msg, false, 404);
            }
            var data = _mapper.Map<ResponsibilityDto>(Responsibility);

            data.RoleName = (await _roleRepository.GetByIdAsync(Responsibility.RoleId))!.ArabicName;

            return new BaseResponse<ResponsibilityDto>("", true, 200, data);
        }
    }
}
