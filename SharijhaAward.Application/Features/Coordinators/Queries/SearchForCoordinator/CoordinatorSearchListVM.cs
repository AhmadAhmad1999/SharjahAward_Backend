using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator
{
    public class CoordinatorSearchListVM
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string SchoolName { get; set; } = string.Empty;
        public string PersonalPhoto { get; set; } = string.Empty;
    }
}
