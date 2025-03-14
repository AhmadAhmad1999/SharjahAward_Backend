﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoryQuery : IRequest<BaseResponse<List<CategoryListVM>>>
    {
        public int page {  get; set; }
        public int perPage { get; set; }
        public string lang { get; set; } = string.Empty;
        public int? CycleId { get; set; }
    }
}
