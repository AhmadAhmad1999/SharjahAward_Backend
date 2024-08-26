using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class RoleSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public RoleSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Roles.Any())
            {
                _context.Roles.AddRange(
                   new Role
                   {
                       Id = 1,
                       EnglishName = "Admin",
                       ArabicName = "ادمن"
                   },
                   new Role
                   {
                       Id = 2,
                       EnglishName = "Subscriber",
                       ArabicName = "مشترك"
                   },
                   new Role
                   {
                       Id = 3,
                       EnglishName = "Manager",
                       ArabicName = "مدير"
                   },
                   new Role
                   {
                       Id = 4,
                       EnglishName = "User",
                       ArabicName = "مستخدم"
                   },
                   new Role
                   {
                       Id = 5,
                       EnglishName = "Coordinator",
                       ArabicName = "منسق"
                   }, new Role
                   {
                       Id = 6,
                       EnglishName = "Arbitrator",
                       ArabicName = "محكم"
                   }
                );
                _context.SaveChanges();
            }
        }
    }
}
