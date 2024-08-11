using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Features.Circulars.Queries.GetCircularById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars
{
    public class CircularListVm
    {
        public List<CircularDto>? Circulars { get; set; }
        public int? NumberOfUnRead { get; set; }
    }
}
