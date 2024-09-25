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
        public async Task Seed()
        {
            if (!_context.RolePermissions.Any())
            {
                var Permissions = _context.Permissions.ToList();

                foreach (var Permission in Permissions)
                {
                    await _context.RolePermissions.AddAsync(
                          new Domain.Entities.IdentityModels.RolePermission()
                          {
                              RoleId = 1,
                              PermissionId = Permission.Id,
                          });
                }
                 await _context.SaveChangesAsync();
            }
        }
    }

}
