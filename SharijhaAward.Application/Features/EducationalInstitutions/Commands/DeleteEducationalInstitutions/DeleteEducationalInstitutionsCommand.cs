﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.DeleteEducationalInstitutions
{
    public class DeleteEducationalInstitutionsCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string? lang { get; set; }
    }
}
