using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.DownloadAwardPublication
{
    public class DownloadAwardPublicationQuery : IRequest<BaseResponse<DownloadPublicationDto>>
    {
        public int PublicationId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
