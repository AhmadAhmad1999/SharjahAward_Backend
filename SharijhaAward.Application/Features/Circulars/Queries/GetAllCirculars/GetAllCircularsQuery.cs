using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars
{
    public class GetAllCircularsQuery : IRequest<BaseResponse<List<CircularListVm>>>
    {
        public string token { get; set; } = string.Empty;
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
