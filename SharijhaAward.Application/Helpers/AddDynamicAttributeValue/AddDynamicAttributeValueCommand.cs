﻿using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValue
{
    public class AddDynamicAttributeValueCommand : IRequest<BaseResponse<AddDynamicAttributeValueResponse>>
    {
        public int RecordId { get; set; }
        public List<AddDynamicAttributeValueMainCommand> DynamicAttributesWithValues { get; set; } = new List<AddDynamicAttributeValueMainCommand>();
        public List<AddDynamicAttributeTableValueMainCommand> DynamicAttributesWithTableValues { get; set; } = new List<AddDynamicAttributeTableValueMainCommand>();
        public List<AddDynamicAttributeValueMobileCommand>? DynamicAttributesWithValuesMobile { get; set; }
        public List<AddDynamicAttributeTableValueMobileCommand>? DynamicAttributesWithTableValuesMobile { get; set; }
        public List<IFormFile>? ValueAsBinaryFiles { get; set; }
        public List<IFormFile>? ValueAsBinaryFilesForTable { get; set; }
        public int? EventId { get; set; }
        public InviteeTypes? InviteeType { get; set; }
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
