﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.WinnersFeatures.Commands.ConfirmSelectedWinningForms
{
    public class ConfirmSelectedWinningFormsCommand : IRequest<BaseResponse<object>>
    {
        public int CategoryId { get; set; }
        public int? EducationalClassId { get; set; }
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
