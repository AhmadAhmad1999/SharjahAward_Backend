using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Indexes.Queries.GetAllIndexes
{
    public class GetAllIndexesQuery : IRequest<BaseResponse<List<IndexesListVM>>>
    {
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
