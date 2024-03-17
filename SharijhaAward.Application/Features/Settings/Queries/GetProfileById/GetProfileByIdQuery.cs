﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Queries.GetProfileById
{
    public class GetProfileByIdQuery : IRequest<BaseResponse<GetProfileByIdDto>>
    {
        public Guid Id { get; set; }
        public string? lang { get; set; }
    }
}
