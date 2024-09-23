using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class RolePermissionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public RolePermissionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (!_context.RolePermissions.Any())
            {
                var Permissions = _context.Permissions.ToList();

                foreach (var Permission in Permissions)
                {
                    _context.RolePermissions.Add(new Domain.Entities.IdentityModels.RolePermission()
                    {
                        RoleId = 1,
                        PermissionId = Permission.Id,
                    });
                }
                 _context.SaveChangesAsync();
            }
        }
    }

}
