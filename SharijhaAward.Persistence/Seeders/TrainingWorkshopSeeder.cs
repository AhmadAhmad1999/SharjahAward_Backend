using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class TrainingWorkshopSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public TrainingWorkshopSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.TrainingWorkshops.Any())
            {
                _context.TrainingWorkshops.AddRange(
                   new TrainingWorkshop()
                   {
                       isDeleted = false,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       // Id = 1,
                       CategoryId = 2,
                       ArabicDescription = "اختبار وصف ورشة تدريبية 1",
                       ArabicTitle = "اختبار عنوان ورشة تدريبية 1",
                       EnglishDescription = "Test Training Workshop Description 1",
                       EnglishTitle = "Test Training Workshop Title 1",
                       Thumbnail = "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg"
                   }, new TrainingWorkshop()
                   {
                       isDeleted = false,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       // Id = 2,
                       CategoryId = 2,
                       ArabicDescription = "اختبار وصف ورشة تدريبية 2",
                       ArabicTitle = "اختبار عنوان ورشة تدريبية 2",
                       EnglishDescription = "Test Training Workshop Description 2",
                       EnglishTitle = "Test Training Workshop Title 2",
                       Thumbnail = "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg"
                   }
                );
                _context.SaveChanges();
            }
        }
    }
}
