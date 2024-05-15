﻿using MediatR;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit
{
    public class GetAllFormsForArbitrationAuditQuery : IRequest<BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>>
    {
        public bool? ItExceededTheMarginOfDifferenceInArbitrationScores { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
