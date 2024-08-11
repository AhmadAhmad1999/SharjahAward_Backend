﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Commands.CreateResponsibility
{
    public class CreateResponsibilityCommandHandler
        : IRequestHandler<CreateResponsibilityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public CreateResponsibilityCommandHandler( IAsyncRepository<Responsibility> responsibilityRepository, IAsyncRepository<Role> roleRepository, IMapper mapper)
        {
            _responsibilityRepository = responsibilityRepository;
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateResponsibilityCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Responsibility has been Created"
                : "تمت إضافة المسؤولية بنجاح";

            var role = await _roleRepository.GetByIdAsync(request.RoleId); 

            if(role == null)
            {
                msg = request.lang == "en"
                ? "Role not Found"
                : "الدور غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            if(role.EnglishName != "Coordinator" && role.EnglishName != "Arbitrator")
            {
                msg = request.lang == "en"
                    ? "You can't Add Responsibility for this Role"
                    : "لا يمكنك إضافة مسؤوليات لهذا الدور";

                return new BaseResponse<object>(msg, false, 400);
            }

            var Responsibility = _mapper.Map<Responsibility>(request);

            var data = await _responsibilityRepository.AddAsync(Responsibility);


            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
