﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.WinnersFeatures.Commands.SelectWinningForms
{
    public class SelectWinningFormsCommand : IRequest<BaseResponse<object>>
    {
        public int CategoryId { get; set; }
        public List<int> FormsIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
