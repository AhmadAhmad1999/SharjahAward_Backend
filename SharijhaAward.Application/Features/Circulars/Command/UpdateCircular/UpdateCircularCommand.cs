using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.UpdateCircular
{
    public class UpdateCircularCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CircularText { get; set; } = string.Empty;
        public List<int>? CoordinatorId { get; set; }
        public List<int>? ArbitratorId { get; set; }
        public List<int>? ChairmanId { get; set; }
        public bool AllCoordinators { get; set; }
        public bool AllArbitrators { get; set; }
        public bool AllChairmans { get; set; }
        public string? lang { get; set; }
        public string? token { get; set; }
    }
}
