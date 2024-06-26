using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class UserRepositoryDto
    {
        public int Id { get; set; }
        public int UserId {  get; set; }
        public int ResponsibilityId { get; set; }
        public bool IsAccept { get; set; }
    }
}
