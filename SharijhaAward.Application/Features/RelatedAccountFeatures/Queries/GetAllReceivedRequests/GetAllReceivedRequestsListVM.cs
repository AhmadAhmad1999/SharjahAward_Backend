using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests
{
    public class GetAllReceivedRequestsListVM
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public Gender Gender { get; set; }
    }
}
