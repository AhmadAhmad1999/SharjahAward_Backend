﻿using SharijhaAward.Domain.Entities.CoordinatorModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class CoordinatorSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public CoordinatorSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Coordinators.Any())
            {
                await _context.Coordinators.AddRangeAsync(
                new Coordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id =1,
                    ArabicName = "منسق 1",
                    Email = "Coordinator@Coordinator.com",
                    EnglishName = "Coordinator 1",
                    PhoneNumber = "009710512345678"
                }, new Coordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id =2,
                    ArabicName = "منسق 2",
                    Email = "Coordinator2@Coordinator2.com",
                    EnglishName = "Coordinator 2",
                    PhoneNumber = "009710585469325"
                }, new Coordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id =3,
                    ArabicName = "منسق 3",
                    Email = "Coordinator3@Coordinator3.com",
                    EnglishName = "Coordinator 3",
                    PhoneNumber = "009710598563247"
                }, new Coordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 4,
                    ArabicName = "منسق 4",
                    Email = "Coordinator4@Coordinator4.com",
                    EnglishName = "Coordinator 4",
                    PhoneNumber = "009710574596825"
                });
                await _context.SaveChangesAsync();
            }
        }
    }
}
