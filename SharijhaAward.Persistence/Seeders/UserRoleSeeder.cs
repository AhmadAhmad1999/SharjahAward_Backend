using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class UserRoleSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public UserRoleSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.UsersRoles.Any())
            {
               // _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.UsersRoles ON");
               await _context.UsersRoles.AddRangeAsync(
                    new UserRole()
                    {
                        // Id =1,
                        UserId = 1,
                        RoleId = 5
                    }, new UserRole()
                    {
                        // Id =2,
                        UserId = 2,
                        RoleId = 5
                    }, new UserRole()
                    {
                        // Id =3,
                        UserId = 3,
                        RoleId = 5
                    }, new UserRole()
                    {
                        // Id =4,
                        UserId = 4,
                        RoleId = 5
                    }, new UserRole()
                    {
                        // Id =5,
                        UserId = 5,
                        RoleId = 1
                    }, new UserRole()
                    {
                        // Id =6,
                        UserId = 6,
                        RoleId = 1
                    }, new UserRole()
                    {
                        // Id =7,
                        UserId = 7,
                        RoleId = 1
                    }, new UserRole()
                    {
                        // Id =8,
                        UserId = 8,
                        RoleId = 1
                    }, new UserRole()
                    {
                        // Id =9,
                        UserId = 9,
                        RoleId = 1
                    }, new UserRole()
                    {
                        // Id =10,
                        UserId = 10,
                        RoleId = 2
                    }, new UserRole()
                    {
                        // Id =10,
                        UserId = 11,
                        RoleId = 2
                    }
                );
                await _context.SaveChangesAsync();

                //_context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.UsersRoles OFF");
            }
        }
    }
}
