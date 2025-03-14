﻿using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFormsForFinalArbitration
{
    public class GetAllFormsForFinalArbitrationQuery : IRequest<BaseResponse<GetAllFormsForFinalArbitrationMainListVM>>
    {
        public ArbitrationType? ArbitrationType { get; set; }
        public string? Token { get; set; }
        public bool? AsChairman { get; set; }
        public bool AsFullAccess { get; set; }
        public bool asNormalArbitrator { get; set; }
        public bool asSubcommitteeOfficer { get; set; }
        public bool asChairmanOfCommittees { get; set; }
        public bool asExpert { get; set; }
        public bool asQuality { get; set; }
        public string? SubscriberName { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
