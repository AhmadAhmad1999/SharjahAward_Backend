using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class CoordinatorSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public CoordinatorSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Coordinators.Any())
            {
                _context.Coordinators.AddRange(
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
                    PhoneNumber = "0993521579"
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
                    PhoneNumber = "0993521579"
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
                    PhoneNumber = "0993521579"
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
                    PhoneNumber = "0993521579"
                });
                _context.SaveChanges();
            }
        }
    }
}
