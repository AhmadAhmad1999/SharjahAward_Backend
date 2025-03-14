﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetGeneralFAQById
{
    public class GetGeneralFAQByIdQuery : IRequest<BaseResponse<GeneralFAQDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
