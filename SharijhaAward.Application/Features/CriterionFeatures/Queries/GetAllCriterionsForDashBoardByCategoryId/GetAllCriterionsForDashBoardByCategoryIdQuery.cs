﻿using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionsForDashBoardByCategoryId
{
    public class GetAllCriterionsForDashBoardCategoryIdQuery : IRequest<BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>>
    {
        public Guid CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
