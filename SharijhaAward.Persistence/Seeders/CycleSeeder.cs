using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class CycleSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public CycleSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Cycles.Any())
            {
                _context.Cycles.AddRange(
                   new Cycle()
                   {
                       //Id = 1,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       CycleNumber = 31,
                       Year = "2024 - 2025",
                       ArabicName = "جائزة الشارقة للتفوق والتميز التربوي",
                       EnglishName = "Sharjah Award for Educational Excellence",
                       Status = Domain.Constants.Common.Status.Active,
                       RegistrationPortalOpeningDate = new DateTime(2024, 1, 1),
                       RegistrationPortalClosingDate = new DateTime(2030, 5, 1),
                       SubscriberPortalClosingDate = null,
                       InitialArbitrationStartDate = null,
                       InitialArbitrationEndDate = null,
                       FinalArbitrationStartDate = null,
                       FinalArbitrationEndDate = null,
                       IndividualCategoryNumber = 1,
                       TheUpperLimitForObtainingInformation = 10,
                       MarginOfDifferenceBetweenArbitrators = 10,
                       GroupCategoryNumber = 1
                   });
                _context.SaveChanges();
            }
        }
    }
}
