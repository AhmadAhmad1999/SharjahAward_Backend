using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class GeneralWorkshopSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public GeneralWorkshopSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.GeneralWorkshops.Any())
            {
               await _context.GeneralWorkshops.AddRangeAsync(
                    new GeneralWorkshop()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        // Id = 1,
                        EnglishTitle = "Test General Workshop Title 1",
                        EnglishDescription = "Test General Workshop Description 1",
                        ArabicTitle = "اختبار عنوان الورش العامة 1",
                        ArabicDescription = "اختبار وصف الورش العامة 1",
                        AgendaImage = null,
                        DateOfWorkShop = DateTime.UtcNow.AddDays(10),
                        DayName = DateTime.UtcNow.AddDays(10).DayOfWeek.ToString(),
                        RegistrationUrl = null,
                        Thumbnale = "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg",
                        Time = "10:00 - 12:00",
                        Video = null
                    }, new GeneralWorkshop()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        // Id = 2,
                        EnglishTitle = "Test General Workshop Title 2",
                        EnglishDescription = "Test General Workshop Description 2",
                        ArabicTitle = "اختبار عنوان الورش العامة 2",
                        ArabicDescription = "اختبار وصف الورش العامة 2",
                        AgendaImage = null,
                        DateOfWorkShop = DateTime.UtcNow.AddDays(20),
                        DayName = DateTime.UtcNow.AddDays(20).DayOfWeek.ToString(),
                        RegistrationUrl = null,
                        Thumbnale = "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg",
                        Time = "2:00 - 3:00",
                        Video = null
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
