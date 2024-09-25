using SharijhaAward.Domain.Entities.AwardStatisticModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class AwardStatisticSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public AwardStatisticSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.AwardStatistics.Any())
            {
               await _context.AwardStatistics.AddRangeAsync(
                   new AwardStatistic()
                   {
                       // Id =1,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       EnglishTitle = "Award winners during training courses V1",
                       ArabicTitle = "المشتركين بالجائزة خلال الدورات 1",
                       StatisticValue = 1000,
                       CycleId = 1
                   }, new AwardStatistic()
                   {
                       // Id =2,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       EnglishTitle = "Award winners during training courses V2",
                       ArabicTitle = "المشتركين بالجائزة خلال الدورات 2",
                       StatisticValue = 2000,
                       CycleId = 1
                   }, new AwardStatistic()
                   {
                       // Id =3,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       EnglishTitle = "Award winners during training courses V3",
                       ArabicTitle = "المشتركين بالجائزة خلال الدورات 3",
                       StatisticValue = 3000,
                       CycleId = 1
                   }, new AwardStatistic()
                   {
                       // Id =4,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       EnglishTitle = "Award winners during training courses V4",
                       ArabicTitle = "المشتركين بالجائزة خلال الدورات 4",
                       StatisticValue = 4000,
                       CycleId = 1
                   }, new AwardStatistic()
                   {
                       // Id =5,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       EnglishTitle = "Award winners during training courses V5",
                       ArabicTitle = "المشتركين بالجائزة خلال الدورات 5",
                       StatisticValue = 5000,
                       CycleId = 1
                   });
                await _context.SaveChangesAsync();
            }
        }
    }
}
