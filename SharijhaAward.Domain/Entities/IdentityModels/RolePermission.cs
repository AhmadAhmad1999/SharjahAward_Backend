using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Domain.Model.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class RolePermission
    {
        public int Id { get; set; }
        public List<Role>? Roles { get; set; } = new();
        public List<Permission>? Permission { get; set; } = new();
    }
}
