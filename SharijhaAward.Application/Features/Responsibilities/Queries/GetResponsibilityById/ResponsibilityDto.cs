using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetResponsibilityById
{
    public class ResponsibilityDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int RoleId { get; set; }
    }
}
