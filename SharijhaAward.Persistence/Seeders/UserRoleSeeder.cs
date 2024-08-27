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

        public void Seed()
        {
            if (!_context.UsersRoles.Any())
            {
                _context.UsersRoles.AddRange(
                    new UserRole()
                    {
                        Id = 1,
                        UserId = 10,
                        RoleId = 5
                    }, new UserRole()
                    {
                        Id = 2,
                        UserId = 11,
                        RoleId = 5
                    }, new UserRole()
                    {
                        Id = 3,
                        UserId = 12,
                        RoleId = 5
                    }, new UserRole()
                    {
                        Id = 4,
                        UserId = 13,
                        RoleId = 5
                    }, new UserRole()
                    {
                        Id = 5,
                        UserId = 1,
                        RoleId = 1
                    }, new UserRole()
                    {
                        Id = 6,
                        UserId = 2,
                        RoleId = 1
                    }, new UserRole()
                    {
                        Id = 7,
                        UserId = 3,
                        RoleId = 1
                    }, new UserRole()
                    {
                        Id = 8,
                        UserId = 4,
                        RoleId = 1
                    }, new UserRole()
                    {
                        Id = 9,
                        UserId = 5,
                        RoleId = 1
                    }, new UserRole()
                    {
                        Id = 10,
                        UserId = 6,
                        RoleId = 2
                    }
                );
                _context.SaveChanges();
            }
        }
    }
}
