﻿using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Persistence.Seeders
{
    public class RoleSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public RoleSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Roles.Any())
            {
                await _context.Roles.AddRangeAsync(
                   new Role
                   {
                       // Id = 1,
                       EnglishName = "Admin",
                       ArabicName = "ادمن"
                   },
                   new Role
                   {
                       // Id = 2,
                       EnglishName = "Subscriber",
                       ArabicName = "مشترك"
                   },
                   new Role
                   {
                       // Id = 3,
                       EnglishName = "Manager",
                       ArabicName = "مدير"
                   },
                   new Role
                   {
                       // Id = 4,
                       EnglishName = "User",
                       ArabicName = "مستخدم"
                   },
                   new Role
                   {
                       // Id = 5,
                       EnglishName = "Coordinator",
                       ArabicName = "منسق"
                   }, new Role
                   {
                       // Id = 6,
                       EnglishName = "Arbitrator",
                       ArabicName = "محكم"
                   },
                   new Role
                   {
                       // Id = 5,
                       EnglishName = "Subcommittee Chairman",
                       ArabicName = "رئيس لجنة فرعية"
                   }, new Role
                   {
                       // Id = 6,
                       EnglishName = "Chief Arbitrator",
                       ArabicName = "رئيس المحكمين"
                   },
                   new Role
                   {
                       // Id = 5,
                       EnglishName = "Chairman of Committees",
                       ArabicName = "رئيس اللجان"
                   }, new Role
                   {
                       // Id = 6,
                       EnglishName = "Award Team",
                       ArabicName = "فريق الجائزة"
                   }, new Role
                   {
                       // Id = 7,
                       EnglishName = "Expert",
                       ArabicName = "خبير"
                   }, new Role
                   {
                       // Id = 8,
                       EnglishName = "Quality",
                       ArabicName = "الجودة"
                   }
                );
                await _context.SaveChangesAsync();
            }
        }
    }
}
